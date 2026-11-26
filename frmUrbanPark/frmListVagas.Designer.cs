namespace frmUrbanPark
{
    partial class frmListVagas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flwCardVagas = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // flwCardVagas
            // 
            flwCardVagas.Dock = DockStyle.Bottom;
            flwCardVagas.Location = new Point(0, 42);
            flwCardVagas.Margin = new Padding(5);
            flwCardVagas.Name = "flwCardVagas";
            flwCardVagas.Padding = new Padding(15);
            flwCardVagas.Size = new Size(800, 450);
            flwCardVagas.TabIndex = 0;
            flwCardVagas.Paint += flwCardVagas_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(45, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseHover += button1_MouseHover;
            // 
            // frmListVagas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(button1);
            Controls.Add(flwCardVagas);
            Name = "frmListVagas";
            Text = "frmListVagas";
            Load += frmListVagas_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flwCardVagas;
        private Button button1;
    }
}