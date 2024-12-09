public class Pedido
{
    public int Id { get; set; }
    public DateTime DataPedido { get; set; }
    public decimal Total { get; set; }
    public string Status { get; set; }
    public ICollection<ItemCarrinho> Itens { get; set; }
}
