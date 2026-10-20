using System.Drawing;
using System.Windows.Forms;

namespace LojaInstrumentos;

partial class FormSplash
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        lblIcone = new Label();
        lblTitulo = new Label();
        lblSubtitulo = new Label();
        pgbCarregamento = new ProgressBar();
        lblStatus = new Label();
        lblVersao = new Label();
        tmrCarregamento = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        //
        // lblIcone
        //
        lblIcone.Font = new Font("Segoe UI Emoji", 40F);
        lblIcone.ForeColor = Color.White;
        lblIcone.Location = new Point(0, 30);
        lblIcone.Name = "lblIcone";
        lblIcone.Size = new Size(500, 80);
        lblIcone.Text = "🎸";
        lblIcone.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblTitulo
        //
        lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(0, 115);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(500, 40);
        lblTitulo.Text = "Loja de Instrumentos Musicais";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblSubtitulo
        //
        lblSubtitulo.Font = new Font("Segoe UI", 10F);
        lblSubtitulo.ForeColor = Color.Gainsboro;
        lblSubtitulo.Location = new Point(0, 155);
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Size = new Size(500, 25);
        lblSubtitulo.Text = "Sistema de Vendas";
        lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
        //
        // pgbCarregamento
        //
        pgbCarregamento.Location = new Point(50, 215);
        pgbCarregamento.Name = "pgbCarregamento";
        pgbCarregamento.Size = new Size(400, 20);
        pgbCarregamento.Style = ProgressBarStyle.Continuous;
        pgbCarregamento.TabIndex = 0;
        //
        // lblStatus
        //
        lblStatus.Font = new Font("Segoe UI", 9F);
        lblStatus.ForeColor = Color.Gainsboro;
        lblStatus.Location = new Point(50, 240);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(400, 20);
        lblStatus.Text = "Carregando...";
        lblStatus.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblVersao
        //
        lblVersao.Font = new Font("Segoe UI", 8F);
        lblVersao.ForeColor = Color.DarkGray;
        lblVersao.Location = new Point(390, 275);
        lblVersao.Name = "lblVersao";
        lblVersao.Size = new Size(100, 18);
        lblVersao.Text = "Versão 1.0";
        lblVersao.TextAlign = ContentAlignment.MiddleRight;
        //
        // tmrCarregamento
        //
        tmrCarregamento.Interval = 30;
        //
        // FormSplash
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(34, 40, 49);
        ClientSize = new Size(500, 300);
        Controls.Add(lblIcone);
        Controls.Add(lblTitulo);
        Controls.Add(lblSubtitulo);
        Controls.Add(pgbCarregamento);
        Controls.Add(lblStatus);
        Controls.Add(lblVersao);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormSplash";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Loja de Instrumentos Musicais";
        ResumeLayout(false);
    }

    private Label lblIcone;
    private Label lblTitulo;
    private Label lblSubtitulo;
    private ProgressBar pgbCarregamento;
    private Label lblStatus;
    private Label lblVersao;
    private System.Windows.Forms.Timer tmrCarregamento;
}
