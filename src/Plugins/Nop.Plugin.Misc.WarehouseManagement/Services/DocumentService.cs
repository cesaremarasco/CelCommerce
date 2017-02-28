﻿using Nop.Plugin.Misc.WarehouseManagement.Domain;
using Nop.Core.Data;
using System;
using Nop.Core;
using Nop.Core.Domain.Common;
using System.Linq;
using Nop.Core.Domain.Customers;
using System.Collections.Generic;

namespace Nop.Plugin.Misc.WarehouseManagement.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IRepository<Document> _documentRepository;
        private readonly IRepository<GenericAttribute> _genericAttributeRepository;
        private readonly IRepository<DocumentCustomer> _documentCustomerRepository;
        private readonly IRepository<DocumentFooter> _documentFooterRepository;
        private readonly IRepository<DocumentType> _documentTypeRepository;

        private readonly IRepository<Customer> _customerRepository;       

        public DocumentService(IRepository<Document> documentRepository,
                               IRepository<GenericAttribute> genericAttributeRepository,
                               IRepository<DocumentFooter> documentFooterRepository,
                               IRepository<DocumentCustomer> documentCustomerRepository,
                               IRepository<DocumentType> documentTypeRepository,
                               IRepository<Customer> customerRepository)
        {
            _documentRepository = documentRepository;
            _genericAttributeRepository = genericAttributeRepository;
            _documentCustomerRepository = documentCustomerRepository;
            _documentFooterRepository = documentFooterRepository;
            _documentTypeRepository = documentTypeRepository;
            _customerRepository = customerRepository;
        }


        public IEnumerable<CustomerSummary> GetCustomerByKeyword(string keyWord,
                                                                 int pageSize = int.MaxValue)
        {
            List<CustomerSummary> outCustomerSummary = new List<CustomerSummary>();

            var basQuery = from customer in _customerRepository.Table
                           join
                           genericAttribute in _genericAttributeRepository.Table on customer.Id equals genericAttribute.EntityId
                           where genericAttribute.KeyGroup == "Customer" &&
                                 genericAttribute.Key == SystemCustomerAttributeNames.Company &&
                                 genericAttribute.Value.ToLower().Contains(keyWord)
                           orderby genericAttribute.Value
                           select new CustomerSummary
                           {
                               Id = customer.Id,
                               Company = genericAttribute.Value
                           };       

            return basQuery.Take(pageSize);    
        }


        public IEnumerable<DocumentSummary> GetAllDocuments(string company = null, 
                                                            string documentCode = null, 
                                                            int? customerId = null, 
                                                            int? documentTypeId = null, 
                                                            bool? expiring = null, 
                                                            bool? expired = null,
                                                            DateTime? from = null, 
                                                            DateTime? to = null, 
                                                            string state = null,
                                                            int pageIndex = 0, 
                                                            int pageSize = int.MaxValue)
        {
            var query = from doc in _documentRepository.Table
                        join
                        docCust in _documentCustomerRepository.Table on doc.Id equals docCust.Id
                        join
                        docType in _documentTypeRepository.Table on doc.Id equals docType.Id
                        join
                        customer in _genericAttributeRepository.Table on docCust.Customer_Id equals customer.EntityId
                        join
                        docFooter in _documentFooterRepository.Table on doc.Id equals docFooter.Id
                        into tempLeft
                        from docFooterLeft in tempLeft.DefaultIfEmpty(null)
                        where customer.KeyGroup == "Customer" && 
                              customer.Key == SystemCustomerAttributeNames.Company &&
                              docCust.Priority == 1
                        select new DocumentSummary()
                        {
                            Id = doc.Id,
                            CustomerId = docCust.Customer_Id,
                            Number = doc.DocumentNumber,
                            Date = doc.RegistrationDate,
                            EndDateValidity = doc.EndDateValidity,
                            LastEmailDate = doc.LastEmailDate,
                            Company = customer.Value,
                            State = doc.State,
                            TypeId = docType.Id,
                            TypeDescription = docType.Description,
                            TypeCode = docType.Code
                        };

            if (!string.IsNullOrEmpty(company))
                query = query.Where(x => x.Company.ToLower().Contains(company.ToLower()));
            if (!string.IsNullOrEmpty(documentCode))
                query = query.Where(x => x.TypeCode.ToLower().Contains(documentCode.ToLower()));
            if(customerId != null)
                query = query.Where(x => x.CustomerId == customerId);
            if (documentTypeId != null)
                query = query.Where(x => x.TypeId == documentTypeId);
            if (expiring != null)
                query = query.Where(x => x.EndDateValidity.HasValue &&
                                         x.EndDateValidity.Value >= DateTime.Now.AddMonths(-1) &&
                                         x.EndDateValidity.Value <= DateTime.Now);
            if (expired != null)
                query = query.Where(x => x.EndDateValidity.HasValue &&
                                         x.EndDateValidity.Value >= DateTime.Now);
            if (from != null)
                query = query.Where(x => x.Date >= from);
            if (to != null)
                query = query.Where(x => x.Date <= to);
            if (!string.IsNullOrEmpty(state))
                query = query.Where(x => x.State.ToLower().Equals(state.ToLower()));

            query = query.OrderByDescending(x => x.Date);           

            var customers = new PagedList<DocumentSummary>(query, pageIndex, pageSize);

            return customers.Distinct();
        }       
    }
}
