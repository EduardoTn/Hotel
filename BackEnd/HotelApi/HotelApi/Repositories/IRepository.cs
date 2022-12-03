using HotelApi.Model;

namespace HotelApi.Repositories
{
    public interface IRepository<T>
    {
        public bool Create(object obj);
        public bool Delete(long id);
        public object GetIdObject(long id);
        public IEnumerable<object> GetAll();
    }
}
