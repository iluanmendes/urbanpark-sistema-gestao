using backUrbanPark.Model;
using backUrbanPark.Repository;
using frmUrbanPark.Parts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            foreach (Vaga vaga in listaDevagas) {
                
                string strNumeroVaga = vaga.Numero_vaga.ToString();
                StatusVaga statusVaga =  Enum.Parse<StatusVaga>(vaga.TipoStatus.ToString());
                int idVaga = vaga.Id;

                ctrStatusVagas cardVaga = new ctrStatusVagas();

                cardVaga.IdVaga = idVaga;
                cardVaga.StatusVaga = statusVaga;
                cardVaga.NumeroVaga = strNumeroVaga;

                flwCardVagas.Controls.Add(cardVaga);            
            }



        }


    }
}
