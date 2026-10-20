using System.Drawing;
using System.Windows.Forms;

namespace LojaInstrumentos;

partial class FormPrincipal
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
        mnsPrincipal = new MenuStrip();
        mniArquivo = new ToolStripMenuItem();
        mniSair = new ToolStripMenuItem();
        mniVendas = new ToolStripMenuItem();
        mniNovaVenda = new ToolStripMenuItem();
        mniRelatorios = new ToolStripMenuItem();
        mniRelatorioVendas = new ToolStripMenuItem();
        mniAjuda = new ToolStripMenuItem();
        mniSobre = new ToolStripMenuItem();
        pnlCabecalho = new Panel();
        lblTitulo = new Label();
        lblSubtitulo = new Label();
        btnNovaVenda = new Button();
        btnRelatorioVendas = new Button();
        btnSair = new Button();
        stsPrincipal = new StatusStrip();
        tslStatus = new ToolStripStatusLabel();
        tslDataHora = new ToolStripStatusLabel();
        mnsPrincipal.SuspendLayout();
        pnlCabecalho.SuspendLayout();
        stsPrincipal.SuspendLayout();
        SuspendLayout();
        //
        // mnsPrincipal
        //
        mnsPrincipal.Items.AddRange(new ToolStripItem[] { mniArquivo, mniVendas, mniRelatorios, mniAjuda });
        mnsPrincipal.Location = new Point(0, 0);
        mnsPrincipal.Name = "mnsPrincipal";
        mnsPrincipal.Size = new Size(800, 24);
        mnsPrincipal.TabIndex = 0;
        //
        // mniArquivo
        //
        mniArquivo.DropDownItems.AddRange(new ToolStripItem[] { mniSair });
        mniArquivo.Name = "mniArquivo";
        mniArquivo.Text = "&Arquivo";
        //
        // mniSair
        //
        mniSair.Name = "mniSair";
        mniSair.ShortcutKeys = Keys.Alt | Keys.F4;
        mniSair.Text = "&Sair";
        //
        // mniVendas
        //
        mniVendas.DropDownItems.AddRange(new ToolStripItem[] { mniNovaVenda });
        mniVendas.Name = "mniVendas";
        mniVendas.Text = "&Vendas";
        //
        // mniNovaVenda
        //
        mniNovaVenda.Name = "mniNovaVenda";
        mniNovaVenda.ShortcutKeys = Keys.Control | Keys.N;
        mniNovaVenda.Text = "&Nova venda";
        //
        // mniRelatorios
        //
        mniRelatorios.DropDownItems.AddRange(new ToolStripItem[] { mniRelatorioVendas });
        mniRelatorios.Name = "mniRelatorios";
        mniRelatorios.Text = "&Relatórios";
        //
        // mniRelatorioVendas
        //
        mniRelatorioVendas.Name = "mniRelatorioVendas";
        mniRelatorioVendas.ShortcutKeys = Keys.Control | Keys.R;
        mniRelatorioVendas.Text = "Relatório de &vendas";
        //
        // mniAjuda
        //
        mniAjuda.DropDownItems.AddRange(new ToolStripItem[] { mniSobre });
        mniAjuda.Name = "mniAjuda";
        mniAjuda.Text = "A&juda";
        //
        // mniSobre
        //
        mniSobre.Name = "mniSobre";
        mniSobre.Text = "&Sobre";
        //
        // pnlCabecalho
        //
        pnlCabecalho.BackColor = Color.FromArgb(34, 40, 49);
        pnlCabecalho.Controls.Add(lblTitulo);
        pnlCabecalho.Controls.Add(lblSubtitulo);
        pnlCabecalho.Dock = DockStyle.Top;
        pnlCabecalho.Location = new Point(0, 24);
        pnlCabecalho.Name = "pnlCabecalho";
        pnlCabecalho.Size = new Size(800, 100);
        pnlCabecalho.TabIndex = 1;
        //
        // lblTitulo
        //
        lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(0, 15);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(800, 40);
        lblTitulo.Text = "🎸 Loja de Instrumentos Musicais";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblSubtitulo
        //
        lblSubtitulo.Font = new Font("Segoe UI", 10F);
        lblSubtitulo.ForeColor = Color.Gainsboro;
        lblSubtitulo.Location = new Point(0, 58);
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Size = new Size(800, 25);
        lblSubtitulo.Text = "Menu Principal — escolha uma opção";
        lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
        //
        // btnNovaVenda
        //
        btnNovaVenda.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnNovaVenda.Location = new Point(100, 170);
        btnNovaVenda.Name = "btnNovaVenda";
        btnNovaVenda.Size = new Size(280, 120);
        btnNovaVenda.TabIndex = 2;
        btnNovaVenda.Text = "🛒\r\nVenda de Instrumentos";
        btnNovaVenda.UseVisualStyleBackColor = true;
        //
        // btnRelatorioVendas
        //
        btnRelatorioVendas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnRelatorioVendas.Location = new Point(420, 170);
        btnRelatorioVendas.Name = "btnRelatorioVendas";
        btnRelatorioVendas.Size = new Size(280, 120);
        btnRelatorioVendas.TabIndex = 3;
        btnRelatorioVendas.Text = "📊\r\nRelatório de Vendas";
        btnRelatorioVendas.UseVisualStyleBackColor = true;
        //
        // btnSair
        //
        btnSair.Font = new Font("Segoe UI", 10F);
        btnSair.Location = new Point(340, 330);
        btnSair.Name = "btnSair";
        btnSair.Size = new Size(120, 40);
        btnSair.TabIndex = 4;
        btnSair.Text = "Sair";
        btnSair.UseVisualStyleBackColor = true;
        //
        // stsPrincipal
        //
        stsPrincipal.Items.AddRange(new ToolStripItem[] { tslStatus, tslDataHora });
        stsPrincipal.Location = new Point(0, 428);
        stsPrincipal.Name = "stsPrincipal";
        stsPrincipal.Size = new Size(800, 22);
        stsPrincipal.TabIndex = 5;
        //
        // tslStatus
        //
        tslStatus.Name = "tslStatus";
        tslStatus.Spring = true;
        tslStatus.Text = "Pronto";
        tslStatus.TextAlign = ContentAlignment.MiddleLeft;
        //
        // tslDataHora
        //
        tslDataHora.Name = "tslDataHora";
        tslDataHora.Text = "--/--/---- --:--";
        //
        // FormPrincipal
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnNovaVenda);
        Controls.Add(btnRelatorioVendas);
        Controls.Add(btnSair);
        Controls.Add(pnlCabecalho);
        Controls.Add(stsPrincipal);
        Controls.Add(mnsPrincipal);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MainMenuStrip = mnsPrincipal;
        MaximizeBox = false;
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Loja de Instrumentos Musicais";
        mnsPrincipal.ResumeLayout(false);
        mnsPrincipal.PerformLayout();
        pnlCabecalho.ResumeLayout(false);
        stsPrincipal.ResumeLayout(false);
        stsPrincipal.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private MenuStrip mnsPrincipal;
    private ToolStripMenuItem mniArquivo;
    private ToolStripMenuItem mniSair;
    private ToolStripMenuItem mniVendas;
    private ToolStripMenuItem mniNovaVenda;
    private ToolStripMenuItem mniRelatorios;
    private ToolStripMenuItem mniRelatorioVendas;
    private ToolStripMenuItem mniAjuda;
    private ToolStripMenuItem mniSobre;
    private Panel pnlCabecalho;
    private Label lblTitulo;
    private Label lblSubtitulo;
    private Button btnNovaVenda;
    private Button btnRelatorioVendas;
    private Button btnSair;
    private StatusStrip stsPrincipal;
    private ToolStripStatusLabel tslStatus;
    private ToolStripStatusLabel tslDataHora;
}
