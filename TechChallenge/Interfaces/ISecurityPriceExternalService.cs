namespace TechChallenge.Interfaces
{
    public interface ISecurityPriceExternalService
    {
        decimal RetrieveExternalSecurities(string isinCode);
    }
}