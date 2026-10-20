using System.Drawing;
using System.Windows.Forms;

namespace LojaInstrumentos;

partial class FormVenda
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
        pnlCabecalho = new Panel();
        lblTitulo = new Label();
        lblSubtitulo = new Label();
        grpCliente = new GroupBox();
        lblCliente = new Label();
        txtCliente = new TextBox();
        lblData = new Label();
        dtpData = new DateTimePicker();
        grpItem = new GroupBox();
        lblInstrumento = new Label();
        cboInstrumento = new ComboBox();
        lblQuantidade = new Label();
        nudQuantidade = new NumericUpDown();
        lblPrecoUnitario = new Label();
        txtPrecoUnitario = new TextBox();
        btnAdicionar = new Button();
        dgvItens = new DataGridView();
        colInstrumento = new DataGridViewTextBoxColumn();
        colQuantidade = new DataGridViewTextBoxColumn();
        colPrecoUnitario = new DataGridViewTextBoxColumn();
        colSubtotal = new DataGridViewTextBoxColumn();
        pnlRodape = new Panel();
        btnRemoverItem = new Button();
        btnLimpar = new Button();
        btnCancelar = new Button();
        lblTotal = new Label();
        lblValorTotal = new Label();
        btnFinalizar = new Button();
        pnlCabecalho.SuspendLayout();
        grpCliente.SuspendLayout();
        grpItem.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
        pnlRodape.SuspendLayout();
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
        pnlCabecalho.Size = new Size(900, 70);
        pnlCabecalho.TabIndex = 0;
        //
        // lblTitulo
        //
        lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(0, 8);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(900, 36);
        lblTitulo.Text = "🛒 Venda de Instrumentos";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblSubtitulo
        //
        lblSubtitulo.Font = new Font("Segoe UI", 10F);
        lblSubtitulo.ForeColor = Color.Gainsboro;
        lblSubtitulo.Location = new Point(0, 42);
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Size = new Size(900, 22);
        lblSubtitulo.Text = "Lançamento de pedidos";
        lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
        //
        // grpCliente
        //
        grpCliente.Controls.Add(lblCliente);
        grpCliente.Controls.Add(txtCliente);
        grpCliente.Controls.Add(lblData);
        grpCliente.Controls.Add(dtpData);
        grpCliente.Font = new Font("Segoe UI", 9F);
        grpCliente.Location = new Point(15, 82);
        grpCliente.Name = "grpCliente";
        grpCliente.Size = new Size(870, 65);
        grpCliente.TabIndex = 1;
        grpCliente.TabStop = false;
        grpCliente.Text = "Dados do pedido";
        //
        // lblCliente
        //
        lblCliente.Location = new Point(15, 29);
        lblCliente.Name = "lblCliente";
        lblCliente.Size = new Size(60, 23);
        lblCliente.Text = "Cliente:";
        lblCliente.TextAlign = ContentAlignment.MiddleLeft;
        //
        // txtCliente
        //
        txtCliente.Location = new Point(80, 29);
        txtCliente.MaxLength = 100;
        txtCliente.Name = "txtCliente";
        txtCliente.Size = new Size(400, 23);
        txtCliente.TabIndex = 0;
        //
        // lblData
        //
        lblData.Location = new Point(520, 29);
        lblData.Name = "lblData";
        lblData.Size = new Size(45, 23);
        lblData.Text = "Data:";
        lblData.TextAlign = ContentAlignment.MiddleLeft;
        //
        // dtpData
        //
        dtpData.Format = DateTimePickerFormat.Short;
        dtpData.Location = new Point(570, 29);
        dtpData.Name = "dtpData";
        dtpData.Size = new Size(120, 23);
        dtpData.TabIndex = 1;
        //
        // grpItem
        //
        grpItem.Controls.Add(lblInstrumento);
        grpItem.Controls.Add(cboInstrumento);
        grpItem.Controls.Add(lblQuantidade);
        grpItem.Controls.Add(nudQuantidade);
        grpItem.Controls.Add(lblPrecoUnitario);
        grpItem.Controls.Add(txtPrecoUnitario);
        grpItem.Controls.Add(btnAdicionar);
        grpItem.Font = new Font("Segoe UI", 9F);
        grpItem.Location = new Point(15, 155);
        grpItem.Name = "grpItem";
        grpItem.Size = new Size(870, 80);
        grpItem.TabIndex = 2;
        grpItem.TabStop = false;
        grpItem.Text = "Item do pedido";
        //
        // lblInstrumento
        //
        lblInstrumento.Location = new Point(15, 32);
        lblInstrumento.Name = "lblInstrumento";
        lblInstrumento.Size = new Size(80, 23);
        lblInstrumento.Text = "Instrumento:";
        lblInstrumento.TextAlign = ContentAlignment.MiddleLeft;
        //
        // cboInstrumento
        //
        cboInstrumento.DropDownStyle = ComboBoxStyle.DropDownList;
        cboInstrumento.Location = new Point(100, 32);
        cboInstrumento.Name = "cboInstrumento";
        cboInstrumento.Size = new Size(250, 23);
        cboInstrumento.TabIndex = 0;
        //
        // lblQuantidade
        //
        lblQuantidade.Location = new Point(365, 32);
        lblQuantidade.Name = "lblQuantidade";
        lblQuantidade.Size = new Size(40, 23);
        lblQuantidade.Text = "Qtd.:";
        lblQuantidade.TextAlign = ContentAlignment.MiddleLeft;
        //
        // nudQuantidade
        //
        nudQuantidade.Location = new Point(410, 32);
        nudQuantidade.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
        nudQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudQuantidade.Name = "nudQuantidade";
        nudQuantidade.Size = new Size(65, 23);
        nudQuantidade.TabIndex = 1;
        nudQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
        //
        // lblPrecoUnitario
        //
        lblPrecoUnitario.Location = new Point(495, 32);
        lblPrecoUnitario.Name = "lblPrecoUnitario";
        lblPrecoUnitario.Size = new Size(75, 23);
        lblPrecoUnitario.Text = "Preço unit.:";
        lblPrecoUnitario.TextAlign = ContentAlignment.MiddleLeft;
        //
        // txtPrecoUnitario
        //
        txtPrecoUnitario.Location = new Point(575, 32);
        txtPrecoUnitario.Name = "txtPrecoUnitario";
        txtPrecoUnitario.ReadOnly = true;
        txtPrecoUnitario.Size = new Size(100, 23);
        txtPrecoUnitario.TabIndex = 2;
        txtPrecoUnitario.TabStop = false;
        txtPrecoUnitario.Text = "R$ 0,00";
        txtPrecoUnitario.TextAlign = HorizontalAlignment.Right;
        //
        // btnAdicionar
        //
        btnAdicionar.Location = new Point(700, 29);
        btnAdicionar.Name = "btnAdicionar";
        btnAdicionar.Size = new Size(150, 30);
        btnAdicionar.TabIndex = 3;
        btnAdicionar.Text = "Adicionar ao pedido";
        btnAdicionar.UseVisualStyleBackColor = true;
        //
        // dgvItens
        //
        dgvItens.AllowUserToAddRows = false;
        dgvItens.AllowUserToDeleteRows = false;
        dgvItens.AllowUserToResizeRows = false;
        dgvItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvItens.BackgroundColor = SystemColors.Window;
        dgvItens.Columns.AddRange(new DataGridViewColumn[] { colInstrumento, colQuantidade, colPrecoUnitario, colSubtotal });
        dgvItens.Location = new Point(15, 245);
        dgvItens.MultiSelect = false;
        dgvItens.Name = "dgvItens";
        dgvItens.ReadOnly = true;
        dgvItens.RowHeadersVisible = false;
        dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvItens.Size = new Size(870, 265);
        dgvItens.TabIndex = 3;
        //
        // colInstrumento
        //
        colInstrumento.FillWeight = 50F;
        colInstrumento.HeaderText = "Instrumento";
        colInstrumento.Name = "colInstrumento";
        colInstrumento.ReadOnly = true;
        //
        // colQuantidade
        //
        colQuantidade.DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight };
        colQuantidade.FillWeight = 12F;
        colQuantidade.HeaderText = "Qtd.";
        colQuantidade.Name = "colQuantidade";
        colQuantidade.ReadOnly = true;
        //
        // colPrecoUnitario
        //
        colPrecoUnitario.DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight };
        colPrecoUnitario.FillWeight = 19F;
        colPrecoUnitario.HeaderText = "Preço unitário";
        colPrecoUnitario.Name = "colPrecoUnitario";
        colPrecoUnitario.ReadOnly = true;
        //
        // colSubtotal
        //
        colSubtotal.DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight };
        colSubtotal.FillWeight = 19F;
        colSubtotal.HeaderText = "Subtotal";
        colSubtotal.Name = "colSubtotal";
        colSubtotal.ReadOnly = true;
        //
        // pnlRodape
        //
        pnlRodape.BackColor = Color.WhiteSmoke;
        pnlRodape.Controls.Add(btnRemoverItem);
        pnlRodape.Controls.Add(btnLimpar);
        pnlRodape.Controls.Add(btnCancelar);
        pnlRodape.Controls.Add(lblTotal);
        pnlRodape.Controls.Add(lblValorTotal);
        pnlRodape.Controls.Add(btnFinalizar);
        pnlRodape.Dock = DockStyle.Bottom;
        pnlRodape.Location = new Point(0, 530);
        pnlRodape.Name = "pnlRodape";
        pnlRodape.Size = new Size(900, 70);
        pnlRodape.TabIndex = 4;
        //
        // btnRemoverItem
        //
        btnRemoverItem.Location = new Point(15, 18);
        btnRemoverItem.Name = "btnRemoverItem";
        btnRemoverItem.Size = new Size(140, 34);
        btnRemoverItem.TabIndex = 0;
        btnRemoverItem.Text = "Remover item";
        btnRemoverItem.UseVisualStyleBackColor = true;
        //
        // btnLimpar
        //
        btnLimpar.Location = new Point(165, 18);
        btnLimpar.Name = "btnLimpar";
        btnLimpar.Size = new Size(110, 34);
        btnLimpar.TabIndex = 1;
        btnLimpar.Text = "Limpar";
        btnLimpar.UseVisualStyleBackColor = true;
        //
        // btnCancelar
        //
        btnCancelar.Location = new Point(285, 18);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(110, 34);
        btnCancelar.TabIndex = 2;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        //
        // lblTotal
        //
        lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTotal.Location = new Point(440, 18);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(70, 34);
        lblTotal.Text = "Total:";
        lblTotal.TextAlign = ContentAlignment.MiddleRight;
        //
        // lblValorTotal
        //
        lblValorTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblValorTotal.ForeColor = Color.DarkGreen;
        lblValorTotal.Location = new Point(515, 14);
        lblValorTotal.Name = "lblValorTotal";
        lblValorTotal.Size = new Size(220, 42);
        lblValorTotal.Text = "R$ 0,00";
        lblValorTotal.TextAlign = ContentAlignment.MiddleLeft;
        //
        // btnFinalizar
        //
        btnFinalizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnFinalizar.Location = new Point(745, 18);
        btnFinalizar.Name = "btnFinalizar";
        btnFinalizar.Size = new Size(140, 34);
        btnFinalizar.TabIndex = 3;
        btnFinalizar.Text = "Finalizar venda";
        btnFinalizar.UseVisualStyleBackColor = true;
        //
        // FormVenda
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 600);
        Controls.Add(dgvItens);
        Controls.Add(grpItem);
        Controls.Add(grpCliente);
        Controls.Add(pnlRodape);
        Controls.Add(pnlCabecalho);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormVenda";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Venda de Instrumentos";
        pnlCabecalho.ResumeLayout(false);
        grpCliente.ResumeLayout(false);
        grpCliente.PerformLayout();
        grpItem.ResumeLayout(false);
        grpItem.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
        pnlRodape.ResumeLayout(false);
        ResumeLayout(false);
    }

    private Panel pnlCabecalho;
    private Label lblTitulo;
    private Label lblSubtitulo;
    private GroupBox grpCliente;
    private Label lblCliente;
    private TextBox txtCliente;
    private Label lblData;
    private DateTimePicker dtpData;
    private GroupBox grpItem;
    private Label lblInstrumento;
    private ComboBox cboInstrumento;
    private Label lblQuantidade;
    private NumericUpDown nudQuantidade;
    private Label lblPrecoUnitario;
    private TextBox txtPrecoUnitario;
    private Button btnAdicionar;
    private DataGridView dgvItens;
    private DataGridViewTextBoxColumn colInstrumento;
    private DataGridViewTextBoxColumn colQuantidade;
    private DataGridViewTextBoxColumn colPrecoUnitario;
    private DataGridViewTextBoxColumn colSubtotal;
    private Panel pnlRodape;
    private Button btnRemoverItem;
    private Button btnLimpar;
    private Button btnCancelar;
    private Label lblTotal;
    private Label lblValorTotal;
    private Button btnFinalizar;
}
