using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public enum TipoSolicitacao
    {
        PodaArvore,
        MeioFio,
        RecolhimentoCarro,
        DesobstrucaoViaPublica,
        DesobstrucaoCorrego,
        ColetaAnimal,
        LimpezaBocaLobo
    }

    public class Solicitacao
    {
        public int Solicitao { get; set; }
        public string Status { get; set; }
        public TipoSolicitacao Tipo;
        public string Logradouro { get; set; }
    }
}