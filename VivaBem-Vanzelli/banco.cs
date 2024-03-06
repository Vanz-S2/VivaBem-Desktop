using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VivaBem_Vanzelli
{
    public static class banco
    {

        public static DataGridView dgSomaPlanos,dgContato,dgInstrutor;

        //--------------------------------FOTOS----------------------------

        //Validação de FTP
        private static bool ValidarFTP()
        {
            if (string.IsNullOrEmpty(variaveis.enderecoServidorFtp) || string.IsNullOrEmpty(variaveis.usuarioFtp) || string.IsNullOrEmpty(variaveis.senhaFtp))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //Converter a Imagem em byte
        public static byte[] GetImgToByte(string caminhoArquivoFtp)
        {
            WebClient ftpclient = new WebClient();
            ftpclient.Credentials = new NetworkCredential(variaveis.usuarioFtp, variaveis.senhaFtp);
            byte[] imageToByte = ftpclient.DownloadData(caminhoArquivoFtp);
            return imageToByte;
        }

        //Converter a Imagem de byte para IMG
        public static Bitmap ByToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        //--------------------------------FOTOS----------------------------



        //Instrutor
        public static void CarregarQtdeInstrutor()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT SUM(qtdeFuncionario) FROM vnumfuncespecativo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.qtdeInstrutor = reader.GetInt32(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a qtde de instrutores!\n\n" + erro);
            }


        }


        //Aluno
        public static void CarregarQtdeAluno()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM vnumalunosativos;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.qtdeAluno = reader.GetInt32(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a qtde de alunos!\n\n" + erro);
            }


        }

        //Plano
        public static void CarregarQtdePlano()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM `vnumplanoativo`;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.qtdePlano = reader.GetInt32(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a qtde de planos!\n\n" + erro);
            }


        }

        //Treino
        public static void CarregarQtdeTreino()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM `vnumtreinoativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.qtdeTreino = reader.GetInt32(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a qtde de treinos!\n\n" + erro);
            }


        }

        //Matricula
        public static void CarregarQtdeMatricula()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM `vnummatriculaativa`";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.qtdeMatricula = reader.GetInt32(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a qtde de matriculas!\n\n" + erro);
            }


        }

        //Exercicio
        public static void CarregarQtdeExercicio()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT SUM(qtdeExercicio) FROM vnumexercicoativo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.qtdeExercicio = reader.GetInt32(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a qtde de exercicios!\n\n" + erro);
            }


        }

        //Valor Geral
        public static void CarregarValorGeral()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM vsomavalores";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.somaGeral = reader.GetDouble(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a soma de valores gerais!\n\n" + erro);
            }
        }

        //Soma Plano
        public static void CarregarsomaPlanos()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM vsomavaloresporplano";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgSomaPlanos.DataSource = dt;
                dgSomaPlanos.Columns[1].DefaultCellStyle.Format = "C2";

                dgSomaPlanos.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a soma de valores dos planos!\n\n" + erro);
            }
        }

        //Contato
        public static void CarregarContato()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblcontato WHERE statusContato <> 'RESPONDIDO'";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgContato.DataSource = dt;
                dgContato.Columns[0].Visible = false;
                dgContato.Columns[1].HeaderText = "Nome";
                dgContato.Columns[2].HeaderText = "E-mail";
                dgContato.Columns[3].HeaderText = "Telefone";
                dgContato.Columns[4].HeaderText = "Mensagem";
                dgContato.Columns[5].Visible = false;
                dgContato.Columns[6].Visible = false;
                dgContato.Columns[7].Visible = false;


                dgContato.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os e-mails!\n\n" + erro);
            }
        }

        //Status Email
        public static void AlterarStatusEmail()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblcontato SET statusContato='RESPONDIDO' WHERE idContato=" + variaveis.codContato;
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgContato.DataSource = dt;



                dgContato.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Instrutores!\n\n" + erro);
            }
        }

        //Instrutor
        public static void CarregarInstrutor()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblfuncionarios ORDER BY nomeFuncionario AND statusFuncionario = 'ATIVO';";//Like '%Ana%' '%"+variaveis.nomeInstrutor+"%'
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgInstrutor.DataSource = dt;
                dgInstrutor.Columns[0].Visible = false; //ID
                dgInstrutor.Columns[1].HeaderText = "Nome";
                dgInstrutor.Columns[2].Visible = false; //ALT
                dgInstrutor.Columns[3].HeaderText = "Data Nascimento";
                dgInstrutor.Columns[4].HeaderText = "Cargo Funcionário";
                dgInstrutor.Columns[5].HeaderText = "Especialidade Funcionário";
                dgInstrutor.Columns[6].HeaderText = "E-mail";
                dgInstrutor.Columns[7].Visible = false; //Senha
                dgInstrutor.Columns[8].HeaderText = "Nível";
                dgInstrutor.Columns[9].HeaderText = "Telefone";
                dgInstrutor.Columns[10].HeaderText = "Data Admissâo";
                dgInstrutor.Columns[11].HeaderText = "Status";
                dgInstrutor.Columns[12].Visible = false; //Foto
                dgInstrutor.Columns[13].Visible = false; //Link Face
                dgInstrutor.Columns[14].Visible = false; //Link Insta
                dgInstrutor.Columns[15].Visible = false; //Link Linkedin
                dgInstrutor.Columns[16].Visible = false; //Link Whats


                dgInstrutor.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os instrutores!\n\n" + erro);
            }
        }


        public static void CarregarInstrutorNome()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM `tblfuncionarios` WHERE nomeFuncionario Like '%"+variaveis.nomeInstrutor+"%' ORDER BY nomeFuncionario;";//Like '%Ana%' '%"+variaveis.nomeInstrutor+"%'
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgInstrutor.DataSource = dt;
                dgInstrutor.Columns[0].Visible = false; //ID
                dgInstrutor.Columns[1].HeaderText = "Nome";
                dgInstrutor.Columns[2].Visible = false; //ALT
                dgInstrutor.Columns[3].HeaderText = "Data Nascimento";
                dgInstrutor.Columns[4].HeaderText = "Cargo Funcionário";
                dgInstrutor.Columns[5].HeaderText = "Especialidade Funcionário";
                dgInstrutor.Columns[6].HeaderText = "E-mail";
                dgInstrutor.Columns[7].Visible = false; //Senha
                dgInstrutor.Columns[8].HeaderText = "Nível";
                dgInstrutor.Columns[9].HeaderText = "Telefone";
                dgInstrutor.Columns[10].HeaderText = "Data Admissâo";
                dgInstrutor.Columns[11].HeaderText = "Status";
                dgInstrutor.Columns[12].Visible = false; //Foto
                dgInstrutor.Columns[13].Visible = false; //Link Face
                dgInstrutor.Columns[14].Visible = false; //Link Insta
                dgInstrutor.Columns[15].Visible = false; //Link Linkedin
                dgInstrutor.Columns[16].Visible = false; //Link Whats


                dgInstrutor.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os innstrutores!\n\n" + erro);
            }
        }


        public static void CarregarInstrutorStatus()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM `tblfuncionarios`  WHERE statusFuncionario = 'ATIVO' ORDER BY nomeFuncionario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgInstrutor.DataSource = dt;
                dgInstrutor.Columns[0].Visible = false; //ID
                dgInstrutor.Columns[1].HeaderText = "Nome";
                dgInstrutor.Columns[2].Visible = false; //ALT
                dgInstrutor.Columns[3].HeaderText = "Data Nascimento";
                dgInstrutor.Columns[4].HeaderText = "Cargo Funcionário";
                dgInstrutor.Columns[5].HeaderText = "Especialidade Funcionário";
                dgInstrutor.Columns[6].HeaderText = "E-mail";
                dgInstrutor.Columns[7].Visible = false; //Senha
                dgInstrutor.Columns[8].HeaderText = "Nível";
                dgInstrutor.Columns[9].HeaderText = "Telefone";
                dgInstrutor.Columns[10].HeaderText = "Data Admissâo";
                dgInstrutor.Columns[11].HeaderText = "Status";
                dgInstrutor.Columns[12].Visible = false; //Foto
                dgInstrutor.Columns[13].Visible = false; //Link Face
                dgInstrutor.Columns[14].Visible = false; //Link Insta
                dgInstrutor.Columns[15].Visible = false; //Link Linkedin
                dgInstrutor.Columns[16].Visible = false; //Link Whats


                dgInstrutor.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os innstrutores!\n\n" + erro);
            }
        }


        public static void InserirFuncionario()
        {
            try
            {
                conexao.Conectar();
                string inserir = "INSERT INTO tblfuncionarios(nomeFuncionario, altFuncionario, dataNascFuncionario, cargoFuncionario, especialidadeFuncionario, emailFuncionario, senhaFuncionario, nivelFuncionario, telefoneFuncionario, dataAdmissaoFuncionario, statusFuncionario, linkFaceFuncionario, linkInstaFuncionario, linkLinkedinFuncionario, linkWhatsFuncionario, fotoFuncionario) VALUES (@nome,@alt,@dataNas,@cargo,@especialidade,@email,@senha,@nivel,@telefone,@dataAdmiss,@status,@face,@insta,@linkedin,@whats,@foto);";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);
                //parametros
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeInstrutor);
                cmd.Parameters.AddWithValue("@alt", variaveis.altInstrutor);
                cmd.Parameters.AddWithValue("@dataNas", variaveis.dataNascInstrutor);
                cmd.Parameters.AddWithValue("@cargo", variaveis.cargoInstrutor);
                cmd.Parameters.AddWithValue("@especialidade", variaveis.especialidadeInstrutor);
                cmd.Parameters.AddWithValue("@email", variaveis.emailInstrutor);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhaInstrutor);
                cmd.Parameters.AddWithValue("@nivel", variaveis.nivelInstrutor);
                cmd.Parameters.AddWithValue("@dataAdmiss", variaveis.dataAdmInstrutor);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefoneInstrutor);
                cmd.Parameters.AddWithValue("@status", variaveis.statusInstrutor);
                cmd.Parameters.AddWithValue("@face", variaveis.faceInstrutor);
                cmd.Parameters.AddWithValue("@insta", variaveis.instaInstrutor);
                cmd.Parameters.AddWithValue("@linkedin", variaveis.linkedinInstrutor);
                cmd.Parameters.AddWithValue("@whats", variaveis.whatsInstrutor);
                cmd.Parameters.AddWithValue("@foto", variaveis.fotoInstrutor);

                //cmd parametros

                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario cadastro com sucesso!", "CADASTRO FUNCIONÁRIO");
                conexao.Desconectar();

                //Inserir a foto na ftp
                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotoInstrutor))
                    {
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "funcionario/" + Path.GetFileName(variaveis.fotoInstrutor);

                        try
                        {
                            ftp.EnviarArquivoFtp(variaveis.caminhoFotoInstrutor, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                        }
                        catch
                        {
                            MessageBox.Show("Foto não selecionada ou não existente.", "FOTO");
                        }
                    }
                }


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastra funcionario!\n\n" + erro.Message, "ERRO");
            }


           
        }


        public static void CarregarDadosFuncionario()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblfuncionarios WHERE idFuncionario = @codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                cmd.Parameters.AddWithValue("codigo", variaveis.codInstrutor);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.nomeInstrutor = reader.GetString(1);
                    variaveis.dataNascInstrutor = reader.GetDateTime(3);
                    variaveis.cargoInstrutor = reader.GetString(4);
                    variaveis.especialidadeInstrutor = reader.GetString(5);
                    variaveis.emailInstrutor = reader.GetString(6);
                    variaveis.senhaInstrutor = reader.GetString(7);
                    variaveis.nivelInstrutor = reader.GetString(8);
                    variaveis.telefoneInstrutor = reader.GetString(9);
                    variaveis.dataAdmInstrutor = reader.GetDateTime(10);
                    variaveis.statusInstrutor = reader.GetString(11);
                    variaveis.fotoInstrutor = reader.GetString(12);
                    variaveis.fotoInstrutor = variaveis.fotoInstrutor.Remove(0, 12);
                    variaveis.faceInstrutor = reader.GetString(13);
                    variaveis.instaInstrutor = reader.GetString(14);
                    variaveis.linkedinInstrutor = reader.GetString(15);
                    variaveis.whatsInstrutor = reader.GetString(16);

                }
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Eroo ao carregar os dados do funcionários!\n\n" + erro);
            }
        }

        internal static Image ByteToImage(byte[] bytes)
        {
            throw new NotImplementedException();
        }


        public static void AlterarFuncionario()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblfuncionarios SET nomeFuncionario=@nome,altFuncionario=@alt,dataNascFuncionario=@dataNas,cargoFuncionario=@cargo,especialidadeFuncionario=@especialidade,emailFuncionario=@email,senhaFuncionario=@senha,nivelFuncionario=@nivel,telefoneFuncionario=@telefone,dataAdmissaoFuncionario=@dataAdmiss,statusFuncionario=@status,linkFaceFuncionario=@face,linkInstaFuncionario=@insta,linkLinkedinFuncionario=@linkedin,linkWhatsFuncionario=@whats WHERE idFuncionario=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                //parametros
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeInstrutor);
                cmd.Parameters.AddWithValue("@alt", variaveis.altInstrutor);
                cmd.Parameters.AddWithValue("@dataNas", variaveis.dataNascInstrutor);
                cmd.Parameters.AddWithValue("@cargo", variaveis.cargoInstrutor);
                cmd.Parameters.AddWithValue("@especialidade", variaveis.especialidadeInstrutor);
                cmd.Parameters.AddWithValue("@email", variaveis.emailInstrutor);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhaInstrutor);
                cmd.Parameters.AddWithValue("@nivel", variaveis.nivelInstrutor);
                cmd.Parameters.AddWithValue("@dataAdmiss", variaveis.dataAdmInstrutor);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefoneInstrutor);
                cmd.Parameters.AddWithValue("@status", variaveis.statusInstrutor);
                cmd.Parameters.AddWithValue("@face", variaveis.faceInstrutor);
                cmd.Parameters.AddWithValue("@insta", variaveis.instaInstrutor);
                cmd.Parameters.AddWithValue("@linkedin", variaveis.linkedinInstrutor);
                cmd.Parameters.AddWithValue("@whats", variaveis.whatsInstrutor);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codInstrutor);

                //cmd parametros

                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario alterado com sucesso!", "ALTERAÇÃO DO FUNCIONÁRIO");
                conexao.Desconectar();

        
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar funcionario!\n\n" + erro.Message, "ERRO");
            }
        }


        public static void AlterarFotoFuncionario()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblfuncionarios SET fotoFuncionario=@foto WHERE idFuncionario=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                //parametros
                cmd.Parameters.AddWithValue("@foto", variaveis.fotoInstrutor);
                
                cmd.Parameters.AddWithValue("@codigo", variaveis.codInstrutor);

                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                //Inserir a foto na ftp
                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotoInstrutor))
                    {
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "funcionario/" + Path.GetFileName(variaveis.fotoInstrutor);

                        try
                        {
                            ftp.EnviarArquivoFtp(variaveis.caminhoFotoInstrutor, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Foto não selecionada ou não existente.", "FOTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar funcionario!\n\n" + erro.Message, "ERRO");
            }



        }


        public static void DesativarFuncionario()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblfuncionarios SET statusFuncionario= 'DESATIVADO' WHERE idFuncionario=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                cmd.Parameters.AddWithValue("@status", variaveis.statusInstrutor);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codInstrutor);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario desativado com sucesso!", "EXCLUIR DO FUNCIONÁRIO");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao desativar funcionario!\n\n" + erro.Message, "ERRO");
            }
        }







    }



  
}
