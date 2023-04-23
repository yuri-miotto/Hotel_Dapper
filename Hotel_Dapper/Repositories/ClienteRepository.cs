using API.Models;
using Dapper;
using System.Data.SqlClient;

namespace API.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private string _conn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\Desktop\projetos\Hotel_Dapper\BancoDeDados\hotel.mdf";


        public List<Cliente> GetAll()
        {
            List<Cliente> list = new();
            using (var db = new SqlConnection(_conn))
            {
                var clientes = db.Query<Cliente>(Cliente.GETALL);
                list = (List<Cliente>)clientes;
            }
            return list;
        }

        public bool Insert(Cliente cliente)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Execute(Cliente.INSERT, cliente);
            }
            return true;
        }
    }
}
