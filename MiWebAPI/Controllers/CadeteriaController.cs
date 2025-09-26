using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CadeteriaController : ControllerBase
{
    private readonly AccesoADatosJSON<Cadete> accesoADatosJSONCadete;
    private readonly AccesoADatosJSON<Pedido> accesoADatosJSONPedido;
    public CadeteriaController()
    {
        accesoADatosJSONCadete = new AccesoADatosJSON<Cadete>();
        accesoADatosJSONPedido = new AccesoADatosJSON<Pedido>();
    }

    //Get
    [HttpGet("GetPedidos")]
    public List<Pedido> GetPedidos()
    {
        return accesoADatosJSONPedido.Cargar("data/pedidos.json");
    }

    [HttpGet("GetCadetes")]
    public List<Cadete> GetCadetes()
    {
        return accesoADatosJSONCadete.Cargar("data/cadetes.json");
    }

    [HttpGet("GetInforme")]
    public IActionResult GetInforme()
    {
        var cadetes = accesoADatosJSONCadete.Cargar("data/cadetes.json");
        var pedidos = accesoADatosJSONPedido.Cargar("data/pedidos.json");

        var informe = new
        {
            TotalCadetes = cadetes.Count,
            TotalPedidos = pedidos.Count,
            Cadetes = cadetes
        };

        return Ok(informe);
    }
    //Post
    

/*     //Put
            [HttpPut("AsignarPedido")]
            public Pedido AgregarPedido(int idPedido, int idCadete)
            {
            }

            [HttpPut("CambiarEstadoPedido")]
            public Pedido CambiarEstadoPedido(int idPedido, int idCadete)
            {

            } */

    [HttpPut("CambiarCadetePedido")]
    public Pedido CambiarCadetePedido(int idPedido, int idCadete)
    {
        Pedido pedido = new Pedido();
        return pedido;
    }

}