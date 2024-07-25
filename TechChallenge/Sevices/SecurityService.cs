using TechChallenge.Entities;
using TechChallenge.Interfaces;

namespace TechChallenge.Sevices
{
    public class SecurityService : ISecurityService
    {
        private readonly DbContextService _dbContextService;
        private readonly SecurityPriceExternalService _securityPriceExternalService;

        public SecurityService(DbContextService dbContextService,
            SecurityPriceExternalService securityPriceExternalService)
        {
            _dbContextService = dbContextService;
            _securityPriceExternalService = securityPriceExternalService;
        }


        public bool Save(List<Security> securities)
        {
            _dbContextService.SaveContext(securities);

            return true;
        }
        public List<Security> Retrieve()
        {
            return _dbContextService.GetDataOnDB();
        }


        public void GetPrice(List<Security> securities)
        {
            foreach(var item in securities)
            {
                item.Price = _securityPriceExternalService.RetrieveExternalSecurities(item.ISIN);
            }
        }
    }
}
