using backUrbanPark.Model;
using backUrbanPark.Repository;
using frmUrbanPark.Parts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmUrbanPark
{
    public partial class frmListVagas : Form
    {
        public frmListVagas()
        {
            InitializeComponent();
        }

        private void frmListVagas_Load(object sender, EventArgs e)
        {
            carregarDadosEMontarVisualizacao();
        }

        private void carregarDadosEMontarVisualizacao()
        {

            List<Vaga> listaDevagas = VagaRepository.ListarTodas();

            flwCardVagas.Controls.Clear();

            foreach (Vaga vaga in listaDevagas)
            {

                string strNumeroVaga = vaga.Numero_vaga.ToString();
                StatusVaga statusVaga = Enum.Parse<StatusVaga>(vaga.TipoStatus.ToString());
                int idVaga = vaga.Id;

                ctrStatusVagas cardVaga = new ctrStatusVagas();

                cardVaga.IdVaga = idVaga;
                cardVaga.StatusVaga = statusVaga;
                cardVaga.NumeroVaga = strNumeroVaga;

                cardVaga.CardClicado += cardVaga_click;

                flwCardVagas.Controls.Add(cardVaga);
            }
        }

        public void cardVaga_click(object sender, EventArgs e)
        {
            ctrStatusVagas cardSelecionado = (ctrStatusVagas)sender;

            if (cardSelecionado.StatusVaga == StatusVaga.Livre) {
                
                // Inicializa o formulário de entrada e passa as informações da vaga.
                frmRegistrarEntrada frmEntrada = new frmRegistrarEntrada(
                    cardSelecionado.NumeroVaga,
                    cardSelecionado.IdVaga
                );

                frmEntrada.ShowDialog();

            }else
            {
                frmRegistrarSaida frmSaida = new frmRegistrarSaida();

                frmSaida.ShowDialog();

            }
        }


        private void flwCardVagas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            MessageBox.Show(b.Text);
        }
    }
}
