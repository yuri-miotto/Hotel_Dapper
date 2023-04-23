using API.Models;
using API.Repositories;

namespace API.Services
{
    public class HotelService
    {
        private IHotelRepository _hotelRepository;

        public HotelService()
        {
            _hotelRepository = new HotelRepository();
        }

        public bool Insert(Hotel hotel)
        {
            return _hotelRepository.Insert(hotel);
        }

        public List<Hotel> GetAll()
        {
            return _hotelRepository.GetAll();
        }
    }
}
