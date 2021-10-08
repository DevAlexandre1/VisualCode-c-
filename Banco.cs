using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace NewAtividades
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = C:\\Users\\administrador\\source\\repos\\NewAtividades\\NewAtividades\\Banco\\Banco_Atividades.db");
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                 cmd.CommandText = "SELECT * from tb_usuarios";
                 da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                 da.Fill(dt);
                 vcon.Close();
                 return dt;
             
            }catch(Exception ex)
            {
                 throw ex;
            }
        }
        public static DataTable consulta(String sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Funções de gestão de usuários
        public static DataTable ObterUsuariosIDNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT IDUSUARIO as 'ID do Usuário', USERNAME as 'Nome Usuário', NIVELACESSO as 'Nivel', USERSTATUS as 'Situação'  from tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Preenchendo dados do usuario da ficha ao selecionar o usuario
        public static DataTable ObterdadosUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT *  from tb_usuarios WHERE IDUSUARIO ="+id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        //Fim gestão de usuários


        //Funcoes de adição usuario

        public static void novousuario(Usuario u)
        {
            if(existeeamilbanco(u))
            {
                MessageBox.Show("Email já cadastrado");
                return;

            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios(IDUSUARIO,USERNAME,USERSENHA,USEREMAIL,USERDEPARTAMENTO,USERSTATUS,NIVELACESSO ) VALUES (@idusuario,@nome,@senha,@email,@departamento,@status,@nivel) ";
                cmd.Parameters.AddWithValue("@idusuario", u.IDUSUARIO);
                cmd.Parameters.AddWithValue("@nome", u.USERNAME);
                cmd.Parameters.AddWithValue("@senha", u.USERSENHA);
                cmd.Parameters.AddWithValue("@email", u.USEREMAIL);
                cmd.Parameters.AddWithValue("@departamento", u.USERDEPARTAMENTO);
                cmd.Parameters.AddWithValue("@status", u.USERSTATUS);
                cmd.Parameters.AddWithValue("@nivel", u.USERNIVEL);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado!");
                vcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuário");
           

            }
            
        }

        //Fim adição de usuario


        //Funções de adicão de atividade
        //Atividade 01
        public static void novaatividade(Atividade a)
        {
            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "INSERT INTO Atividades(DATAATIVIDADES,USERATIVIDADE,EMPRESANOME,TAREFANOME,COMPETENCIA,COMENTARIO,HORAINICIO,HORAFINAL,TEMPOATIVIDADE) VALUES(@dataatividade,@user,@empresa,@tarefa,@competencia,@comentario,@horaini,@horafim,@tempoatividade)";
            cmd.Parameters.AddWithValue("dataatividade", a.DATAATIVIDADES);
            cmd.Parameters.AddWithValue("user", a.USERATIVIDADES);
            cmd.Parameters.AddWithValue("empresa", a.EMPRESANOME);
            cmd.Parameters.AddWithValue("tarefa", a.TAREFANOME);
            cmd.Parameters.AddWithValue("competencia", a.COMPETENCIA);
            cmd.Parameters.AddWithValue("comentario", a.COMENTARIO);
            cmd.Parameters.AddWithValue("horaini", a.HORAINICIO);
            cmd.Parameters.AddWithValue("horafim", a.HORAFINAL);
            cmd.Parameters.AddWithValue("tempoatividade", a.TEMPOATIVIDADE);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Atividade registrada!");
            vcon.Close();

         }
        //Atividade 02
        public static void novaatividade2(Atividade b)
        {
            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "INSERT INTO Atividades(DATAATIVIDADES,USERATIVIDADE,EMPRESANOME,TAREFANOME,COMPETENCIA,COMENTARIO,HORAINICIO,HORAFINAL,TEMPOATIVIDADE) VALUES(@dataatividade,@user,@empresa,@tarefa,@competencia,@comentario,@horaini,@horafim,@tempoatividade)";
            cmd.Parameters.AddWithValue("dataatividade", b.DATAATIVIDADES2);
            cmd.Parameters.AddWithValue("user", b.USERATIVIDADES2);
            cmd.Parameters.AddWithValue("empresa", b.EMPRESANOME2);
            cmd.Parameters.AddWithValue("tarefa", b.TAREFANOME2);
            cmd.Parameters.AddWithValue("competencia", b.COMPETENCIA2);
            cmd.Parameters.AddWithValue("comentario", b.COMENTARIO2);
            cmd.Parameters.AddWithValue("horaini", b.HORAINICIO2);
            cmd.Parameters.AddWithValue("horafim", b.HORAFINAL2);
            cmd.Parameters.AddWithValue("tempoatividade", b.TEMPOATIVIDADE2);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Atividade registrada!");
            vcon.Close();

        }
        //Atividade 03
        public static void novaatividade3(Atividade c)
        {
            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "INSERT INTO Atividades(DATAATIVIDADES,USERATIVIDADE,EMPRESANOME,TAREFANOME,COMPETENCIA,COMENTARIO,HORAINICIO,HORAFINAL,TEMPOATIVIDADE) VALUES(@dataatividade,@user,@empresa,@tarefa,@competencia,@comentario,@horaini,@horafim,@tempoatividade)";
            cmd.Parameters.AddWithValue("dataatividade", c.DATAATIVIDADES3);
            cmd.Parameters.AddWithValue("user", c.USERATIVIDADES3);
            cmd.Parameters.AddWithValue("empresa", c.EMPRESANOME3);
            cmd.Parameters.AddWithValue("tarefa", c.TAREFANOME3);
            cmd.Parameters.AddWithValue("competencia", c.COMPETENCIA3);
            cmd.Parameters.AddWithValue("comentario", c.COMENTARIO3);
            cmd.Parameters.AddWithValue("horaini", c.HORAINICIO3);
            cmd.Parameters.AddWithValue("horafim", c.HORAFINAL3);
            cmd.Parameters.AddWithValue("tempoatividade", c.TEMPOATIVIDADE3);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Atividade registrada!");
            vcon.Close();



            //Fim de adição de atividades
        }

            //Rotinas gerais
            public static bool existeeamilbanco(Usuario u)
       {
       bool res;
       SQLiteDataAdapter da = null;
       DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
       cmd.CommandText = "Select USEREMAIL from tb_usuarios WHERE USEREMAIL='"+u.USEREMAIL+"'";
       da = new SQLiteDataAdapter(cmd.CommandText, vcon);
       da.Fill(dt);
       if(dt.Rows.Count > 0)
       {
         res = true;
        }
        else
        {
         res = false;
        }
        vcon.Close();
        return res;
        }


    }
}
