using System.Windows.Forms;
using LojaInstrumentos.Models;

namespace LojaInstrumentos;

public partial class FormPrincipal : Form
{
    private readonly System.Windows.Forms.Timer tmrRelogio = new() { Interval = 1000 };

    public FormPrincipal()
    {
        InitializeComponent();

        Load += FormPrincipal_Load;
        FormClosing += FormPrincipal_FormClosing;
        tmrRelogio.Tick += TmrRelogio_Tick;

        btnNovaVenda.Click += AbrirVenda_Click;
        mniNovaVenda.Click += AbrirVenda_Click;
        btnRelatorioVendas.Click += AbrirRelatorio_Click;
        mniRelatorioVendas.Click += AbrirRelatorio_Click;
        btnSair.Click += Sair_Click;
        mniSair.Click += Sair_Click;
        mniSobre.Click += MniSobre_Click;
    }

    private void FormPrincipal_Load(object? sender, EventArgs e)
    {
        Text = InfoSistema.TituloJanela("Menu Principal");
        AtualizarDataHora();
        tmrRelogio.Start();
    }

    private void TmrRelogio_Tick(object? sender, EventArgs e)
    {
        AtualizarDataHora();
    }

    private void AtualizarDataHora()
    {
        tslDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    }

    private void AbrirVenda_Click(object? sender, EventArgs e)
    {
        tslStatus.Text = "Abrindo: Venda de Instrumentos";

        using var formVenda = new FormVenda();
        formVenda.ShowDialog(this);

        tslStatus.Text = "Pronto";
    }

    private void AbrirRelatorio_Click(object? sender, EventArgs e)
    {
        tslStatus.Text = "Abrindo: Relatório de Vendas";
        using var formRelatorio = new FormRelatorio();
        formRelatorio.ShowDialog(this);
        tslStatus.Text = "Pronto";
    }

    private void AbrirTelaEmDesenvolvimento(string nomeTela)
    {
        tslStatus.Text = $"Abrindo: {nomeTela}";
        MessageBox.Show(
            $"A tela \"{nomeTela}\" ainda está em desenvolvimento.",
            "Em desenvolvimento",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        tslStatus.Text = "Pronto";
    }

    private void MniSobre_Click(object? sender, EventArgs e)
    {
        MessageBox.Show(
            InfoSistema.TextoSobre,
            "Sobre",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void Sair_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void FormPrincipal_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var resposta = MessageBox.Show(
            "Deseja realmente sair do sistema?",
            "Sair",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (resposta == DialogResult.No)
        {
            e.Cancel = true;
            return;
        }

        tmrRelogio.Stop();
        tmrRelogio.Dispose();
    }
}
