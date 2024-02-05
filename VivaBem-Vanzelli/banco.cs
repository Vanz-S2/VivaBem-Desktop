using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VivaBem_Vanzelli
{
    public static class banco
    {

        public static DataGridView dgSomaPlanos,dgContato,dgInstrutor;



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



        public static void CarregarInstrutor()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM `tblfuncionarios` ORDER BY nomeFuncionario;";
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


                dgContato.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os innstrutores!\n\n" + erro);
            }
        }

    }



  
}
