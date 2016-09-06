using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrefeituraApp.Models
{
    public class PedidoAdocao
    {
        public int Pedido { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public string Status { get; set; }
    }
}