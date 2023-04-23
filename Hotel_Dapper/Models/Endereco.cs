using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class Endereco
    {
        public static readonly string GETALL = "SELECT Id, Logradouro, Numero, Bairro, CEP, Complemento, IdCidade, DataCadastro FROM Endereco";
        public static readonly string INSERT = "INSERT INTO Endereco (Logradouro, Numero, Bairro, CEP, Complemento, IdCidade, DataCadastro)" +
            "VALUES (@Logradouro, @Numero, @Bairro, @CEP, @Complemento, @IdCidade, @DataCadastro)";

        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public Cidade Cidade { get; set; }
        public DateTime DataCadastro { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + "\nLogradouro: " + Logradouro + "\nNumero: " + Numero +
                "\nBairro: " + Bairro + "\nCEP: " + CEP + "\nComplemento: " + Complemento + "\nCidade: " + Cidade + "\nData de cadastro: " + DataCadastro;
        }

    }
}
