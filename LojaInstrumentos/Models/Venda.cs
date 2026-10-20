using System.Globalization;

namespace LojaInstrumentos.Models;

public class Venda
{
    private static readonly CultureInfo CulturaBr = new("pt-BR");

    public Venda(int numeroPedido, DateTime data, string cliente, string instrumento, string categoria, int quantidade, decimal valorUnitario)
    {
        NumeroPedido = numeroPedido;
        Data = data;
        Cliente = cliente;
        Instrumento = instrumento;
        Categoria = categoria;
        Quantidade = quantidade;
        ValorUnitario = valorUnitario;
    }

    public int NumeroPedido { get; }
    public DateTime Data { get; }
    public string Cliente { get; }
    public string Instrumento { get; }
    public string Categoria { get; }
    public int Quantidade { get; }
    public decimal ValorUnitario { get; }

    public decimal Total => Quantidade * ValorUnitario;

    public string Detalhes =>
        $"Pedido: {NumeroPedido}\n" +
        $"Data: {Data:dd/MM/yyyy}\n" +
        $"Cliente: {Cliente}\n" +
        $"Instrumento: {Instrumento}\n" +
        $"Categoria: {Categoria}\n" +
        $"Quantidade: {Quantidade}\n" +
        $"Valor unitário: {ValorUnitario.ToString("C2", CulturaBr)}\n" +
        $"Total: {Total.ToString("C2", CulturaBr)}";
}
