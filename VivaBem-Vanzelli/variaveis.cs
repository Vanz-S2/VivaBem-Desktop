using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaBem_Vanzelli
{
    public static class variaveis
    {
            //Geral
            public static int linhaSelecionada;
            public static string funcao;
    
        //FTP
        public static string enderecoServidorFtp = "ftp://127.0.0.1/img/";
        public static string usuarioFtp = "vivabem";
        public static string senhaFtp = "123";


        //Login 
        public static string usuario, senha, nivel;
        

        //Menu
        public static int qtdeInstrutor, qtdeAluno, qtdePlano, qtdeTreino, qtdeMatricula, qtdeExercicio, codContato;

        
        //Geral
        public static double somaGeral, somaPlano;


        //Instrutor
        public static int codInstrutor;
        public static string nomeInstrutor, altInstrutor, cargoInstrutor, especialidadeInstrutor, emailInstrutor, senhaInstrutor, nivelInstrutor, telefoneInstrutor, statusInstrutor, faceInstrutor, instaInstrutor, linkedinInstrutor, whatsInstrutor, fotoInstrutor, atFotoInstrutor, caminhoFotoInstrutor;
        public static DateTime dataNascInstrutor, dataAdmInstrutor;
        
    }
}
