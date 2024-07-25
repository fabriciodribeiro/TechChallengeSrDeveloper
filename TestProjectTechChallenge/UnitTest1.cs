using TechChallenge.Entities;
using TechChallenge.Interfaces;
using TechChallenge.Sevices;

namespace TestProjectTechChallenge
{
    public class Tests
    {

        private DbContextService _myContext;
        private HpptContextService _hpptContextService;
        private SecurityPriceExternalService _myExternalServiceContext;
        private SecurityService _securityService;

        [SetUp]
        public void Setup()
        {
            _myContext = new DbContextService();
            _hpptContextService = new HpptContextService();
            _myExternalServiceContext = new SecurityPriceExternalService(_hpptContextService);

            _securityService = new SecurityService(_myContext, _myExternalServiceContext);
        }

        [Test]
        public void EnsureRetrievePriceForAGivenListIsGreaterThanZero()
        {
            List <Security> listIsin = new List<Security>();
            listIsin.Add(new Security { ISIN = "123ABC45RTY" });

            _securityService.GetPrice(listIsin);

            Assert.Greater(listIsin.First().Price, 0);
        }
    }
}