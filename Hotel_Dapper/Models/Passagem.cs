using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class Passagem
    {
        public static readonly string GETALL = "SELECT Id, IdOrigem, IdDestino, IdCliente, Data, Valor FROM Passagem";
        public static readonly string INSERT = "INSERT INTO Passagem (IdOrigem, IdDestino, IdCliente, Data, Valor)" +
            "VALUES (@IdOrigem, @IdDestino, @IdCliente, @Data, @Valor)";

        public int Id { get; set; }
        public Endereco Origem { get; set; }
        public Endereco Destino { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + "\nOrigem: " + Origem + "\nDestino: " + Destino +
                "\nCliente: " + Cliente + "\nData: " + Data + "\nValor: " + Valor;
        }
    }
}
