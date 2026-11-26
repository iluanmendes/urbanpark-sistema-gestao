using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmUrbanPark.Parts
{
    public enum StatusVaga {Livre, Ocupada}

    public partial class ctrStatusVagas : UserControl
    {
        private StatusVaga _statusVaga;
        private string _numeroVaga;
        private int _idVaga;

        // Evento púlico com assinatura de delegado EventHandler,
        // que será disparado quando o card for clicado
        // (object Sender, EventArgs e)
        public event EventHandler CardClicado;


        private Color _verdeClaro = Color.FromArgb(223, 247, 231);
        private Color _vermelhoClaro = Color.FromArgb(254, 224, 221);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public StatusVaga StatusVaga { get => _statusVaga; set => _statusVaga = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NumeroVaga { get => _numeroVaga; set => _numeroVaga = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdVaga { get => _idVaga; set => _idVaga = value; }

        public ctrStatusVagas()
        {
            InitializeComponent();

            // =================================================================
            // 2. INSCRIÇÃO NOS EVENTOS INTERNOS (+=)
            // No Windows Forms, clicar em um Label ou PictureBox dentro de um
            // UserControl NÃO dispara o Click do UserControl automaticamente.
            // Por isso, conectamos o Click do fundo, do texto e da imagem
            // ao mesmo método (AoClicarNoCard), garantindo que o card inteiro
            // seja clicável.
            // =================================================================
            this.Click += AoClicarNoCard;
            this.lblNumeroVaga.Click += AoClicarNoCard;
            this.picStatusVaga.Click += AoClicarNoCard;
        }

        private void AoClicarNoCard(object sender, EventArgs e)
        {
            // Dispara o evento CardClicado, se houver algum inscrito
            CardClicado?.Invoke(this, EventArgs.Empty);
        }


        private void ctrStatusVagas_Load(object sender, EventArgs e)
        {
            atualizarAparenciaCard();            
        }

        private void atualizarAparenciaCard()
        {
            this.lblNumeroVaga.Text = this.NumeroVaga;

            if (this.StatusVaga == StatusVaga.Livre)
            {
                this.BackColor = _verdeClaro;
                this.picStatusVaga.Image = Properties.Resources.carIconVerde;
            }
            else { 
                
                this.BackColor = _vermelhoClaro;
                this.picStatusVaga.Image = Properties.Resources.carIconVermlho;           

            }

        }

        private void picStatusVaga_Click(object sender, EventArgs e)
        {

        }


       
    }
}
