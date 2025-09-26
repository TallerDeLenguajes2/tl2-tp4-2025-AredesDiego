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

    [HttpPost("AgregarPedido")]
    public IActionResult AgregarPedido([FromBody] Pedido pedido)
    {
        var pedidos = accesoADatosJSONPedido.Cargar("data/pedidos.json");
        pedidos.Add(pedido);
        accesoADatosJSONPedido.Guardar(pedidos, "data/pedidos.json");
        return Ok(pedido);
    }

    //Put

    [HttpPut("AsignarPedido")]
    public IActionResult AsignarPedido(int idPedido, int idCadete)
    {
        return Ok();
    }

    [HttpPut("CambiarEstadoPedido")]
    public IActionResult CambiarEstadoPedido(int idPedido, int idCadete)
    {
        return Ok();
    } 

    [HttpPut("CambiarCadetePedido")]
    public IActionResult CambiarCadetePedido(int idPedido, int idCadete)
    {
       return Ok();
    }

}