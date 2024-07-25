using TechChallenge.Interfaces;

namespace TechChallenge.Sevices
{
    public class SecurityPriceExternalService : ISecurityPriceExternalService
    {
        private readonly HpptContextService _httpContext;

        public SecurityPriceExternalService(HpptContextService httpContext)
        {
            _httpContext = httpContext;
        }

        public decimal RetrieveExternalSecurities(string isinCode)
        {
            try
            {
                return _httpContext.Get("https://securities.dataprovider.com/securityprice/{isin}");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
