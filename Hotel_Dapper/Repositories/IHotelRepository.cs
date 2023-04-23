using API.Models;
using Dapper;
using System.Data.SqlClient;


namespace API.Repositories
{
    public interface IHotelRepository
    {
        bool Insert(Hotel hotel);

        List<Hotel> GetAll();
    }
}
