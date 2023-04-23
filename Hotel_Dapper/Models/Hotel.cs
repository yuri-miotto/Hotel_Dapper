using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class Hotel
    {
        public static readonly string GETALL = "SELECT Id, Nome, IdEndereco, DataCadastro, Valor FROM Hotel1";
        public static readonly string INSERT = "INSERT INTO Hotel1 (Nome, IdEndereco, DataCadastro, Valor)" +
            "VALUES (@Nome, @IdEndereco, @DataCadastro, @Valor)";

        public int Id { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal Valor { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + "\nNome: " + Nome + "\nEndereço: " + Endereco +
                "\nData de cadastro: " + DataCadastro + "\nValor: " + Valor;
        }

    }
}
