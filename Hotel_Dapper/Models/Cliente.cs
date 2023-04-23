using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace API.Models
{
    public class Cliente
    {
        public static readonly string GETALL = "SELECT Id, Nome, Telefone, IdEndereco, DataCadastro FROM Cliente";
        public static readonly string INSERT = "INSERT INTO Cliente (Nome, Telefone, IdEndereco, DataCadastro)" +
            "VALUES (@Nome, @Telefone, @IdEndereco, @DataCadastro)";

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataCadastro { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + "\nNome: " + Nome + "\nTelefone: " + Telefone +
                "\nEndereço: " + Endereco + "\nData de cadastro: " + DataCadastro;
        }

    }
}
