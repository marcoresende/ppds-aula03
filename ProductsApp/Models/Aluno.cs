using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Aluno
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Escola { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
    }
}