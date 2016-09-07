using PrefeituraApp.Dto;
using PrefeituraApp.Error;
using PrefeituraApp.Models;
using ProductsApp.Models;
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

        [HttpGet]
        [Route("historicoaluno/{id}")]
        public IHttpActionResult GetHistorico(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest();
                }
                var aluno = alunos.FirstOrDefault((i) => i.Codigo == id);
                if (aluno == null)
                {
                    return NotFound();
                }
                return Ok(aluno);
            }
            catch (Exception)
            {
                return InternalServerError(new FalhaException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

        Imovel[] imoveis = new Imovel[]
        {
            new Imovel { Id = 1, Logradouro = "Rua a", Categoria = "residencial", Iptu = 119.90M },
            new Imovel { Id = 2, Logradouro = "Rua b", Categoria = "residencial", Iptu = 339.75M },
            new Imovel { Id = 3, Logradouro = "Rua c", Categoria = "comercial", Iptu = 216.99M },
            new Imovel { Id = 4, Logradouro = "Rua d", Categoria = "residencial", Iptu = 216.99M },
            new Imovel { Id = 5, Logradouro = "Rua e", Categoria = "comercial", Iptu = 216.99M }
        };

        Aluno[] alunos = new Aluno[]
        {
            new Aluno
            { Codigo = 1, Nome = "José", Escola = "Escola 1",
                Disciplinas = new List<Disciplina>()
                {
                    new Disciplina {Nome = "Matemática", Nota = 66.5F, Faltas = 2 },
                    new Disciplina {Nome = "Português", Nota = 88.0F, Faltas = 0 },
                    new Disciplina {Nome = "História", Nota = 75F, Faltas = 4 }
                }
            },
            new Aluno
            { Codigo = 2, Nome = "Maria", Escola = "Escola 1",
                Disciplinas = new List<Disciplina>()
                {
                    new Disciplina {Nome = "Matemática", Nota = 56F, Faltas = 5 },
                    new Disciplina {Nome = "Português", Nota = 78.9F, Faltas = 2 },
                    new Disciplina {Nome = "História", Nota = 91F, Faltas = 0 }
                }
            },
            new Aluno
            { Codigo = 3, Nome = "João", Escola = "Escola 2",
                Disciplinas = new List<Disciplina>()
                {
                    new Disciplina {Nome = "Matemática", Nota = 68.5F, Faltas = 2 },
                    new Disciplina {Nome = "Português", Nota = 81.0F, Faltas = 1 },
                    new Disciplina {Nome = "História", Nota = 72F, Faltas = 3 }
                }
            },
            new Aluno
            { Codigo = 4, Nome = "Pedro", Escola = "Escola 3",
                Disciplinas = new List<Disciplina>()
                {
                    new Disciplina {Nome = "Matemática", Nota = 90.5F, Faltas = 0 },
                    new Disciplina {Nome = "Português", Nota = 88.0F, Faltas = 1 },
                    new Disciplina {Nome = "História", Nota = 93F, Faltas = 0 }
                }
            },
            new Aluno
            { Codigo = 5, Nome = "Felipe", Escola = "Escola 4",
                Disciplinas = new List<Disciplina>()
                {
                    new Disciplina {Nome = "Matemática", Nota = 40.5F, Faltas = 8 },
                    new Disciplina {Nome = "Português", Nota = 55.0F, Faltas = 5 },
                    new Disciplina {Nome = "História", Nota = 61F, Faltas = 4 }
                }
            }
        };
    }
}