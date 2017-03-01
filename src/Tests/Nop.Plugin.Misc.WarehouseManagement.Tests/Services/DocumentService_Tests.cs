using Nop.Data;
using Nop.Plugin.Misc.WarehouseManagement.Data;
using Nop.Plugin.Misc.WarehouseManagement.Domain;
using Nop.Plugin.Misc.WarehouseManagement.Services;
using NUnit.Framework;

namespace Nop.Plugin.Misc.WarehouseManagement.Tests.Services
{
    [TestFixture]
    public class DocumentService_Tests
    {
        public IDocumentService _sut;

        [SetUp]
        public void Run()
        {
            var contetx = new WmDbContext("name = WmEntity");

            var iDocRepository = new EfRepository<Document>(contetx);
            var iGenericAttributeRepository = new EfRepository<GenericAttribute>(contetx);
            var iDocumentCustomerRepository = new EfRepository<DocumentCustomer>(contetx);
            var iDocumentTypeRepository = new EfRepository<DocumentType>(contetx);
            var iDocumentFooterRepository = new EfRepository<DocumentFooter>(contetx);
            var iCustomerRepository = new EfRepository<Customer>(contetx);
            var iCustomerRoleRepository = new EfRepository<CustomerRole>(contetx);

            _sut = new DocumentService(iDocRepository, 
                                       iGenericAttributeRepository, 
                                       iDocumentFooterRepository,
                                       iDocumentCustomerRepository,
                                       iDocumentTypeRepository,
                                       iCustomerRepository,
                                       iCustomerRoleRepository);
        }

        [Test]
        public void Should_Get_All_Documents_Of_Specified_Customer()
        {
            var expectedDocuments = _sut.GetAllDocuments();
            Assert.IsNotNull(expectedDocuments);
        }

        [Test]
        public void Should_Get_Customers_By_Search_Key()
        {
            var expectedDocuments = _sut.GetCustomerByKeyword("Cesare");
            Assert.IsNotNull(expectedDocuments);
        }

        [Test]
        public void Should_Get_All_Document_Types()
        {
            var expectedDocuments = _sut.GetAllDocumentTypes;
            Assert.IsNotNull(expectedDocuments);
        }
    }
}
