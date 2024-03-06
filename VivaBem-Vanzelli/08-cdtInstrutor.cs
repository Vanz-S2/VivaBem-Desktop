using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VivaBem_Vanzelli
{
    public partial class _08_cdtInstrutor : Form
    {
        public _08_cdtInstrutor()
        {
            InitializeComponent();
        }
        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmInstrutor().Show();
            Close();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtNome.Enabled = true;
                mtbDataNasc.Focus();
            }
        }

        private void mtbDataNasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mtbDataNasc.Enabled = true;
                txtCargo.Focus();
            }
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCargo.Enabled = true;
                cmbEspecialidade.Focus();
            }
        }

        private void cmbEspecialidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbEspecialidade.Enabled = true;
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Enabled = true;
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Enabled = true;
                cmbNivel.Focus();
            }
        }

        private void cmbNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbNivel.Enabled = true;
                mkbTelefone.Focus();
            }
        }

        private void mkbTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkbTelefone.Enabled = true;
                mtbDataAdmissao.Focus();
            }
        }

        private void mtbDataAdmissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mtbDataAdmissao.Enabled = true;
                cmbStatus.Focus();
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Enabled = true;
                txtFacebook.Focus();
            }
        }

        private void txtFacebook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtFacebook.Enabled = true;
                txtInstagram.Focus();
            }
        }

        private void txtInstagram_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtInstagram.Enabled = true;
                txtLinkedin.Focus();
            }
        }

        private void txtLinkedin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtLinkedin.Enabled = true;
                txtWhats.Focus();
            }
        }


        private void txtWhats_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtWhats.Enabled = true;
                btnSalvar.Focus();
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog ofdFoto = new OpenFileDialog();
                ofdFoto.Multiselect = false;
                ofdFoto.FileName = "";
                ofdFoto.InitialDirectory = @"C:";
                ofdFoto.Title = "Seliciona uma foto";
                ofdFoto.Filter = "JPG ou PNG (*.jpg ou *.png) |*.jpg;*.png";
                ofdFoto.CheckPathExists = true; //Checar se o caminho existe    
                ofdFoto.CheckFileExists = true; //Checar se o arquivo existe 
                ofdFoto.RestoreDirectory = true; //restaurar

                DialogResult dr = ofdFoto.ShowDialog(); //Colocar a foto no pictureBox
                pctInstrutor.Image = Image.FromFile(ofdFoto.FileName);
                variaveis.fotoInstrutor = "funcionario/" + Regex.Replace(txtNome.Text, @"\s", "").ToLower() + Regex.Replace(txtCargo.Text, @"\s", "").ToLower() + ".png";


                if (dr == DialogResult.OK)
                {
                    try
                    {
                        variaveis.atFotoInstrutor = "S";
                        variaveis.caminhoFotoInstrutor = ofdFoto.FileName;
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show("Erro de sengurança - Fale com o Admin. \n Mensagem: " + ex.Message + "\n Detalhe: " + ex.Message + "\n " + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Você não tem permissão. \n Mensagem: " + ex.Message);
                    }
                }
                btnSalvar.Enabled = true;
                btnSalvar.Focus();
            }
            catch
            {
                btnSalvar.Enabled = true;
                btnSalvar.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.FromArgb(242, 183, 5) ;
            lblDataNasc.ForeColor = Color.FromArgb(242, 183, 5);
            lblCargo.ForeColor = Color.FromArgb(242, 183, 5);
            lblEspecialidade.ForeColor = Color.FromArgb(242, 183, 5);
            lblEmail.ForeColor = Color.FromArgb(242, 183, 5);
            lblSenha.ForeColor = Color.FromArgb(242, 183, 5);
            lblNivel.ForeColor = Color.FromArgb(242, 183, 5);
            lblTelefone.ForeColor = Color.FromArgb(242, 183, 5);
            lblDataAdmissao.ForeColor = Color.FromArgb(242, 183, 5);
            lblStatus.ForeColor = Color.FromArgb(242, 183, 5);
            lblFace.ForeColor = Color.FromArgb(242, 183, 5);
            lblInstagram.ForeColor = Color.FromArgb(242, 183, 5);
            lblLinkedin.ForeColor = Color.FromArgb(242, 183, 5);
            lblWhats.ForeColor = Color.FromArgb(242, 183, 5);

            if (txtNome.Text.Length <= 3) //Não aceita menos que 4 caracteres
            {
                MessageBox.Show("Favor colocar o nome completo");
                txtNome.Clear();
                txtNome.Focus();
                lblNome.ForeColor = Color.Red;
            } //Nome
            
            else if (mtbDataNasc.MaskCompleted == false)//Não aceita data incompleta
            {
                MessageBox.Show("Favor colocar data de nascimento completa ");
                mtbDataNasc.Clear();
                mtbDataNasc.Focus();
                lblDataNasc.ForeColor = Color.Red;
            } //Data Nascimeto
            
            else if (txtCargo.Text == "")//Não aceita Texto vazio
            {
                MessageBox.Show("Favor colocar o cargo");
                txtCargo.Clear();
                txtCargo.Focus();
                lblCargo.ForeColor = Color.Red;
            } //Cargo
            
            else if (cmbEspecialidade.Text == "")//Não aceita campo vazio
            {
                MessageBox.Show("Favor selecionar especialidade");
                cmbEspecialidade.SelectedIndex = -1;
                cmbEspecialidade.Focus();
                lblEspecialidade.ForeColor = Color.Red;
            } //Especialidade
           
            else if (txtEmail.Text == "")//Não aceita Texto vazio
            {
                MessageBox.Show("Favor colocar email");
                txtEmail.Clear();
                txtEmail.Focus();
                lblEmail.ForeColor = Color.Red;
            } //Email
            
            else if (txtSenha.Text == "")//Não aceita Texto vazio
            {
                MessageBox.Show("Favor colocar senha");
                txtSenha.Clear();
                txtSenha.Focus();
                lblSenha.ForeColor = Color.Red;
            } //Senha
            
            else if (cmbNivel.Text == "") //Não aceita campo vazio
            {
                MessageBox.Show("Favor selecionar nível");
                cmbNivel.SelectedIndex = -1;
                cmbNivel.Focus();
                lblNivel.ForeColor = Color.Red;
            } //Nível
           
            else if (mkbTelefone.MaskCompleted == false)//Não aceita telefone vazio
            {
                MessageBox.Show("Favor colocar telefone completa ");
                mkbTelefone.Clear();
                mkbTelefone.Focus();
                lblTelefone.ForeColor = Color.Red;
            } //Telefone
           
            else if (mtbDataAdmissao.MaskCompleted == false)//Não aceita data vazia
            {
                MessageBox.Show("Favor colocar data completa ");
                mtbDataAdmissao.Clear();
                mtbDataAdmissao.Focus();
                lblDataAdmissao.ForeColor = Color.Red;
            } //Data Admissão
           
            else if (cmbStatus.Text == "")//Não aceita campo vazio
            {
                MessageBox.Show("Favor selecionar status");
                cmbStatus.SelectedIndex = -1;
                cmbStatus.Focus();
                lblStatus.ForeColor = Color.Red;
            } //Status

            else if (txtFacebook.Text == "")//Não aceita texto vazio
            {
                MessageBox.Show("Favor colocar facebook");
                txtFacebook.Clear();
                txtFacebook.Focus();
                lblFace.ForeColor = Color.Red;
            } //Facebook

            else if (txtInstagram.Text == "")//Não aceita texto vazio
            {
                MessageBox.Show("Favor colocar instagram");
                txtInstagram.Clear();
                txtInstagram.Focus();
                lblInstagram.ForeColor = Color.Red;
            } //Instagram

            else if (txtLinkedin.Text == "")//Não aceita texto vazio
            {
                MessageBox.Show("Favor colocar linkedin");
                txtLinkedin.Clear();
                txtLinkedin.Focus();
                lblLinkedin.ForeColor = Color.Red;
            } //Linkedin

            else if (txtWhats.Text == "")//Não aceita texto vazio
            {
                MessageBox.Show("Favor colocar whats");
                txtWhats.Clear();
                txtWhats.Focus();
                lblWhats.ForeColor = Color.Red;
            } //Whats
            else
            {
                variaveis.nomeInstrutor = txtNome.Text;
                variaveis.altInstrutor = Regex.Replace(txtNome.Text, @"\s", "").ToLower();
                variaveis.dataNascInstrutor = DateTime.Parse(mtbDataNasc.Text);
                variaveis.cargoInstrutor = txtCargo.Text;
                variaveis.especialidadeInstrutor = cmbEspecialidade.Text;
                variaveis.emailInstrutor = txtEmail.Text;
                variaveis.senhaInstrutor = txtSenha.Text;
                variaveis.nivelInstrutor = cmbNivel.Text;
                variaveis.telefoneInstrutor = mkbTelefone.Text;
                variaveis.dataAdmInstrutor = DateTime.Parse(mtbDataAdmissao.Text);
                variaveis.statusInstrutor = cmbStatus.Text;
                variaveis.faceInstrutor = txtFacebook.Text;
                variaveis.instaInstrutor = txtInstagram.Text;
                variaveis.linkedinInstrutor = txtLinkedin.Text;
                variaveis.whatsInstrutor = txtWhats.Text;

                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirFuncionario();
                    btnSalvar.Enabled = false;
                    btnLimpar.PerformClick();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    banco.AlterarFuncionario();
                    if(variaveis.atFotoInstrutor == "S")
                    {
                        banco.AlterarFotoFuncionario();
                    }
                }
                btnLimpar.Enabled = false;
                
            }
        }

        private void _08_cdtInstrutor_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "ALTERAR")
            {
                lblInstrutor.Text = "A\nL\nT\nE\nR\nA\nR";
                banco.CarregarDadosFuncionario();
                txtNome.Text = variaveis.nomeInstrutor;
                mtbDataNasc.Text = variaveis.dataNascInstrutor.ToString();
                txtCargo.Text = variaveis.cargoInstrutor;
                cmbNivel.Text = variaveis.especialidadeInstrutor;
                txtEmail.Text = variaveis.emailInstrutor;
                txtSenha.Text = variaveis.senhaInstrutor;
                cmbNivel.Text = variaveis.nivelInstrutor;
                mkbTelefone.Text = variaveis.telefoneInstrutor;
                mtbDataAdmissao.Text = variaveis.dataAdmInstrutor.ToString();
                cmbStatus.Text = variaveis.statusInstrutor;
                //pctInstrutor.Image = banco.ByteToImage(banco.GetImgToByte(variaveis.enderecoServidorFtp + "funcionario/" + variaveis.fotoInstrutor));
                txtFacebook.Text = variaveis.faceInstrutor;
                txtInstagram.Text = variaveis.instaInstrutor;
                txtLinkedin.Text = variaveis.linkedinInstrutor;
                txtWhats.Text = variaveis.whatsInstrutor;

                txtNome.Enabled = true;
                mtbDataNasc.Enabled = true;
                txtCargo.Enabled = true;
                cmbEspecialidade.Enabled = true;
                cmbNivel.Enabled = true;
                txtEmail.Enabled = true;
                txtSenha.Enabled = true;
                cmbNivel.Enabled = true;
                mkbTelefone.Enabled = true;
                mtbDataAdmissao.Enabled = true;
                cmbStatus.Enabled = true;
                btnFoto.Enabled = true;
                txtFacebook.Enabled = true;
                txtInstagram.Enabled = true;
                txtLinkedin.Enabled = true;
                txtWhats.Enabled = true;
                btnSalvar.Enabled = true;
                btnLimpar.Enabled = false;



            }
        }
    }
}






       
