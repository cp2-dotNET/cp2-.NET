using System.Globalization;
using System.Windows.Forms;
using LojaInstrumentos.Models;

namespace LojaInstrumentos;

public partial class FormRelatorio : Form
{
    private const string TodasCategorias = "Todas";
    private static readonly CultureInfo CulturaBr = new("pt-BR");

    private readonly List<VendaRelatorio> vendas = new();

    public FormRelatorio()
    {
        InitializeComponent();

        Load += FormRelatorio_Load;
        btnFiltrar.Click += BtnFiltrar_Click;
        btnLimpar.Click += BtnLimpar_Click;
        btnAtualizar.Click += BtnAtualizar_Click;
        btnFechar.Click += BtnFechar_Click;
        dgvVendas.CellDoubleClick += DgvVendas_CellDoubleClick;
    }

    private void FormRelatorio_Load(object? sender, EventArgs e)
    {
        Text = InfoSistema.TituloJanela("Relatório de Vendas");
        colValorUnitario.DefaultCellStyle.FormatProvider = CulturaBr;
        colTotal.DefaultCellStyle.FormatProvider = CulturaBr;

        CarregarVendas();
        LimparFiltros();
        AplicarFiltros();
    }

    private void BtnFiltrar_Click(object? sender, EventArgs e)
    {
        AplicarFiltros();
    }

    private void BtnLimpar_Click(object? sender, EventArgs e)
    {
        LimparFiltros();
        AplicarFiltros();
    }

    private void BtnAtualizar_Click(object? sender, EventArgs e)
    {
        CarregarVendas();
        AplicarFiltros();
        tslStatus.Text = $"Dados atualizados às {DateTime.Now:HH:mm:ss}";
    }

    private void BtnFechar_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void DgvVendas_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgvVendas.Rows[e.RowIndex].Tag is not VendaRelatorio venda)
        {
            return;
        }

        MessageBox.Show(
            $"Pedido: {venda.NumeroPedido}\n" +
            $"Data: {venda.Data:dd/MM/yyyy}\n" +
            $"Cliente: {venda.Cliente}\n" +
            $"Instrumento: {venda.Instrumento}\n" +
            $"Categoria: {venda.Categoria}\n" +
            $"Quantidade: {venda.Quantidade}\n" +
            $"Valor unitário: {venda.ValorUnitario.ToString("C2", CulturaBr)}\n" +
            $"Total: {venda.Total.ToString("C2", CulturaBr)}",
            "Detalhes do pedido",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void CarregarVendas()
    {
        // Dados de exemplo até a integração com a tela de venda.
        var hoje = DateTime.Today;
        vendas.Clear();
        vendas.AddRange(new[]
        {
            new VendaRelatorio(1001, hoje.AddDays(-25), "Ana Souza", "Violão Folk Tagima", "Cordas", 1, 1299.90m),
            new VendaRelatorio(1002, hoje.AddDays(-21), "Bruno Lima", "Teclado Yamaha PSR-E373", "Teclas", 1, 1899.00m),
            new VendaRelatorio(1003, hoje.AddDays(-18), "Carla Mendes", "Encordoamento Elixir .010", "Acessórios", 3, 89.90m),
            new VendaRelatorio(1004, hoje.AddDays(-14), "Diego Rocha", "Bateria Acústica Pearl Roadshow", "Percussão", 1, 4590.00m),
            new VendaRelatorio(1005, hoje.AddDays(-10), "Ana Souza", "Saxofone Alto Eagle", "Sopro", 1, 3250.00m),
            new VendaRelatorio(1006, hoje.AddDays(-7), "Eduarda Alves", "Guitarra Fender Stratocaster", "Cordas", 1, 7899.00m),
            new VendaRelatorio(1007, hoje.AddDays(-4), "Felipe Costa", "Baqueta Vic Firth 5A", "Acessórios", 4, 69.90m),
            new VendaRelatorio(1008, hoje.AddDays(-2), "Bruno Lima", "Piano Digital Casio CDP-S110", "Teclas", 1, 3199.00m),
            new VendaRelatorio(1009, hoje, "Gabriela Nunes", "Ukulele Soprano Kalani", "Cordas", 2, 349.90m),
        });
    }

    private void LimparFiltros()
    {
        dtpDataInicial.Value = DateTime.Today.AddDays(-30);
        dtpDataFinal.Value = DateTime.Today;
        cboCategoria.SelectedItem = TodasCategorias;
        txtCliente.Clear();
    }

    private void AplicarFiltros()
    {
        var dataInicial = dtpDataInicial.Value.Date;
        var dataFinal = dtpDataFinal.Value.Date;

        if (dataInicial > dataFinal)
        {
            MessageBox.Show(
                "A data inicial não pode ser maior que a data final.",
                "Filtro inválido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            dtpDataInicial.Focus();
            return;
        }

        var categoria = cboCategoria.SelectedItem as string ?? TodasCategorias;
        var cliente = txtCliente.Text.Trim();

        var filtradas = vendas
            .Where(v => v.Data.Date >= dataInicial && v.Data.Date <= dataFinal)
            .Where(v => categoria == TodasCategorias || v.Categoria == categoria)
            .Where(v => cliente.Length == 0 || v.Cliente.Contains(cliente, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(v => v.Data)
            .ToList();

        PreencherGrade(filtradas);
        AtualizarResumo(filtradas);
        tslStatus.Text = filtradas.Count == 0 ? "Nenhuma venda encontrada para os filtros informados" : "Pronto";
    }

    private void PreencherGrade(List<VendaRelatorio> lista)
    {
        dgvVendas.Rows.Clear();

        foreach (var venda in lista)
        {
            var indice = dgvVendas.Rows.Add(
                venda.NumeroPedido,
                venda.Data.ToString("dd/MM/yyyy"),
                venda.Cliente,
                venda.Instrumento,
                venda.Categoria,
                venda.Quantidade,
                venda.ValorUnitario,
                venda.Total);
            dgvVendas.Rows[indice].Tag = venda;
        }

        tslRegistros.Text = $"{lista.Count} registro(s)";
    }

    private void AtualizarResumo(List<VendaRelatorio> lista)
    {
        lblTotalPedidos.Text = lista.Count.ToString();
        lblTotalItens.Text = lista.Sum(v => v.Quantidade).ToString();
        lblValorTotal.Text = lista.Sum(v => v.Total).ToString("C2", CulturaBr);
    }

    private sealed record VendaRelatorio(
        int NumeroPedido,
        DateTime Data,
        string Cliente,
        string Instrumento,
        string Categoria,
        int Quantidade,
        decimal ValorUnitario)
    {
        public decimal Total => Quantidade * ValorUnitario;
    }
}
