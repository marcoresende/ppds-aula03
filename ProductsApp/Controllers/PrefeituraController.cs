using ProductsApp.Dto;
using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class PrefeituraController : ApiController
    {
        Imovel[] imoveis = new Imovel[] 
        { 
            new Imovel { Id = 1, Logradouro = "Rua a", Categoria = "residencial", Iptu = 119.90M }, 
            new Imovel { Id = 2, Logradouro = "Rua b", Categoria = "residencial", Iptu = 339.75M }, 
            new Imovel { Id = 3, Logradouro = "Rua c", Categoria = "comercial", Iptu = 216.99M },
            new Imovel { Id = 4, Logradouro = "Rua d", Categoria = "residencial", Iptu = 216.99M },
            new Imovel { Id = 5, Logradouro = "Rua e", Categoria = "comercial", Iptu = 216.99M }
        };

        static int ultimoId = 0;
        List<Solicitacao> solicitacoes = new List<Solicitacao>();
        List<PedidoAdocao> pedidos = new List<PedidoAdocao>();

        [HttpGet]
        [Route("api/{controller}/consulta/iptu/{id}")]
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
            }catch(Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpGet]
        [Route("api/{controller}/consulta/coleta/{logradouro}")]
        public IHttpActionResult GetColeta(String logradouro)
        {
            try
            {
                if (logradouro == null || "".Equals(logradouro))
                {
                    return BadRequest();
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
                    return BadRequest("Parâmetro \"logradouro\" inválido!");
                }
            }catch(Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPost]
        [Route("api/{controller}/solicitacao/poda")]
        public IHttpActionResult solicitaPoda(SolicitacaoRequest request)
        {
            try
            {
                if (request == null || request.Logradouro == null || "".Equals(request.Logradouro))
                {
                    return BadRequest("Parâmetro \"logradouro\" inválido!");
                }
                Solicitacao solicitacao = new Solicitacao();

                solicitacao.Solicitao = ++ultimoId;
                solicitacao.Logradouro = request.Logradouro;
                solicitacao.Status = "Aguardando Atendimento";
                solicitacao.Tipo = TipoSolicitacao.PodaArvore;

                solicitacoes.Add(solicitacao);

                return Ok(solicitacao);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPost]
        [Route("api/{controller}/solicitacao/meiofio")]
        public IHttpActionResult solicitaMeioFio(SolicitacaoRequest request)
        {
            try
            {
                if (request == null || request.Logradouro == null || "".Equals(request.Logradouro))
                {
                    return BadRequest("Parâmetro \"logradouro\" inválido!");
                }
                Solicitacao solicitacao = new Solicitacao();
                
                solicitacao.Solicitao = ++ultimoId;
                solicitacao.Logradouro = request.Logradouro;
                solicitacao.Status = "Aguardando Atendimento";
                solicitacao.Tipo = TipoSolicitacao.MeioFio;

                solicitacoes.Add(solicitacao);

                return Ok(solicitacao);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPost]
        [Route("api/{controller}/solicitacao/recolhimentocarro")]
        public IHttpActionResult solicitaRecolhimenoCarro(SolicitacaoRequest request)
        {
            try
            {
                if (request == null || request.Logradouro == null || "".Equals(request.Logradouro))
                {
                    return BadRequest("Parâmetro \"logradouro\" inválido!");
                }
                Solicitacao solicitacao = new Solicitacao();

                solicitacao.Solicitao = ++ultimoId;
                solicitacao.Logradouro = request.Logradouro;
                solicitacao.Status = "Aguardando Atendimento";
                solicitacao.Tipo = TipoSolicitacao.MeioFio;

                solicitacoes.Add(solicitacao);

                return Ok(solicitacao);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPost]
        [Route("api/{controller}/solicitacao/desobstrucaovia")]
        public IHttpActionResult solicitaDesobstrucaoVia(SolicitacaoRequest request)
        {
            try
            {
                if (request == null || request.Logradouro == null || "".Equals(request.Logradouro))
                {
                    return BadRequest("Parâmetro \"logradouro\" inválido!");
                }
                Solicitacao solicitacao = new Solicitacao();

                solicitacao.Solicitao = ++ultimoId;
                solicitacao.Logradouro = request.Logradouro;
                solicitacao.Status = "Aguardando Atendimento";
                solicitacao.Tipo = TipoSolicitacao.DesobstrucaoViaPublica;

                solicitacoes.Add(solicitacao);

                return Ok(solicitacao);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPost]
        [Route("api/{controller}/solicitacao/desobstrucaocorrego")]
        public IHttpActionResult solicitaDesobstrucaoCorrego(SolicitacaoRequest request)
        {
            try
            {
                if (request == null || request.Logradouro == null || "".Equals(request.Logradouro))
                {
                    return BadRequest("Parâmetro \"logradouro\" inválido!");
                }
                Solicitacao solicitacao = new Solicitacao();

                solicitacao.Solicitao = ++ultimoId;
                solicitacao.Logradouro = request.Logradouro;
                solicitacao.Status = "Aguardando Atendimento";
                solicitacao.Tipo = TipoSolicitacao.DesobstrucaoCorrego;

                solicitacoes.Add(solicitacao);

                return Ok(solicitacao);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPost]
        [Route("api/{controller}/solicitacao/coletaanimal")]
        public IHttpActionResult solicitaColetaAnimal(SolicitacaoRequest request)
        {
            try
            {
                if (request == null || request.Logradouro == null || "".Equals(request.Logradouro))
                {
                    return BadRequest("Parâmetro \"logradouro\" inválido!");
                }
                Solicitacao solicitacao = new Solicitacao();

                solicitacao.Solicitao = ++ultimoId;
                solicitacao.Logradouro = request.Logradouro;
                solicitacao.Status = "Aguardando Atendimento";
                solicitacao.Tipo = TipoSolicitacao.ColetaAnimal;

                solicitacoes.Add(solicitacao);

                return Ok(solicitacao);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPost]
        [Route("api/{controller}/solicitacao/limpezabocalobo")]
        public IHttpActionResult solicitaLimpezaBocaLobo(SolicitacaoRequest request)
        {
            try
            {
                if (request == null || request.Logradouro == null || "".Equals(request.Logradouro))
                {
                    return BadRequest("Parâmetro \"logradouro\" inválido!");
                }
                Solicitacao solicitacao = new Solicitacao();

                solicitacao.Solicitao = ++ultimoId;
                solicitacao.Logradouro = request.Logradouro;
                solicitacao.Status = "Aguardando Atendimento";
                solicitacao.Tipo = TipoSolicitacao.LimpezaBocaLobo;

                solicitacoes.Add(solicitacao);

                return Ok(solicitacao);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPost]
        [Route("api/{controller}/solicitacao/adocao")]
        public IHttpActionResult solicitaAdocaoCaes(AdocaoCaoRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Parâmetros inválidos!");
                }
                PedidoAdocao pedido = new PedidoAdocao();
                pedido.Pedido = ++ultimoId;
                pedido.Cpf = request.Cpf;
                pedido.Nome = request.Nome;
                pedido.Logradouro = request.Logradouro;
                pedido.Status = "Aguardando Atendimento";

                pedidos.Add(pedido);

                return Ok(pedido);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

    }
}
