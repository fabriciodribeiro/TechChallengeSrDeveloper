using TechChallenge.Entities;

namespace TechChallenge.Interfaces
{
    public interface ISecurityService
    {
        /// <summary>
        /// Save a list of ISIN on Database
        /// </summary>
        /// <param name="securities"></param>
        /// <returns></returns>
        bool Save(List<Security> securities);

        /// <summary>
        /// Retrieve a list of ISIN from DB
        /// </summary>
        /// <returns></returns>
        List<Security> Retrieve();

        /// <summary>
        /// Get throught external service a list of ISIN prices
        /// </summary>
        /// <param name="securities"></param>
        void GetPrice(List<Security> securities);
    }
}