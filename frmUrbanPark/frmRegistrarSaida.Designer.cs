
namespace frmUrbanPark
{
    partial class frmRegistrarSaida:Form
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
            txtNomeCliente = new Label();
            lblCorModelo = new Label();
            txtCorModelo = new TextBox();
            lblVaga = new Label();
            txtNumeroVaga = new Label();
            grpMovimentacao = new GroupBox();
            lblDataHoraEntrada = new Label();
            txtDtHoraEntrada = new Label();
            lblDataSaida = new Label();
            dtInfoDtSaida = new DateTimePicker();
            lblHoraSaida = new Label();
            dtInfoHrSaida = new DateTimePicker();
            grpCalculo = new GroupBox();
            lblTempoPermanencia = new Label();
            lblInfoTempoPermanencia = new Label();
            lblTarifaVigente = new Label();
            lblInfoTarifa = new Label();
            lblValorPagar = new Label();
            lblValorAPagar = new Label();
            btnRegistrarSaida = new Button();
            btnCancelar = new Button();
            pnlCabecalho.SuspendLayout();
            grpBuscarVeiculo.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            grpMovimentacao.SuspendLayout();
            grpCalculo.SuspendLayout();
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
            lblTitulo.Size = new Size(259, 46);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registrar Saída";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(150, 73);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(421, 20);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Finaliza a movimentação e calcula o valor do estacionamento.";
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
            grpDadosVeiculo.Controls.Add(lblVaga);
            grpDadosVeiculo.Controls.Add(txtNumeroVaga);
            grpDadosVeiculo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpDadosVeiculo.ForeColor = Color.FromArgb(15, 65, 125);
            grpDadosVeiculo.Location = new Point(25, 275);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(450, 270);
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
            txtNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNomeCliente.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtNomeCliente.ForeColor = Color.Black;
            txtNomeCliente.Location = new Point(145, 48);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(275, 35);
            txtNomeCliente.TabIndex = 1;
            txtNomeCliente.TextAlign = ContentAlignment.MiddleLeft;
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
            // lblVaga
            // 
            lblVaga.AutoSize = true;
            lblVaga.Font = new Font("Segoe UI", 11F);
            lblVaga.ForeColor = Color.Black;
            lblVaga.Location = new Point(20, 162);
            lblVaga.Name = "lblVaga";
            lblVaga.Size = new Size(45, 20);
            lblVaga.TabIndex = 5;
            lblVaga.Text = "Vaga:";
            // 
            // txtNumeroVaga
            // 
            txtNumeroVaga.BackColor = Color.FromArgb(235, 239, 245);
            txtNumeroVaga.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroVaga.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtNumeroVaga.ForeColor = Color.Black;
            txtNumeroVaga.Location = new Point(145, 155);
            txtNumeroVaga.Name = "txtNumeroVaga";
            txtNumeroVaga.Size = new Size(115, 35);
            txtNumeroVaga.TabIndex = 6;
            txtNumeroVaga.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(lblDataHoraEntrada);
            grpMovimentacao.Controls.Add(txtDtHoraEntrada);
            grpMovimentacao.Controls.Add(lblDataSaida);
            grpMovimentacao.Controls.Add(dtInfoDtSaida);
            grpMovimentacao.Controls.Add(lblHoraSaida);
            grpMovimentacao.Controls.Add(dtInfoHrSaida);
            grpMovimentacao.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpMovimentacao.ForeColor = Color.FromArgb(15, 65, 125);
            grpMovimentacao.Location = new Point(495, 275);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Size = new Size(464, 190);
            grpMovimentacao.TabIndex = 3;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
            // 
            // lblDataHoraEntrada
            // 
            lblDataHoraEntrada.AutoSize = true;
            lblDataHoraEntrada.Font = new Font("Segoe UI", 11F);
            lblDataHoraEntrada.ForeColor = Color.Black;
            lblDataHoraEntrada.Location = new Point(20, 55);
            lblDataHoraEntrada.Name = "lblDataHoraEntrada";
            lblDataHoraEntrada.Size = new Size(146, 20);
            lblDataHoraEntrada.TabIndex = 0;
            lblDataHoraEntrada.Text = "Data / Hora Entrada:";
            // 
            // txtDtHoraEntrada
            // 
            txtDtHoraEntrada.BackColor = Color.FromArgb(235, 239, 245);
            txtDtHoraEntrada.BorderStyle = BorderStyle.FixedSingle;
            txtDtHoraEntrada.Font = new Font("Segoe UI", 11F);
            txtDtHoraEntrada.ForeColor = Color.Black;
            txtDtHoraEntrada.Location = new Point(185, 48);
            txtDtHoraEntrada.Name = "txtDtHoraEntrada";
            txtDtHoraEntrada.Size = new Size(250, 35);
            txtDtHoraEntrada.TabIndex = 1;
            txtDtHoraEntrada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDataSaida
            // 
            lblDataSaida.AutoSize = true;
            lblDataSaida.Font = new Font("Segoe UI", 11F);
            lblDataSaida.ForeColor = Color.Black;
            lblDataSaida.Location = new Point(20, 110);
            lblDataSaida.Name = "lblDataSaida";
            lblDataSaida.Size = new Size(106, 20);
            lblDataSaida.TabIndex = 2;
            lblDataSaida.Text = "Data de Saída:";
            // 
            // dtInfoDtSaida
            // 
            dtInfoDtSaida.Font = new Font("Segoe UI", 10F);
            dtInfoDtSaida.Format = DateTimePickerFormat.Short;
            dtInfoDtSaida.Location = new Point(185, 107);
            dtInfoDtSaida.Name = "dtInfoDtSaida";
            dtInfoDtSaida.Size = new Size(250, 25);
            dtInfoDtSaida.TabIndex = 3;
            // 
            // lblHoraSaida
            // 
            lblHoraSaida.AutoSize = true;
            lblHoraSaida.Font = new Font("Segoe UI", 11F);
            lblHoraSaida.ForeColor = Color.Black;
            lblHoraSaida.Location = new Point(20, 150);
            lblHoraSaida.Name = "lblHoraSaida";
            lblHoraSaida.Size = new Size(107, 20);
            lblHoraSaida.TabIndex = 4;
            lblHoraSaida.Text = "Hora de Saída:";
            // 
            // dtInfoHrSaida
            // 
            dtInfoHrSaida.CustomFormat = "HH:mm";
            dtInfoHrSaida.Font = new Font("Segoe UI", 10F);
            dtInfoHrSaida.Format = DateTimePickerFormat.Custom;
            dtInfoHrSaida.Location = new Point(185, 147);
            dtInfoHrSaida.Name = "dtInfoHrSaida";
            dtInfoHrSaida.ShowUpDown = true;
            dtInfoHrSaida.Size = new Size(140, 25);
            dtInfoHrSaida.TabIndex = 5;
            // 
            // grpCalculo
            // 
            grpCalculo.Controls.Add(lblTempoPermanencia);
            grpCalculo.Controls.Add(lblInfoTempoPermanencia);
            grpCalculo.Controls.Add(lblTarifaVigente);
            grpCalculo.Controls.Add(lblInfoTarifa);
            grpCalculo.Controls.Add(lblValorPagar);
            grpCalculo.Controls.Add(lblValorAPagar);
            grpCalculo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpCalculo.ForeColor = Color.FromArgb(15, 65, 125);
            grpCalculo.Location = new Point(495, 480);
            grpCalculo.Name = "grpCalculo";
            grpCalculo.Size = new Size(464, 170);
            grpCalculo.TabIndex = 4;
            grpCalculo.TabStop = false;
            grpCalculo.Text = "Cálculo do Estacionamento";
            // 
            // lblTempoPermanencia
            // 
            lblTempoPermanencia.AutoSize = true;
            lblTempoPermanencia.Font = new Font("Segoe UI", 10F);
            lblTempoPermanencia.ForeColor = Color.Black;
            lblTempoPermanencia.Location = new Point(20, 35);
            lblTempoPermanencia.Name = "lblTempoPermanencia";
            lblTempoPermanencia.Size = new Size(153, 19);
            lblTempoPermanencia.TabIndex = 0;
            lblTempoPermanencia.Text = "Tempo de Permanência:";
            // 
            // lblInfoTempoPermanencia
            // 
            lblInfoTempoPermanencia.BackColor = Color.FromArgb(235, 239, 245);
            lblInfoTempoPermanencia.BorderStyle = BorderStyle.FixedSingle;
            lblInfoTempoPermanencia.Font = new Font("Segoe UI", 10F);
            lblInfoTempoPermanencia.ForeColor = Color.Black;
            lblInfoTempoPermanencia.Location = new Point(205, 30);
            lblInfoTempoPermanencia.Name = "lblInfoTempoPermanencia";
            lblInfoTempoPermanencia.Size = new Size(230, 30);
            lblInfoTempoPermanencia.TabIndex = 1;
            lblInfoTempoPermanencia.Text = "--";
            lblInfoTempoPermanencia.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTarifaVigente
            // 
            lblTarifaVigente.AutoSize = true;
            lblTarifaVigente.Font = new Font("Segoe UI", 10F);
            lblTarifaVigente.ForeColor = Color.Black;
            lblTarifaVigente.Location = new Point(20, 72);
            lblTarifaVigente.Name = "lblTarifaVigente";
            lblTarifaVigente.Size = new Size(94, 19);
            lblTarifaVigente.TabIndex = 2;
            lblTarifaVigente.Text = "Tarifa Vigente:";
            // 
            // lblInfoTarifa
            // 
            lblInfoTarifa.BackColor = Color.FromArgb(235, 239, 245);
            lblInfoTarifa.BorderStyle = BorderStyle.FixedSingle;
            lblInfoTarifa.Font = new Font("Segoe UI", 10F);
            lblInfoTarifa.ForeColor = Color.Black;
            lblInfoTarifa.Location = new Point(205, 67);
            lblInfoTarifa.Name = "lblInfoTarifa";
            lblInfoTarifa.Size = new Size(230, 30);
            lblInfoTarifa.TabIndex = 3;
            lblInfoTarifa.Text = "--";
            lblInfoTarifa.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblValorPagar
            // 
            lblValorPagar.AutoSize = true;
            lblValorPagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValorPagar.ForeColor = Color.Black;
            lblValorPagar.Location = new Point(20, 122);
            lblValorPagar.Name = "lblValorPagar";
            lblValorPagar.Size = new Size(116, 21);
            lblValorPagar.TabIndex = 4;
            lblValorPagar.Text = "Valor a Pagar:";
            // 
            // lblValorAPagar
            // 
            lblValorAPagar.BackColor = Color.FromArgb(210, 240, 215);
            lblValorAPagar.BorderStyle = BorderStyle.FixedSingle;
            lblValorAPagar.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblValorAPagar.ForeColor = Color.FromArgb(15, 90, 35);
            lblValorAPagar.Location = new Point(205, 112);
            lblValorAPagar.Name = "lblValorAPagar";
            lblValorAPagar.Size = new Size(230, 43);
            lblValorAPagar.TabIndex = 5;
            lblValorAPagar.Text = "R$ 0,00";
            lblValorAPagar.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnRegistrarSaida
            // 
            btnRegistrarSaida.BackColor = Color.FromArgb(30, 140, 75);
            btnRegistrarSaida.FlatStyle = FlatStyle.Flat;
            btnRegistrarSaida.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarSaida.ForeColor = Color.White;
            btnRegistrarSaida.Location = new Point(565, 670);
            btnRegistrarSaida.Name = "btnRegistrarSaida";
            btnRegistrarSaida.Size = new Size(230, 45);
            btnRegistrarSaida.TabIndex = 5;
            btnRegistrarSaida.Text = "Registrar Saída";
            btnRegistrarSaida.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(230, 232, 236);
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(815, 670);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(144, 45);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmRegistrarSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            CancelButton = btnCancelar;
            ClientSize = new Size(984, 741);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarSaida);
            Controls.Add(grpCalculo);
            Controls.Add(grpMovimentacao);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpBuscarVeiculo);
            Controls.Add(pnlCabecalho);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmRegistrarSaida";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UrbanPark - Registrar Saída";
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            grpCalculo.ResumeLayout(false);
            grpCalculo.PerformLayout();
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
        private System.Windows.Forms.Label txtNomeCliente;
        private System.Windows.Forms.Label lblCorModelo;
        private System.Windows.Forms.TextBox txtCorModelo;
        private System.Windows.Forms.Label lblVaga;
        private System.Windows.Forms.Label txtNumeroVaga;

        private System.Windows.Forms.GroupBox grpMovimentacao;
        private System.Windows.Forms.Label lblDataHoraEntrada;
        private System.Windows.Forms.Label txtDtHoraEntrada;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.DateTimePicker dtInfoDtSaida;
        private System.Windows.Forms.Label lblHoraSaida;
        private System.Windows.Forms.DateTimePicker dtInfoHrSaida;

        private System.Windows.Forms.GroupBox grpCalculo;
        private System.Windows.Forms.Label lblTempoPermanencia;
        private System.Windows.Forms.Label lblInfoTempoPermanencia;
        private System.Windows.Forms.Label lblTarifaVigente;
        private System.Windows.Forms.Label lblInfoTarifa;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.Label lblValorAPagar;

        private System.Windows.Forms.Button btnRegistrarSaida;
        private System.Windows.Forms.Button btnCancelar;
    }
}
