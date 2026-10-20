using System.Windows.Forms;
using LojaInstrumentos.Models;

namespace LojaInstrumentos;

public partial class FormSplash : Form
{
    private const int ProgressoMaximo = 100;
    private const int Incremento = 2;

    public FormSplash()
    {
        InitializeComponent();

        Load += FormSplash_Load;
        tmrCarregamento.Tick += TmrCarregamento_Tick;
    }

    private void FormSplash_Load(object? sender, EventArgs e)
    {
        pgbCarregamento.Minimum = 0;
        pgbCarregamento.Maximum = ProgressoMaximo;
        pgbCarregamento.Value = 0;
        lblStatus.Text = EtapaCarregamento.ObterMensagem(0);

        tmrCarregamento.Start();
    }

    private void TmrCarregamento_Tick(object? sender, EventArgs e)
    {
        int novoValor = Math.Min(pgbCarregamento.Value + Incremento, ProgressoMaximo);
        pgbCarregamento.Value = novoValor;
        lblStatus.Text = EtapaCarregamento.ObterMensagem(novoValor);

        if (novoValor >= ProgressoMaximo)
        {
            FinalizarCarregamento();
        }
    }

    private void FinalizarCarregamento()
    {
        tmrCarregamento.Stop();
        DialogResult = DialogResult.OK;
        Close();
    }
}
