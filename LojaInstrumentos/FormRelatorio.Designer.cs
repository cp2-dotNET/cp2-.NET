using System.Drawing;
using System.Windows.Forms;

namespace LojaInstrumentos;

partial class FormRelatorio
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
        DataGridViewCellStyle estiloMoeda = new DataGridViewCellStyle();
        DataGridViewCellStyle estiloCentro = new DataGridViewCellStyle();
        pnlCabecalho = new Panel();
        lblTitulo = new Label();
        lblSubtitulo = new Label();
        grpFiltros = new GroupBox();
        lblDataInicial = new Label();
        dtpDataInicial = new DateTimePicker();
        lblDataFinal = new Label();
        dtpDataFinal = new DateTimePicker();
        lblCategoria = new Label();
        cboCategoria = new ComboBox();
        lblCliente = new Label();
        txtCliente = new TextBox();
        btnFiltrar = new Button();
        btnLimpar = new Button();
        dgvVendas = new DataGridView();
        colNumeroPedido = new DataGridViewTextBoxColumn();
        colData = new DataGridViewTextBoxColumn();
        colCliente = new DataGridViewTextBoxColumn();
        colInstrumento = new DataGridViewTextBoxColumn();
        colCategoria = new DataGridViewTextBoxColumn();
        colQuantidade = new DataGridViewTextBoxColumn();
        colValorUnitario = new DataGridViewTextBoxColumn();
        colTotal = new DataGridViewTextBoxColumn();
        grpResumo = new GroupBox();
        lblTotalPedidosTitulo = new Label();
        lblTotalPedidos = new Label();
        lblTotalItensTitulo = new Label();
        lblTotalItens = new Label();
        lblValorTotalTitulo = new Label();
        lblValorTotal = new Label();
        btnAtualizar = new Button();
        btnFechar = new Button();
        stsRelatorio = new StatusStrip();
        tslStatus = new ToolStripStatusLabel();
        tslRegistros = new ToolStripStatusLabel();
        pnlCabecalho.SuspendLayout();
        grpFiltros.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvVendas).BeginInit();
        grpResumo.SuspendLayout();
        stsRelatorio.SuspendLayout();
        SuspendLayout();
        //
        // pnlCabecalho
        //
        pnlCabecalho.BackColor = Color.FromArgb(34, 40, 49);
        pnlCabecalho.Controls.Add(lblTitulo);
        pnlCabecalho.Controls.Add(lblSubtitulo);
        pnlCabecalho.Dock = DockStyle.Top;
        pnlCabecalho.Location = new Point(0, 0);
        pnlCabecalho.Name = "pnlCabecalho";
        pnlCabecalho.Size = new Size(900, 80);
        pnlCabecalho.TabIndex = 0;
        //
        // lblTitulo
        //
        lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(0, 10);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(900, 36);
        lblTitulo.Text = "📊 Relatório de Vendas";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblSubtitulo
        //
        lblSubtitulo.Font = new Font("Segoe UI", 10F);
        lblSubtitulo.ForeColor = Color.Gainsboro;
        lblSubtitulo.Location = new Point(0, 48);
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Size = new Size(900, 22);
        lblSubtitulo.Text = "Listagem e visualização dos pedidos realizados";
        lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
        //
        // grpFiltros
        //
        grpFiltros.Controls.Add(lblDataInicial);
        grpFiltros.Controls.Add(dtpDataInicial);
        grpFiltros.Controls.Add(lblDataFinal);
        grpFiltros.Controls.Add(dtpDataFinal);
        grpFiltros.Controls.Add(lblCategoria);
        grpFiltros.Controls.Add(cboCategoria);
        grpFiltros.Controls.Add(lblCliente);
        grpFiltros.Controls.Add(txtCliente);
        grpFiltros.Controls.Add(btnFiltrar);
        grpFiltros.Controls.Add(btnLimpar);
        grpFiltros.Font = new Font("Segoe UI", 9F);
        grpFiltros.Location = new Point(12, 92);
        grpFiltros.Name = "grpFiltros";
        grpFiltros.Size = new Size(876, 80);
        grpFiltros.TabIndex = 1;
        grpFiltros.TabStop = false;
        grpFiltros.Text = "Filtros";
        //
        // lblDataInicial
        //
        lblDataInicial.AutoSize = true;
        lblDataInicial.Location = new Point(15, 22);
        lblDataInicial.Name = "lblDataInicial";
        lblDataInicial.Text = "Data inicial:";
        //
        // dtpDataInicial
        //
        dtpDataInicial.Format = DateTimePickerFormat.Short;
        dtpDataInicial.Location = new Point(15, 42);
        dtpDataInicial.Name = "dtpDataInicial";
        dtpDataInicial.Size = new Size(120, 23);
        dtpDataInicial.TabIndex = 0;
        //
        // lblDataFinal
        //
        lblDataFinal.AutoSize = true;
        lblDataFinal.Location = new Point(150, 22);
        lblDataFinal.Name = "lblDataFinal";
        lblDataFinal.Text = "Data final:";
        //
        // dtpDataFinal
        //
        dtpDataFinal.Format = DateTimePickerFormat.Short;
        dtpDataFinal.Location = new Point(150, 42);
        dtpDataFinal.Name = "dtpDataFinal";
        dtpDataFinal.Size = new Size(120, 23);
        dtpDataFinal.TabIndex = 1;
        //
        // lblCategoria
        //
        lblCategoria.AutoSize = true;
        lblCategoria.Location = new Point(285, 22);
        lblCategoria.Name = "lblCategoria";
        lblCategoria.Text = "Categoria:";
        //
        // cboCategoria
        //
        cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCategoria.Items.AddRange(new object[] { "Todas", "Cordas", "Teclas", "Percussão", "Sopro", "Acessórios" });
        cboCategoria.Location = new Point(285, 42);
        cboCategoria.Name = "cboCategoria";
        cboCategoria.Size = new Size(160, 23);
        cboCategoria.TabIndex = 2;
        //
        // lblCliente
        //
        lblCliente.AutoSize = true;
        lblCliente.Location = new Point(460, 22);
        lblCliente.Name = "lblCliente";
        lblCliente.Text = "Cliente:";
        //
        // txtCliente
        //
        txtCliente.Location = new Point(460, 42);
        txtCliente.Name = "txtCliente";
        txtCliente.PlaceholderText = "Nome do cliente";
        txtCliente.Size = new Size(180, 23);
        txtCliente.TabIndex = 3;
        //
        // btnFiltrar
        //
        btnFiltrar.Location = new Point(655, 40);
        btnFiltrar.Name = "btnFiltrar";
        btnFiltrar.Size = new Size(100, 27);
        btnFiltrar.TabIndex = 4;
        btnFiltrar.Text = "🔍 Filtrar";
        btnFiltrar.UseVisualStyleBackColor = true;
        //
        // btnLimpar
        //
        btnLimpar.Location = new Point(765, 40);
        btnLimpar.Name = "btnLimpar";
        btnLimpar.Size = new Size(100, 27);
        btnLimpar.TabIndex = 5;
        btnLimpar.Text = "Limpar";
        btnLimpar.UseVisualStyleBackColor = true;
        //
        // dgvVendas
        //
        dgvVendas.AllowUserToAddRows = false;
        dgvVendas.AllowUserToDeleteRows = false;
        dgvVendas.AllowUserToResizeRows = false;
        dgvVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvVendas.BackgroundColor = Color.White;
        dgvVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvVendas.Columns.AddRange(new DataGridViewColumn[] { colNumeroPedido, colData, colCliente, colInstrumento, colCategoria, colQuantidade, colValorUnitario, colTotal });
        dgvVendas.Location = new Point(12, 182);
        dgvVendas.MultiSelect = false;
        dgvVendas.Name = "dgvVendas";
        dgvVendas.ReadOnly = true;
        dgvVendas.RowHeadersVisible = false;
        dgvVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvVendas.Size = new Size(876, 280);
        dgvVendas.TabIndex = 2;
        //
        // estiloCentro / estiloMoeda
        //
        estiloCentro.Alignment = DataGridViewContentAlignment.MiddleCenter;
        estiloMoeda.Alignment = DataGridViewContentAlignment.MiddleRight;
        estiloMoeda.Format = "C2";
        //
        // colNumeroPedido
        //
        colNumeroPedido.DefaultCellStyle = estiloCentro;
        colNumeroPedido.FillWeight = 60F;
        colNumeroPedido.HeaderText = "Nº Pedido";
        colNumeroPedido.Name = "colNumeroPedido";
        colNumeroPedido.ReadOnly = true;
        //
        // colData
        //
        colData.DefaultCellStyle = estiloCentro;
        colData.FillWeight = 80F;
        colData.HeaderText = "Data";
        colData.Name = "colData";
        colData.ReadOnly = true;
        //
        // colCliente
        //
        colCliente.FillWeight = 130F;
        colCliente.HeaderText = "Cliente";
        colCliente.Name = "colCliente";
        colCliente.ReadOnly = true;
        //
        // colInstrumento
        //
        colInstrumento.FillWeight = 130F;
        colInstrumento.HeaderText = "Instrumento";
        colInstrumento.Name = "colInstrumento";
        colInstrumento.ReadOnly = true;
        //
        // colCategoria
        //
        colCategoria.FillWeight = 90F;
        colCategoria.HeaderText = "Categoria";
        colCategoria.Name = "colCategoria";
        colCategoria.ReadOnly = true;
        //
        // colQuantidade
        //
        colQuantidade.DefaultCellStyle = estiloCentro;
        colQuantidade.FillWeight = 50F;
        colQuantidade.HeaderText = "Qtd.";
        colQuantidade.Name = "colQuantidade";
        colQuantidade.ReadOnly = true;
        //
        // colValorUnitario
        //
        colValorUnitario.DefaultCellStyle = estiloMoeda;
        colValorUnitario.FillWeight = 90F;
        colValorUnitario.HeaderText = "Valor unit.";
        colValorUnitario.Name = "colValorUnitario";
        colValorUnitario.ReadOnly = true;
        //
        // colTotal
        //
        colTotal.DefaultCellStyle = estiloMoeda;
        colTotal.FillWeight = 90F;
        colTotal.HeaderText = "Total";
        colTotal.Name = "colTotal";
        colTotal.ReadOnly = true;
        //
        // grpResumo
        //
        grpResumo.Controls.Add(lblTotalPedidosTitulo);
        grpResumo.Controls.Add(lblTotalPedidos);
        grpResumo.Controls.Add(lblTotalItensTitulo);
        grpResumo.Controls.Add(lblTotalItens);
        grpResumo.Controls.Add(lblValorTotalTitulo);
        grpResumo.Controls.Add(lblValorTotal);
        grpResumo.Font = new Font("Segoe UI", 9F);
        grpResumo.Location = new Point(12, 470);
        grpResumo.Name = "grpResumo";
        grpResumo.Size = new Size(876, 60);
        grpResumo.TabIndex = 3;
        grpResumo.TabStop = false;
        grpResumo.Text = "Resumo";
        //
        // lblTotalPedidosTitulo
        //
        lblTotalPedidosTitulo.AutoSize = true;
        lblTotalPedidosTitulo.Location = new Point(15, 27);
        lblTotalPedidosTitulo.Name = "lblTotalPedidosTitulo";
        lblTotalPedidosTitulo.Text = "Total de pedidos:";
        //
        // lblTotalPedidos
        //
        lblTotalPedidos.AutoSize = true;
        lblTotalPedidos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTotalPedidos.Location = new Point(120, 25);
        lblTotalPedidos.Name = "lblTotalPedidos";
        lblTotalPedidos.Text = "0";
        //
        // lblTotalItensTitulo
        //
        lblTotalItensTitulo.AutoSize = true;
        lblTotalItensTitulo.Location = new Point(300, 27);
        lblTotalItensTitulo.Name = "lblTotalItensTitulo";
        lblTotalItensTitulo.Text = "Itens vendidos:";
        //
        // lblTotalItens
        //
        lblTotalItens.AutoSize = true;
        lblTotalItens.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTotalItens.Location = new Point(395, 25);
        lblTotalItens.Name = "lblTotalItens";
        lblTotalItens.Text = "0";
        //
        // lblValorTotalTitulo
        //
        lblValorTotalTitulo.AutoSize = true;
        lblValorTotalTitulo.Location = new Point(590, 27);
        lblValorTotalTitulo.Name = "lblValorTotalTitulo";
        lblValorTotalTitulo.Text = "Valor total:";
        //
        // lblValorTotal
        //
        lblValorTotal.AutoSize = true;
        lblValorTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblValorTotal.ForeColor = Color.ForestGreen;
        lblValorTotal.Location = new Point(660, 25);
        lblValorTotal.Name = "lblValorTotal";
        lblValorTotal.Text = "R$ 0,00";
        //
        // btnAtualizar
        //
        btnAtualizar.Font = new Font("Segoe UI", 10F);
        btnAtualizar.Location = new Point(648, 540);
        btnAtualizar.Name = "btnAtualizar";
        btnAtualizar.Size = new Size(115, 32);
        btnAtualizar.TabIndex = 4;
        btnAtualizar.Text = "Atualizar";
        btnAtualizar.UseVisualStyleBackColor = true;
        //
        // btnFechar
        //
        btnFechar.Font = new Font("Segoe UI", 10F);
        btnFechar.Location = new Point(773, 540);
        btnFechar.Name = "btnFechar";
        btnFechar.Size = new Size(115, 32);
        btnFechar.TabIndex = 5;
        btnFechar.Text = "Fechar";
        btnFechar.UseVisualStyleBackColor = true;
        //
        // stsRelatorio
        //
        stsRelatorio.Items.AddRange(new ToolStripItem[] { tslStatus, tslRegistros });
        stsRelatorio.Location = new Point(0, 578);
        stsRelatorio.Name = "stsRelatorio";
        stsRelatorio.Size = new Size(900, 22);
        stsRelatorio.TabIndex = 6;
        //
        // tslStatus
        //
        tslStatus.Name = "tslStatus";
        tslStatus.Spring = true;
        tslStatus.Text = "Pronto";
        tslStatus.TextAlign = ContentAlignment.MiddleLeft;
        //
        // tslRegistros
        //
        tslRegistros.Name = "tslRegistros";
        tslRegistros.Text = "0 registro(s)";
        //
        // FormRelatorio
        //
        AcceptButton = btnFiltrar;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnFechar;
        ClientSize = new Size(900, 600);
        Controls.Add(grpFiltros);
        Controls.Add(dgvVendas);
        Controls.Add(grpResumo);
        Controls.Add(btnAtualizar);
        Controls.Add(btnFechar);
        Controls.Add(pnlCabecalho);
        Controls.Add(stsRelatorio);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormRelatorio";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Relatório de Vendas";
        pnlCabecalho.ResumeLayout(false);
        grpFiltros.ResumeLayout(false);
        grpFiltros.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvVendas).EndInit();
        grpResumo.ResumeLayout(false);
        grpResumo.PerformLayout();
        stsRelatorio.ResumeLayout(false);
        stsRelatorio.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Panel pnlCabecalho;
    private Label lblTitulo;
    private Label lblSubtitulo;
    private GroupBox grpFiltros;
    private Label lblDataInicial;
    private DateTimePicker dtpDataInicial;
    private Label lblDataFinal;
    private DateTimePicker dtpDataFinal;
    private Label lblCategoria;
    private ComboBox cboCategoria;
    private Label lblCliente;
    private TextBox txtCliente;
    private Button btnFiltrar;
    private Button btnLimpar;
    private DataGridView dgvVendas;
    private DataGridViewTextBoxColumn colNumeroPedido;
    private DataGridViewTextBoxColumn colData;
    private DataGridViewTextBoxColumn colCliente;
    private DataGridViewTextBoxColumn colInstrumento;
    private DataGridViewTextBoxColumn colCategoria;
    private DataGridViewTextBoxColumn colQuantidade;
    private DataGridViewTextBoxColumn colValorUnitario;
    private DataGridViewTextBoxColumn colTotal;
    private GroupBox grpResumo;
    private Label lblTotalPedidosTitulo;
    private Label lblTotalPedidos;
    private Label lblTotalItensTitulo;
    private Label lblTotalItens;
    private Label lblValorTotalTitulo;
    private Label lblValorTotal;
    private Button btnAtualizar;
    private Button btnFechar;
    private StatusStrip stsRelatorio;
    private ToolStripStatusLabel tslStatus;
    private ToolStripStatusLabel tslRegistros;
}
