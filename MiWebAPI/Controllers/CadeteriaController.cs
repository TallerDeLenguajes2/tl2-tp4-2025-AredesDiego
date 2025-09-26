using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CadeteriaController : ControllerBase
{
    //Get

    [HttpGet("GetPedidos")]
    public List<Pedido> GetPedidos(List<Pedido> pedidos)
    {
        return pedidos;
    }

    [HttpGet("GetCadetes")]
    public List<Cadete> GetCadetes(List<Cadete> cadetes)
    {
        return cadetes;
    }

    [HttpGet("GetInforme")]
    public List<Cadete> GetInforme(List<Cadete> cadetes)
    {
        return cadetes;
    }

    //Post
    [HttpPost("AgregarPedido")]
    public Pedido GetInforme(Pedido pedido)
    {
        return pedido;
    }

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