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
    public class PedidoController : ApiController
    {
        static int ultimoId = 0;
        List<PedidoAdocao> pedidos = new List<PedidoAdocao>();

        [HttpPost]
        [Route("adocaocaes")]
        public IHttpActionResult solicitaAdocaoCaes(AdocaoRequest request)
        {
            try
            {
                if (request == null || request.Cpf == null || request.Nome == null || request.Logradouro == null)
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
            catch (Exception)
            {
                return InternalServerError(new FalhaException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

        [HttpPost]
        [Route("adocaogato")]
        public IHttpActionResult solicitaAdocaoGatos(AdocaoRequest request)
        {
            try
            {
                if (request == null || request.Cpf == null || request.Nome == null || request.Logradouro == null)
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
            catch (Exception)
            {
                return InternalServerError(new FalhaException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

    }
}