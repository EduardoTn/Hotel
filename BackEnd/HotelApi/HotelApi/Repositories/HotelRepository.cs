using HotelApi.Data;
using HotelApi.Model;

namespace HotelApi.Repositories
{
    public class HotelRepository : IRepository<HotelPessoaJuridica>
    {
        private readonly ConnectionDbContext _context;

        public HotelRepository(ConnectionDbContext context)
        {
            _context = context;
        }

        public bool Create(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            _context.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(long id)
        {
            HotelPessoaJuridica hotelPessoaJuridica = _context.HotelPessoaJuridica.FirstOrDefault(x => x.Id == id);

            if(hotelPessoaJuridica == null)
            {
                return false;
            }

            _context.Remove(hotelPessoaJuridica);
            _context.SaveChanges();
            return true;
        }

        public object GetIdObject(long id)
        {
            HotelPessoaJuridica hotelPessoaJuridica = _context.HotelPessoaJuridica.FirstOrDefault(x => x.Id == id);

            return hotelPessoaJuridica;
        }

        public IEnumerable<object> GetAll()
        {
            return _context.HotelPessoaJuridica;
        }
    }
 }
