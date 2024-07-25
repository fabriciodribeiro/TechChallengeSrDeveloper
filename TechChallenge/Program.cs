using TechChallenge.Entities;
using TechChallenge.Sevices;

namespace TechChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HACK: This is our IoC
            var myContext = new DbContextService();
            var hpptContextService = new HpptContextService();
            var myExternalServiceContext = new SecurityPriceExternalService(hpptContextService);

            var securityService = new SecurityService(myContext,
                myExternalServiceContext);
            
            //This list is the input. Could be passed to the class by argument
            List<Security> listIsin = new List<Security>();

            //Initializing the list with values
            listIsin.Add(new Security { ISIN = "123ABC456EDC" });
            listIsin.Add(new Security { ISIN = "123ABC45RTY" });

            //Get price for ISIN
            securityService.GetPrice(listIsin);
            //Save on DB (Stub)
            securityService.Save(listIsin);

            //Just print the values
            var listRetriedFromDb = securityService.Retrieve();
            foreach(var item in listRetriedFromDb)
            {
                Console.WriteLine($"List ISIN Code: { item.ISIN } and price {item.Price}");
            }
        }
    }
}