
using API.Models;
using Dapper;
using System.Data.SqlClient;

namespace API.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private string _conn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\Desktop\projetos\Hotel_Dapper\BancoDeDados\hotel.mdf";


        public List<Endereco> GetAll()
        {
            List<Endereco> list = new();
            using (var db = new SqlConnection(_conn))
            {
                var enderecos = db.Query<Endereco>(Endereco.GETALL);
                list = (List<Endereco>)enderecos;
            }
            return list;
        }

        public bool Insert(Endereco endereco)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Execute(Endereco.INSERT, endereco);
            }
            return true;
        }
    }
}
