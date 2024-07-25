using TechChallenge.Entities;

namespace TechChallenge.Sevices
{
    /// <summary>
    /// This class was create do allow us to represent the AppContext
    /// </summary>
    public class DbContextService
    {
        private List<Security> _myDBStub;

        public DbContextService()
        {
            _myDBStub = new List<Security>();
        }

        public void SaveContext(List<Security> itensToSave)
        {
            _myDBStub.AddRange(itensToSave);
        }

        public List<Security> GetDataOnDB()
        {
            return _myDBStub;
        }
    }
}