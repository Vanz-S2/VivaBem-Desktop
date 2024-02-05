using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VivaBem_Vanzelli
{
    public partial class frmInstrutor : Form
    {
        public frmInstrutor()
        {
            InitializeComponent();
        }

        private void lblInstrutor_Click(object sender, EventArgs e)
        {

        }

        private void pnlInstrutor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void dgvInstrutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void frmInstrutor_Load(object sender, EventArgs e)
        {
            banco.dgInstrutor = dgvInstrutor;
            banco.CarregarInstrutor();  
        }
    }
}
