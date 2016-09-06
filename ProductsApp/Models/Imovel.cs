using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrefeituraApp.Models
{
    public class Imovel
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Categoria { get; set; }
        public decimal Iptu { get; set; }
    }
}