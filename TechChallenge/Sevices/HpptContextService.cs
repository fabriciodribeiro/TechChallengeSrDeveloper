namespace TechChallenge.Sevices
{
    public class HpptContextService
    {
        //HACK: To simulate HttpContext class and method - GET
        public decimal Get(string address)
        {
            Random rnd = new Random();

            return rnd.Next(1000);
        }
    }
}
