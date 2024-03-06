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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            lblUsuario.Text = variaveis.usuario;
            lblData.Text = DateTime.Now.ToString();
            timer1.Start();
            
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNoCancel);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resposta == DialogResult.No)
            {
                new frmLogin().Show();
                Close();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            banco.CarregarQtdeInstrutor();
            lblNumInstrutores.Text = variaveis.qtdeInstrutor.ToString();

            banco.CarregarQtdeAluno();
            lblNumAlunos.Text = variaveis.qtdeAluno.ToString();

            banco.CarregarQtdePlano();
            lblNumPlanos.Text = variaveis.qtdePlano.ToString();

            banco.CarregarQtdeTreino();
            lblNumTreinos.Text = variaveis.qtdeTreino.ToString();

            banco.CarregarQtdeMatricula();
            lblNumMarticulas.Text = variaveis.qtdeMatricula.ToString();

            banco.CarregarQtdeExercicio();
            lblNumExercicios.Text = variaveis.qtdeExercicio.ToString();

            banco.CarregarValorGeral();
            lblvalorGeral.Text = variaveis.somaGeral.ToString("N2"); //N2 para as duas casas decimas.

            banco.dgSomaPlanos = dgvValorPlanos;
            banco.CarregarsomaPlanos();

            banco.dgContato = dgvContato;
            banco.CarregarContato();
        }


        private void dgvValorPlanos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Analisar qual coluna estamos formatando e se ela esta com informação
            if (e.ColumnIndex == 0 && e.Value != null)
            {
                // Verificar se no registro existe a palavra "PLANO"
                string valor = e.Value.ToString();
                if (valor.Contains("Plano"))
                {
                    //Remover a palavra 'PLANO ' e o espaço do valor
                    valor = valor.Replace("Plano ", "");

                    //Definir o valor da variaveis na célula da Grid
                    e.Value = valor;

                    //Entender que a célula foi formatada
                    e.FormattingApplied = true;
                }
            }
            //Analisar se existe pelo menos 1 coluna
            if (e.ColumnIndex >= 0)
            {
                //Analisar se a linha é par ou ímpar
                if (e.RowIndex % 2 == 1)
                {
                    e.CellStyle.BackColor = Color.FromArgb(34, 68, 89); //Azul
                    e.CellStyle.ForeColor = Color.FromArgb(242, 183, 5); //Amarelo
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(34, 68, 89); //Azul
                    e.CellStyle.BackColor = Color.FromArgb(242, 183, 5); //Amarelo
                }
            }
        }

        private void dgvContato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvContato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var resposta = MessageBox.Show("O E-MAIL foi RESPONDIDO?", "E-MAIL", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                //PRECISO SABER QUAL LINHA FOI SELECIONADA.
                variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
                if (variaveis.linhaSelecionada >= 0)
                {
                    variaveis.codContato = Convert.ToInt32(dgvContato[0, variaveis.linhaSelecionada].Value);
                    banco.AlterarStatusEmail();
                    banco.dgContato = dgvContato;
                    banco.CarregarContato();
                }
            }
        }

        private void btnInstrutor_Click(object sender, EventArgs e)
        {
            new frmInstrutor().Show();
            Hide();
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
