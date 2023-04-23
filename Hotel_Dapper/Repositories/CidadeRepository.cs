using Dapper;
using System.Data.SqlClient;
using API.Models;

namespace API.Repositories
{
    public class CidadeRepository : ICidadeRepository
    {
        private string _conn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\Desktop\projetos\Hotel_Dapper\BancoDeDados\hotel.mdf";

        public List<Cidade> GetAll()
        {
            List<Cidade> list = new();
            using (var db = new SqlConnection(_conn))
            {
                var cidades = db.Query<Cidade>(Cidade.GETALL);
                list = (List<Cidade>)cidades;
            }
            return list;
        }

        public bool Insert(Cidade cidade)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Execute(Cidade.INSERT, cidade);
            }
            return true;
        }

        public Cidade GetById(int id)
        {
            using (var db = new SqlConnection(_conn))
            {
                var cidades = db.Query<Cidade>(Cidade.GETBYID, id);
                var cidade = (List<Cidade>)cidades;
                return (Cidade)cidade[0];    
            }
        }
    }
}
