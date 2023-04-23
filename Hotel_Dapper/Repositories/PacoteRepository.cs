using API.Models;
using Dapper;
using System.Data.SqlClient;

namespace API.Repositories
{
    public class PacoteRepository : IPacoteRepository
    {
        private string _conn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\Desktop\projetos\Hotel_Dapper\BancoDeDados\hotel.mdf";

        public List<Pacote> GetAll()
        {
            List<Pacote> list = new();
            using (var db = new SqlConnection(_conn))
            {
                var pacotes = db.Query<Pacote>(Pacote.GETALL);
                list = (List<Pacote>)pacotes;
            }
            return list;
        }

        public bool Insert(Pacote pacote)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Execute(Pacote.INSERT, pacote);
            }
            return true;
        }
    }
}
