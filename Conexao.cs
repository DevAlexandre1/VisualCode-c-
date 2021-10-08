using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;



namespace NewAtividades
{
    class Conexao
    {
        //RESPONSAVEL PELA CONEXAO COM O BANCO
        //public static MySqlConnection conec;
        //FUNÇÃO RESPONSAVEL PELA INSTRUIÇÕES A SEREM EXECUTADAS
        //public static MySqlCommand comando;
        //ADAPTADOR RESPONSAVEL POR INSERIR DADOS EM UMA TABELA
        //public static MySqlDataAdapter adaptador;
        //RESPONSAVEL POR LIGAR O BANCO EM CONTROLES COM A PROPRIEDADE DATASOURCE
        //public static DataTable datTabela;

        //Conexao de banco de dados Local
        string conectar = ("server=localhost; database=controleatividades;uid=root;pwd=;");
        public SqlConnection con = null;
        
        public void AbrirConectar()
        {
            /*Estabelece os parametros para a conexao com o banco de dados
            conec = new MySqlConnection("server=localhost;database=controleatividades; uid=root;pwd=");

            try
            {
                conec.Open();
                System.Windows.Forms.MessageBox.Show("Banco de dados conectado com sucesso!");
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro de conexao banco de dados");
                throw ex;
            }
        }*/     
           try
            {
                con = new SqlConnection(conectar);
                con.Open();
                System.Windows.Forms.MessageBox.Show("Banco de dados conectado com sucesso!");
                con.Close();


            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro de conexao banco de dados");
                throw ex;
            }

        }
        public void FecharConectar()
        {
                try
                {
                    con = new SqlConnection(conectar);
                    con.Close();
                }

                catch (Exception ex)
                {

                    throw ex;
                }

        }
        //Declaracoes de outras variáveis GLOBAIS
       
    }
}
