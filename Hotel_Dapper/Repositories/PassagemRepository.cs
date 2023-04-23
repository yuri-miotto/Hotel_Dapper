using API.Models;
using Dapper;
using System.Data.SqlClient;

namespace API.Repositories
{
    public class PassagemRepository : IPassagemRepository
    {
        private string _conn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\Desktop\projetos\Hotel_Dapper\BancoDeDados\hotel.mdf";

        public List<Passagem> GetAll()
        {
            List<Passagem> list = new();
            using (var db = new SqlConnection(_conn))
            {
                var passagens = db.Query<Passagem>(Passagem.GETALL);
                list = (List<Passagem>)passagens;
            }
            return list;
        }

        public bool Insert(Passagem passagem)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Execute(Passagem.INSERT, passagem);
            }
            return true;
        }
    }
}
