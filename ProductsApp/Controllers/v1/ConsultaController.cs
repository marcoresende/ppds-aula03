using PrefeituraApp.Dto;
using PrefeituraApp.Error;
using PrefeituraApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace PrefeituraApp.Controllers.v1
{
    [RoutePrefix("api/{folder}/{controller}")]
    public class ConsultaController : ApiController
    {
        Imovel[] imoveis = new Imovel[]
        {
            new Imovel { Id = 1, Logradouro = "Rua a", Categoria = "residencial", Iptu = 119.90M },
            new Imovel { Id = 2, Logradouro = "Rua b", Categoria = "residencial", Iptu = 339.75M },
            new Imovel { Id = 3, Logradouro = "Rua c", Categoria = "comercial", Iptu = 216.99M },
            new Imovel { Id = 4, Logradouro = "Rua d", Categoria = "residencial", Iptu = 216.99M },
            new Imovel { Id = 5, Logradouro = "Rua e", Categoria = "comercial", Iptu = 216.99M }
        };

        [HttpGet]
        [Route("iptu/{id}")]
        public IHttpActionResult GetImovel(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest();
                }
                var imovel = imoveis.FirstOrDefault((i) => i.Id == id);
                if (imovel == null)
                {
                    return NotFound();
                }
                return Ok(imovel);
            }
            catch (Exception)
            {
                return InternalServerError(new FalhaException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

        [HttpGet]
        [Route("coleta/{logradouro}")]
        public IHttpActionResult GetColeta(String logradouro)
        {
            try
            {
                logradouro = logradouro.ToLower().Replace("rua", "");
                if(logradouro.Substring(0, 1).CompareTo("m") == 1)
                {

                }
                if (logradouro == null || "".Equals(logradouro))
                {
                    return BadRequest("Parâmetros incorretos");
                }
                try
                {
                    logradouro = logradouro.ToLower().Replace("rua", "").Replace("avenida", "");

                    if (logradouro.ToLower().Trim().Substring(0, 1).CompareTo("m") == 1)
                    {
                        return Ok("Dias de coleta: Segunda-feira, Quarta-feira, Sexta-feira");
                    }
                    else
                    {
                        return Ok("Dias de coleta: Terça-feira, Quinta-feira, Sábado");
                    }
                }
                catch (NullReferenceException ne)
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }
            }
            catch (Exception)
            {
                return InternalServerError(new FalhaException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }
    }
}