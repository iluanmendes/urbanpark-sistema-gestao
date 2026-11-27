
namespace frmUrbanPark
{
    partial class frmRegistrarEntrada:Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlCabecalho = new Panel();
            picLogo = new Label();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            grpBuscarVeiculo = new GroupBox();
            lblPlacaVeiculo = new Label();
            mskPlacaveiculo = new MaskedTextBox();
            btnBuscarPorPlaca = new Button();
            grpDadosVeiculo = new GroupBox();
            lblCliente = new Label();
            txtNomeCliente = new TextBox();
            lblCorModelo = new Label();
            txtCorModelo = new TextBox();
            grpMovimentacao = new GroupBox();
            lblVagaSelecionada = new Label();
            txtVagaSelecionada = new TextBox();
            lblDataEntrada = new Label();
            dtInfoDtEntrada = new DateTimePicker();
            lblHoraEntrada = new Label();
            dtInfoHrEntrada = new DateTimePicker();
            btnRegistrarEntrada = new Button();
            btnCancelar = new Button();
            pnlCabecalho.SuspendLayout();
            grpBuscarVeiculo.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            grpMovimentacao.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.FromArgb(15, 65, 125);
            pnlCabecalho.Controls.Add(picLogo);
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Controls.Add(lblSubtitulo);
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(984, 125);
            pnlCabecalho.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Font = new Font("Segoe UI", 38F, FontStyle.Bold);
            picLogo.ForeColor = Color.White;
            picLogo.Location = new Point(25, 15);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(100, 90);
            picLogo.TabIndex = 0;
            picLogo.Text = "P";
            picLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(145, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(296, 46);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registrar Entrada";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(150, 73);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(366, 20);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Inicia a movimentação do veículo no estacionamento.";
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Controls.Add(mskPlacaveiculo);
            grpBuscarVeiculo.Controls.Add(btnBuscarPorPlaca);
            grpBuscarVeiculo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpBuscarVeiculo.ForeColor = Color.FromArgb(15, 65, 125);
            grpBuscarVeiculo.Location = new Point(25, 145);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Size = new Size(934, 110);
            grpBuscarVeiculo.TabIndex = 1;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veículo";
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Segoe UI", 12F);
            lblPlacaVeiculo.ForeColor = Color.Black;
            lblPlacaVeiculo.Location = new Point(25, 48);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(125, 21);
            lblPlacaVeiculo.TabIndex = 0;
            lblPlacaVeiculo.Text = "Placa do Veículo:";
            // 
            // mskPlacaveiculo
            // 
            mskPlacaveiculo.Font = new Font("Segoe UI", 14F);
            mskPlacaveiculo.Location = new Point(195, 43);
            mskPlacaveiculo.Name = "mskPlacaveiculo";
            mskPlacaveiculo.Size = new Size(245, 32);
            mskPlacaveiculo.TabIndex = 1;
            // 
            // btnBuscarPorPlaca
            // 
            btnBuscarPorPlaca.BackColor = Color.FromArgb(15, 95, 170);
            btnBuscarPorPlaca.FlatStyle = FlatStyle.Flat;
            btnBuscarPorPlaca.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBuscarPorPlaca.ForeColor = Color.White;
            btnBuscarPorPlaca.Location = new Point(465, 41);
            btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            btnBuscarPorPlaca.Size = new Size(220, 38);
            btnBuscarPorPlaca.TabIndex = 2;
            btnBuscarPorPlaca.Text = "Buscar por Placa";
            btnBuscarPorPlaca.UseVisualStyleBackColor = false;
            btnBuscarPorPlaca.Click += btnBuscarPorPlaca_Click;
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpDadosVeiculo.ForeColor = Color.FromArgb(15, 65, 125);
            grpDadosVeiculo.Location = new Point(25, 275);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(450, 240);
            grpDadosVeiculo.TabIndex = 2;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veículo";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 11F);
            lblCliente.ForeColor = Color.Black;
            lblCliente.Location = new Point(20, 55);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = Color.FromArgb(235, 239, 245);
            txtNomeCliente.Font = new Font("Segoe UI", 11F);
            txtNomeCliente.Location = new Point(145, 51);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.ReadOnly = true;
            txtNomeCliente.Size = new Size(275, 27);
            txtNomeCliente.TabIndex = 1;
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Segoe UI", 11F);
            lblCorModelo.ForeColor = Color.Black;
            lblCorModelo.Location = new Point(20, 109);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(101, 20);
            lblCorModelo.TabIndex = 3;
            lblCorModelo.Text = "Cor / Modelo:";
            // 
            // txtCorModelo
            // 
            txtCorModelo.BackColor = Color.FromArgb(235, 239, 245);
            txtCorModelo.Font = new Font("Segoe UI", 11F);
            txtCorModelo.Location = new Point(145, 105);
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.ReadOnly = true;
            txtCorModelo.Size = new Size(275, 27);
            txtCorModelo.TabIndex = 4;
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(lblVagaSelecionada);
            grpMovimentacao.Controls.Add(txtVagaSelecionada);
            grpMovimentacao.Controls.Add(lblDataEntrada);
            grpMovimentacao.Controls.Add(dtInfoDtEntrada);
            grpMovimentacao.Controls.Add(lblHoraEntrada);
            grpMovimentacao.Controls.Add(dtInfoHrEntrada);
            grpMovimentacao.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpMovimentacao.ForeColor = Color.FromArgb(15, 65, 125);
            grpMovimentacao.Location = new Point(495, 275);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Size = new Size(464, 240);
            grpMovimentacao.TabIndex = 3;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
            // 
            // lblVagaSelecionada
            // 
            lblVagaSelecionada.AutoSize = true;
            lblVagaSelecionada.Font = new Font("Segoe UI", 11F);
            lblVagaSelecionada.ForeColor = Color.Black;
            lblVagaSelecionada.Location = new Point(20, 55);
            lblVagaSelecionada.Name = "lblVagaSelecionada";
            lblVagaSelecionada.Size = new Size(130, 20);
            lblVagaSelecionada.TabIndex = 0;
            lblVagaSelecionada.Text = "Vaga Selecionada:";
            // 
            // txtVagaSelecionada
            // 
            txtVagaSelecionada.BackColor = Color.FromArgb(235, 239, 245);
            txtVagaSelecionada.Font = new Font("Segoe UI", 11F);
            txtVagaSelecionada.Location = new Point(175, 51);
            txtVagaSelecionada.Name = "txtVagaSelecionada";
            txtVagaSelecionada.ReadOnly = true;
            txtVagaSelecionada.Size = new Size(250, 27);
            txtVagaSelecionada.TabIndex = 1;
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Segoe UI", 11F);
            lblDataEntrada.ForeColor = Color.Black;
            lblDataEntrada.Location = new Point(20, 112);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(120, 20);
            lblDataEntrada.TabIndex = 2;
            lblDataEntrada.Text = "Data de Entrada:";
            // 
            // dtInfoDtEntrada
            // 
            dtInfoDtEntrada.Font = new Font("Segoe UI", 10F);
            dtInfoDtEntrada.Format = DateTimePickerFormat.Short;
            dtInfoDtEntrada.Location = new Point(175, 108);
            dtInfoDtEntrada.Name = "dtInfoDtEntrada";
            dtInfoDtEntrada.Size = new Size(250, 25);
            dtInfoDtEntrada.TabIndex = 3;
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Font = new Font("Segoe UI", 11F);
            lblHoraEntrada.ForeColor = Color.Black;
            lblHoraEntrada.Location = new Point(20, 169);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(121, 20);
            lblHoraEntrada.TabIndex = 4;
            lblHoraEntrada.Text = "Hora de Entrada:";
            // 
            // dtInfoHrEntrada
            // 
            dtInfoHrEntrada.CustomFormat = "HH:mm";
            dtInfoHrEntrada.Font = new Font("Segoe UI", 10F);
            dtInfoHrEntrada.Format = DateTimePickerFormat.Custom;
            dtInfoHrEntrada.Location = new Point(175, 165);
            dtInfoHrEntrada.Name = "dtInfoHrEntrada";
            dtInfoHrEntrada.ShowUpDown = true;
            dtInfoHrEntrada.Size = new Size(140, 25);
            dtInfoHrEntrada.TabIndex = 5;
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.BackColor = Color.FromArgb(30, 140, 75);
            btnRegistrarEntrada.FlatStyle = FlatStyle.Flat;
            btnRegistrarEntrada.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarEntrada.ForeColor = Color.White;
            btnRegistrarEntrada.Location = new Point(565, 550);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(230, 45);
            btnRegistrarEntrada.TabIndex = 4;
            btnRegistrarEntrada.Text = "Registrar Entrada";
            btnRegistrarEntrada.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(230, 232, 236);
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(815, 550);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(144, 45);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmRegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            CancelButton = btnCancelar;
            ClientSize = new Size(984, 621);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarEntrada);
            Controls.Add(grpMovimentacao);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpBuscarVeiculo);
            Controls.Add(pnlCabecalho);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmRegistrarEntrada";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UrbanPark - Registrar Entrada";
            Load += frmRegistrarEntrada_Load;
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label picLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.GroupBox grpBuscarVeiculo;
        private System.Windows.Forms.Label lblPlacaVeiculo;
        private System.Windows.Forms.MaskedTextBox mskPlacaveiculo;
        private System.Windows.Forms.Button btnBuscarPorPlaca;

        private System.Windows.Forms.GroupBox grpDadosVeiculo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblCorModelo;
        private System.Windows.Forms.TextBox txtCorModelo;

        private System.Windows.Forms.GroupBox grpMovimentacao;
        private System.Windows.Forms.Label lblVagaSelecionada;
        private System.Windows.Forms.TextBox txtVagaSelecionada;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.DateTimePicker dtInfoDtEntrada;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtInfoHrEntrada;

        private System.Windows.Forms.Button btnRegistrarEntrada;
        private System.Windows.Forms.Button btnCancelar;
    }
}
