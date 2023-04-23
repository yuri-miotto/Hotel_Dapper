using Dapper;
using System.Data.SqlClient;
using API.Models;

namespace API.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private string _conn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\Desktop\projetos\Hotel_Dapper\BancoDeDados\hotel.mdf";

        public List<Hotel> GetAll()
        {
            List<Hotel> list = new();
            using (var db = new SqlConnection(_conn))
            {
                var hoteis = db.Query<Hotel>(Hotel.GETALL);
                list = (List<Hotel>)hoteis;
            }
            return list;
        }

        public bool Insert(Hotel hotel)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Execute(Hotel.INSERT, hotel);
            }
            return true;
        }
    }
}
