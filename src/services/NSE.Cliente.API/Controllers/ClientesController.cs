using Microsoft.AspNetCore.Mvc;
using NSE.Clientes.API.Application.Commands;
using NSE.Core.MediatR;
using NSE.WebApi.Core.Controllers;
using System.Threading.Tasks;
using System;

namespace NSE.Clientes.API.Controllers
{
    public class ClientesController : MainController
    {
        private readonly IMediatRHandler _mediatorHandler;

        public ClientesController(IMediatRHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        [HttpGet("clientes")]
        public async Task<IActionResult> Index()
        {
            var resultado = await _mediatorHandler.EnviarComando(
                new RegistrarClienteCommand(Guid.NewGuid(), "Felipe", "felipebazz@teste.com", "49682332052"));

            return CustomResponse(resultado);
        }
    }
}
