using HotelApi.Data;
using HotelApi.Model;

namespace HotelApi.Repositories
{
    public class QuartoRepository : IRepository<Quarto>
    {
        private readonly ConnectionDbContext _quartoContext;

        public QuartoRepository(ConnectionDbContext quartoContext)
        {
            _quartoContext = quartoContext;
        }

        public bool Create(object obj)
        {
            if(obj == null) return false;
            _quartoContext.Add(obj);
            _quartoContext.SaveChanges();
            return true;
        }

        public bool Delete(long id)
        {
            Quarto quartoDelete = _quartoContext.Quarto.FirstOrDefault(x => x.Id == id);

            if(quartoDelete == null)
            {
                return false;
            }

            _quartoContext.Quarto.Remove(quartoDelete);
            _quartoContext.SaveChanges();
            return true;
        }

        public IEnumerable<object> GetAll()
        {
            return _quartoContext.Quarto;
        }

        public object GetIdObject(long id)
        {
            Quarto quarto = _quartoContext.Quarto.FirstOrDefault(x => x.Id == id);

            return quarto;
        }
    }
}
