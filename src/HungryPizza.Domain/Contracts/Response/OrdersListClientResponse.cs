namespace HungryPizza.Domain.Contracts.Response;
public class OrdersListClientResponse
{
    public string? Telefone { get; set; }
    public string? Cliente { get; set; }
    public int NumPedido { get; set; }
    public DateTime? DataHoraPedido { get; set; }
    public decimal ValorPedidoComFrete { get; set; }
    public decimal ValorPedido { get; set; }
    public int QTDPizzas { get; set; }
}

