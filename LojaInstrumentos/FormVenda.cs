using System.Globalization;
using System.Windows.Forms;
using LojaInstrumentos.Models;

namespace LojaInstrumentos;

public partial class FormVenda : Form
{
    private static readonly CultureInfo Cultura = new("pt-BR");

    private sealed record InstrumentoCatalogo(string Nome, decimal Preco);

    private sealed class ItemVenda
    {
        public required string Instrumento { get; init; }
        public required decimal PrecoUnitario { get; init; }
        public int Quantidade { get; set; }
        public decimal Subtotal => PrecoUnitario * Quantidade;
    }

    private static readonly InstrumentoCatalogo[] Catalogo =
    {
        new("Violão Acústico", 899.90m),
        new("Guitarra Elétrica", 2499.00m),
        new("Baixo Elétrico 4 Cordas", 2199.00m),
        new("Teclado Digital 61 Teclas", 1599.90m),
        new("Bateria Acústica Completa", 4890.00m),
        new("Ukulele Soprano", 349.90m),
        new("Flauta Doce", 59.90m),
        new("Saxofone Alto", 5990.00m),
    };

    private readonly List<ItemVenda> itens = new();

    public FormVenda()
    {
        InitializeComponent();

        Load += FormVenda_Load;
        FormClosing += FormVenda_FormClosing;

        cboInstrumento.SelectedIndexChanged += CboInstrumento_SelectedIndexChanged;
        btnAdicionar.Click += BtnAdicionar_Click;
        btnRemoverItem.Click += BtnRemoverItem_Click;
        btnLimpar.Click += BtnLimpar_Click;
        btnCancelar.Click += BtnCancelar_Click;
        btnFinalizar.Click += BtnFinalizar_Click;
    }

    private void FormVenda_Load(object? sender, EventArgs e)
    {
        Text = InfoSistema.TituloJanela("Venda de Instrumentos");

        cboInstrumento.DisplayMember = nameof(InstrumentoCatalogo.Nome);
        cboInstrumento.DataSource = Catalogo.ToList();
        cboInstrumento.SelectedIndex = -1;

        dtpData.Value = DateTime.Now;

        AtualizarTela();
    }

    private void CboInstrumento_SelectedIndexChanged(object? sender, EventArgs e)
    {
        txtPrecoUnitario.Text = cboInstrumento.SelectedItem is InstrumentoCatalogo instrumento
            ? FormatarMoeda(instrumento.Preco)
            : FormatarMoeda(0);
    }

    private void BtnAdicionar_Click(object? sender, EventArgs e)
    {
        if (cboInstrumento.SelectedItem is not InstrumentoCatalogo instrumento)
        {
            MessageBox.Show("Selecione um instrumento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cboInstrumento.Focus();
            return;
        }

        var quantidade = (int)nudQuantidade.Value;
        var existente = itens.FirstOrDefault(i => i.Instrumento == instrumento.Nome);

        if (existente is null)
        {
            itens.Add(new ItemVenda
            {
                Instrumento = instrumento.Nome,
                PrecoUnitario = instrumento.Preco,
                Quantidade = quantidade,
            });
        }
        else
        {
            existente.Quantidade += quantidade;
        }

        cboInstrumento.SelectedIndex = -1;
        nudQuantidade.Value = 1;
        cboInstrumento.Focus();
        AtualizarTela();
    }

    private void BtnRemoverItem_Click(object? sender, EventArgs e)
    {
        if (dgvItens.CurrentRow is null)
        {
            MessageBox.Show("Selecione um item na lista para remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        itens.RemoveAt(dgvItens.CurrentRow.Index);
        AtualizarTela();
    }

    private void BtnLimpar_Click(object? sender, EventArgs e)
    {
        if (itens.Count == 0 && string.IsNullOrWhiteSpace(txtCliente.Text))
        {
            return;
        }

        if (ConfirmarDescarte("Deseja limpar todos os dados do pedido?"))
        {
            LimparPedido();
        }
    }

    private void BtnCancelar_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void BtnFinalizar_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtCliente.Text))
        {
            MessageBox.Show("Informe o nome do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCliente.Focus();
            return;
        }

        if (itens.Count == 0)
        {
            MessageBox.Show("Adicione ao menos um instrumento ao pedido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cboInstrumento.Focus();
            return;
        }

        var quantidadeTotal = itens.Sum(i => i.Quantidade);
        var total = itens.Sum(i => i.Subtotal);

        MessageBox.Show(
            $"Venda registrada com sucesso!\n\nCliente: {txtCliente.Text.Trim()}\nData: {dtpData.Value:dd/MM/yyyy}\nItens: {quantidadeTotal}\nTotal: {FormatarMoeda(total)}",
            "Venda finalizada",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        LimparPedido();
    }

    private void FormVenda_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (itens.Count == 0)
        {
            return;
        }

        if (!ConfirmarDescarte("Existe um pedido em andamento. Deseja descartá-lo e sair?"))
        {
            e.Cancel = true;
        }
    }

    private static bool ConfirmarDescarte(string mensagem)
    {
        return MessageBox.Show(
            mensagem,
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes;
    }

    private void LimparPedido()
    {
        itens.Clear();
        txtCliente.Clear();
        dtpData.Value = DateTime.Now;
        cboInstrumento.SelectedIndex = -1;
        nudQuantidade.Value = 1;
        AtualizarTela();
        txtCliente.Focus();
    }

    private void AtualizarTela()
    {
        dgvItens.Rows.Clear();

        foreach (var item in itens)
        {
            dgvItens.Rows.Add(
                item.Instrumento,
                item.Quantidade,
                FormatarMoeda(item.PrecoUnitario),
                FormatarMoeda(item.Subtotal));
        }

        lblValorTotal.Text = FormatarMoeda(itens.Sum(i => i.Subtotal));
        btnRemoverItem.Enabled = itens.Count > 0;
        btnFinalizar.Enabled = itens.Count > 0;
    }

    private static string FormatarMoeda(decimal valor)
    {
        return valor.ToString("C2", Cultura);
    }
}
