namespace frmUrbanPark.Parts
{
    partial class ctrStatusVagas
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            picStatusVaga = new PictureBox();
            lblNumeroVaga = new Label();
            ((System.ComponentModel.ISupportInitialize)picStatusVaga).BeginInit();
            SuspendLayout();
            // 
            // picStatusVaga
            // 
            picStatusVaga.Image = Properties.Resources.carIconVerde;
            picStatusVaga.Location = new Point(49, 57);
            picStatusVaga.Name = "picStatusVaga";
            picStatusVaga.Size = new Size(50, 50);
            picStatusVaga.TabIndex = 0;
            picStatusVaga.TabStop = false;
            picStatusVaga.Click += picStatusVaga_Click;
            // 
            // lblNumeroVaga
            // 
            lblNumeroVaga.Dock = DockStyle.Top;
            lblNumeroVaga.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroVaga.Location = new Point(0, 0);
            lblNumeroVaga.Name = "lblNumeroVaga";
            lblNumeroVaga.Size = new Size(148, 54);
            lblNumeroVaga.TabIndex = 1;
            lblNumeroVaga.Text = "01";
            lblNumeroVaga.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctrStatusVagas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 247, 231);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblNumeroVaga);
            Controls.Add(picStatusVaga);
            Name = "ctrStatusVagas";
            Size = new Size(148, 118);
            Load += ctrStatusVagas_Load;
            ((System.ComponentModel.ISupportInitialize)picStatusVaga).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picStatusVaga;
        private Label lblNumeroVaga;
    }
}
