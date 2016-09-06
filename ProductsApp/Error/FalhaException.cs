using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrefeituraApp.Error
{
    public class FalhaException : System.Exception
    {
        public int Codigo { get; set; }
        override
        public string Message { get; }

        public FalhaException()
        {
        }

        public FalhaException(int codigo, string message)
        {
            this.Codigo = codigo;
            Message = message;
        }
    }
}