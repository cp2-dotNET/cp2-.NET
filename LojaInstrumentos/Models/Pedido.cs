namespace LojaInstrumentos.Models;

public class ItemPedido
{
    public ItemPedido(string instrumento, decimal precoUnitario, int quantidade)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(instrumento);
        ArgumentOutOfRangeException.ThrowIfNegative(precoUnitario);
        ArgumentOutOfRangeException.ThrowIfLessThan(quantidade, 1);

        Instrumento = instrumento;
        PrecoUnitario = precoUnitario;
        Quantidade = quantidade;
    }

    public string Instrumento { get; }
    public decimal PrecoUnitario { get; }
    public int Quantidade { get; private set; }
    public decimal Subtotal => PrecoUnitario * Quantidade;

    internal void AumentarQuantidade(int quantidade)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(quantidade, 1);
        Quantidade += quantidade;
    }
}

public class Pedido
{
    private readonly List<ItemPedido> itens = new();

    public string Cliente { get; set; } = string.Empty;
    public DateTime Data { get; set; } = DateTime.Now;

    public IReadOnlyList<ItemPedido> Itens => itens;
    public int QuantidadeTotal => itens.Sum(i => i.Quantidade);
    public decimal Total => itens.Sum(i => i.Subtotal);
    public bool EstaVazio => itens.Count == 0;

    // Se o instrumento já está no pedido, soma a quantidade em vez de duplicar a linha.
    public void AdicionarItem(string instrumento, decimal precoUnitario, int quantidade)
    {
        var existente = itens.FirstOrDefault(i => i.Instrumento == instrumento);

        if (existente is null)
        {
            itens.Add(new ItemPedido(instrumento, precoUnitario, quantidade));
        }
        else
        {
            existente.AumentarQuantidade(quantidade);
        }
    }

    public void RemoverItem(int indice)
    {
        itens.RemoveAt(indice);
    }

    public void Limpar()
    {
        itens.Clear();
        Cliente = string.Empty;
        Data = DateTime.Now;
    }
}
