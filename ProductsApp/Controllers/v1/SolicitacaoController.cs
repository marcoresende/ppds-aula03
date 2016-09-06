using PrefeituraApp.Dto;
using PrefeituraApp.Error;
using PrefeituraApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PrefeituraApp.Controllers.v1
{
    [RoutePrefix("api/{folder}/{controller}")]
    public class SolicitacaoController : ApiController
    {
        static int ultimoId = 0;
        List<Solicitacao> solicitacoes = new List<Solicitacao>();

        [HttpPost]
        [Route("poda")]
        public IHttpActionResult solicitaPoda(SolicitacaoRequest request)
        {
            try
            {
                if (request == null || request.Logradouro == null || "".Equals(request.Logradouro))
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }
                Solicitacao solicitacao = new Solicitacao();

                solicitacao.Solicitao = ++ultimoId;
                solicitacao.Logradouro = request.Logradouro;
                solicitacao.Status = "Aguardando Atendimento";
                solicitacao.Tipo = TipoSolicitacao.PodaArvore;

                solicitacoes.Add(solicitacao);

                return Ok(solicitacao);
            }
            catch (Exception)
            {
                return InternalServerError(new FalhaException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

        [HttpPost]
        [Route("meiofio")]
        public IHttpActionResult solicitaMeioFio(SolicitacaoRequest request)
        {
            try
            {
                if (request == null || request.Logradouro == null || "".Equals(request.Logradouro))
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }
                Solicitacao solicitacao = new Solicitacao();

                solicitacao.Solicitao = ++ultimoId;
                solicitacao.Logradouro = request.Logradouro;
                solicitacao.Status = "Aguardando Atendimento";
                solicitacao.Tipo = TipoSolicitacao.MeioFio;

                solicitacoes.Add(solicitacao);

                return Ok(solicitacao);
            }
            catch (Exception)
            {
                return InternalServerError(new FalhaException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

        [HttpPost]
        [Route("recolhimentocarro")]
        public IHttpActionResult solicitaRecolhimenoCarro(SolicitacaoRequest request)
        {
            try
            {
                if (request == null || request.Logradouro == null || "".Equals(request.Logradouro))
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }
                Solicitacao solicitacao = new Solicitacao();

                solicitacao.Solicitao = ++ultimoId;
                solicitacao.Logradouro = request.Logradouro;
                solicitacao.Status = "Aguardando Atendimento";
                solicitacao.Tipo = TipoSolicitacao.MeioFio;

                solicitacoes.Add(solicitacao);

                return Ok(solicitacao);
            }
            catch (Exception)
            {
                return InternalServerError(new FalhaException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

        [HttpPost]
        [Route("desobstrucaovia")]
        public IHttpActionResult solicitaDesobstrucaoVia(SolicitacaoRequest request)
        {
            try
            {
                if (request == null || request.Logradouro == null || "".Equals(request.Logradouro))
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }
                Solicitacao solicitacao = new Solicitacao();

                solicitacao.Solicitao = ++ultimoId;
                solicitacao.Logradouro = request.Logradouro;
                solicitacao.Status = "Aguardando Atendimento";
                solicitacao.Tipo = TipoSolicitacao.DesobstrucaoViaPublica;

                solicitacoes.Add(solicitacao);

                return Ok(solicitacao);
            }
            catch (Exception)
            {
                return InternalServerError(new FalhaException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

        [HttpPost]
        [Route("desobstrucaocorrego")]
        public IHttpActionResult solicitaDesobstrucaoCorrego(SolicitacaoRequest request)
        {
            try
            {
                if (request == null || request.Logradouro == null || "".Equals(request.Logradouro))
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }
                Solicitacao solicitacao = new Solicitacao();

                solicitacao.Solicitao = ++ultimoId;
                solicitacao.Logradouro = request.Logradouro;
                solicitacao.Status = "Aguardando Atendimento";
                solicitacao.Tipo = TipoSolicitacao.DesobstrucaoCorrego;

                solicitacoes.Add(solicitacao);

                return Ok(solicitacao);
            }
            catch (Exception)
            {
                return InternalServerError(new FalhaException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

        [HttpPost]
        [Route("coletaanimal")]
        public IHttpActionResult solicitaColetaAnimal(SolicitacaoRequest request)
        {
            try
            {
                if (request == null || request.Logradouro == null || "".Equals(request.Logradouro))
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }
                Solicitacao solicitacao = new Solicitacao();

                solicitacao.Solicitao = ++ultimoId;
                solicitacao.Logradouro = request.Logradouro;
                solicitacao.Status = "Aguardando Atendimento";
                solicitacao.Tipo = TipoSolicitacao.ColetaAnimal;

                solicitacoes.Add(solicitacao);

                return Ok(solicitacao);
            }
            catch (Exception)
            {
                return InternalServerError(new FalhaException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

        [HttpPost]
        [Route("limpezabocalobo")]
        public IHttpActionResult solicitaLimpezaBocaLobo(SolicitacaoRequest request)
        {
            try
            {
                if (request == null || request.Logradouro == null || "".Equals(request.Logradouro))
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }
                Solicitacao solicitacao = new Solicitacao();

                solicitacao.Solicitao = ++ultimoId;
                solicitacao.Logradouro = request.Logradouro;
                solicitacao.Status = "Aguardando Atendimento";
                solicitacao.Tipo = TipoSolicitacao.LimpezaBocaLobo;

                solicitacoes.Add(solicitacao);

                return Ok(solicitacao);
            }
            catch (Exception)
            {
                return InternalServerError(new FalhaException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }
    }
}