using Nop.Plugin.Misc.WarehouseManagement.Data;
using Nop.Plugin.Misc.WarehouseManagement.Domain;
using NUnit.Framework;
using System.Linq;

namespace Nop.Plugin.Misc.WarehouseManagement.Tests.Data
{
    [TestFixture]
    public class WmDbContext_Tests
    {
        private WmDbContext _dbContext;

        public WmDbContext_Tests()
        {
            _dbContext = new WmDbContext("WmEntity");
        }

        [Test]
        public void Should_Get_AllDocuments()
        {
            var toTest = _dbContext.Set<Document>();
            Assert.IsTrue(toTest.Any());
        }


        [Test]
        public void Should_Get_DocumentChain()
        {
            var toTest = _dbContext.Set<Document>().First(x => x.Id == 10);
            Assert.IsNotNull(toTest);
        }
    }
}
