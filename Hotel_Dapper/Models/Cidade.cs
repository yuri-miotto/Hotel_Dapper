using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class Cidade
    {
        public static readonly string GETALL = "SELECT Id, Descricao, DataCadastro FROM Cidade";
        public static readonly string GETBYID = "SELECT Id, Descricao, DataCadastro FROM Cidade where Id = @Id";
        public static readonly string INSERT = "INSERT INTO Cidade (Descricao, DataCadastro) VALUES (@Descricao, @DataCadastro)";

        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + "\nDescrição: " + Descricao + "\nData de cadastro: " + DataCadastro;
        }

    }
}
