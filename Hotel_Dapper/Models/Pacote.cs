using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class Pacote
    {
        public static readonly string GETALL = "SELECT Id, IdHotel, IdPassagem, DataCadastro, Valor, IdCliente FROM Pacote";
        public static readonly string INSERT = "INSERT INTO Pacote (IdHotel, IdPassagem, DataCadastro, Valor, IdCliente)" +
            "VALUES (@IdHotel, @IdPassagem, @DataCadastro, @Valor, @IdCliente)";

        public int Id { get; set; }
        public Hotel Hotel { get; set; }
        public Passagem Passagem { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal Valor { get; set; }
        public Cliente Cliente { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + "\nHotel: " + Hotel + "\nPassagem: " + Passagem +
                "\nData de cadastro: " + DataCadastro + "\nValor: " + Valor + "\nCliente: " + Cliente;
        }

    }
}
