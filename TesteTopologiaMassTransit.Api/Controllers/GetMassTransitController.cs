using MassTransit;
using Microsoft.AspNetCore.Mvc;
using TesteTopologiaMassTransit.Api.Models;

namespace TesteTopologiaMassTransit.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class GetMassTransitController : ControllerBase
    {
        private ISendEndpointProvider _sendEndpointProvider;
        public GetMassTransitController(ISendEndpointProvider sendEndpointProvider)
        {
            _sendEndpointProvider = sendEndpointProvider;
        }
        [HttpPost]
        public async Task<ActionResult<object>> PostGenericoDoTestao(TesteModel vo)
        {
            var endpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri("queue:wellingtontest-queue"));
            var retorno = endpoint.Send(vo);
            return Ok(vo);
        }
    }
}