using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewAtividades
{
    
    public partial class Atividades : Form
    {

        int relogio1;
        int relogio2;
        int relogio3;
        DateTime timerini;
        DateTime timerini1;
        DateTime timerini2;

        DateTime timerfinal;
        DateTime timerfinal2;
        DateTime timerfinal3;

       
        Conexao ConecGeral = new Conexao();
        String sql;
        SqlCommand cmd;
        

        public Atividades()
        {
            InitializeComponent();
            txtusername.Text = Globais.username;

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menuprincipal form1 = new Menuprincipal();
            {
                form1.Show();
                this.Close();
            }
        }

      

        //BOTAO PARAR TAREFA 1
        private void botfinalizaratividade_Click(object sender, EventArgs e)
        {
            if(txthorainicio.Text == "")
            {
                MessageBox.Show("Nenhuma atividade iniciada");
            }
            else
            {
                timerfinal = DateTime.Now;
                timeratividade1.Stop();
                txthorafinal.Text = timerfinal.ToString();
            }

           
                                

        }
        //BOTAO PARAR TAREFA 2
        private void botfinalizaratividade2_Click(object sender, EventArgs e)
        {
            if (txthorainicio2.Text == "")
            {
                MessageBox.Show("Nenhuma atividade iniciada");
            }
            else
            {
                timerfinal2 = DateTime.Now;
                timeratividade2.Stop();
                txthorafinal2.Text = timerfinal2.ToString();
            }

           

        }
        //BOTAO PARAR TAREFA 3
        private void botfinalizaratividade3_Click(object sender, EventArgs e)
        {
            if (txthorainicio3.Text == "")
            {
                MessageBox.Show("Nenhuma atividade iniciada");
            }
            else
            {
                timerfinal3 = DateTime.Now;
                timeratividade3.Stop();
                txthorafinal3.Text = timerfinal3.ToString();
            }
        }

        private void Atividades_Load(object sender, EventArgs e)
        {
            relogio1 = 0;
            relogio2 = 0;
            relogio3 = 0;

        }

        private void Botiniciaratividade_Click(object sender, EventArgs e)
        {
            if (Empresa1.Text == "" || Tarefa1.Text == "" || Comp1.Text == "")                 
            {

                MessageBox.Show("Impossível Iniciar, verificar campos vazios");
            }
            else
            {
                

                timerini = DateTime.Now;
                timeratividade1.Start();
                txthorainicio.Text = timerini.ToString();
                txtdata.Text = timerini.ToString();



            }
        }

        private void Botiniciaratividade2_Click(object sender, EventArgs e)
        {

            if (Empresa2.Text == "" || Tarefa2.Text == "" || Comp2.Text == "")
            {

                MessageBox.Show("Impossível Iniciar, verificar campos vazios");
            }
            else
            {
                timerini1 = DateTime.Now;
                timeratividade2.Start();
                txthorainicio2.Text = timerini1.ToString();
                txtdata2.Text = timerini1.ToString();
            }
           
        }

        private void Botiniciaratividade3_Click(object sender, EventArgs e)
        {
            if (Empresa3.Text == "" || Tarefa3.Text == "" || Comp3.Text == "")
            {

                MessageBox.Show("Impossível Iniciar, verificar campos vazios");
            }
            else
            {
                timerini2 = DateTime.Now;
                timeratividade3.Start();
                txthorainicio3.Text = timerini2.ToString();
                txtdata3.Text = timerini2.ToString();
            }
           
        }

        private void timeratividade1_Tick(object sender, EventArgs e)
        {
            tempoatividade.Text = relogio1.ToString();
            relogio1++;
        }

        private void timeratividade2_Tick(object sender, EventArgs e)
        {
            tempoatividade2.Text = relogio2.ToString();
            relogio2++;
        }

        private void timeratividade3_Tick(object sender, EventArgs e)
        {
            tempoatividade3.Text = relogio3.ToString();
            relogio3++;
        }

        private void Nova1_Click(object sender, EventArgs e)
        {


            if (txthorafinal.Text == "")
            {

                MessageBox.Show("Impossível salvar, verificar campos vazios");
            }
            else
            {               
                Atividade ativ = new Atividade();
                ativ.DATAATIVIDADES = txtdata.Text;
                ativ.USERATIVIDADES = txtusername.Text;
                ativ.EMPRESANOME = Empresa1.Text;
                ativ.TAREFANOME = Tarefa1.Text;
                ativ.COMPETENCIA = Comp1.Text;
                ativ.COMENTARIO = txtcomentario.Text;
                ativ.HORAINICIO = txthorainicio.Text;
                ativ.HORAFINAL = txthorafinal.Text;
                ativ.TEMPOATIVIDADE = tempoatividade.Text;

                Banco.novaatividade(ativ);

                timeratividade1.Stop();
                relogio1 = 0;
                tempoatividade.Text = "Tempo";
                Empresa1.Text = "";
                Tarefa1.Text = "";
                Comp1.Text = "";
                txtcomentario.Text = "";
                txthorainicio.Text = "";
                txthorafinal.Text = "";

            }

        }
        
        private void Nova2_Click(object sender, EventArgs e)
        {

            if (txthorafinal2.Text == "")
            {

                MessageBox.Show("Impossível salvar, verificar campos vazios");
            }
            else
            {
               
                Atividade ativ2 = new Atividade();
                ativ2.DATAATIVIDADES2 = txtdata2.Text;
                ativ2.USERATIVIDADES2 = txtusername.Text;
                ativ2.EMPRESANOME2 = Empresa2.Text;
                ativ2.TAREFANOME2 = Tarefa2.Text;
                ativ2.COMPETENCIA2 = Comp2.Text;
                ativ2.COMENTARIO2 = txtcomentario2.Text;
                ativ2.HORAINICIO2 = txthorainicio2.Text;
                ativ2.HORAFINAL2 = txthorafinal2.Text;
                ativ2.TEMPOATIVIDADE2 = tempoatividade2.Text;

                Banco.novaatividade2(ativ2);
                timeratividade2.Stop();
                relogio2 = 0;
                tempoatividade2.Text = "Tempo";
                Empresa2.Text = "";
                Tarefa2.Text = "";
                Comp2.Text = "";
                txtcomentario2.Text = "";
                txthorainicio2.Text = "";
                txthorafinal2.Text = "";
            }


        }

        private void Nova3_Click(object sender, EventArgs e)
        {


            if (txthorafinal3.Text == "")
            {

                MessageBox.Show("Impossível salvar, verificar campos vazios");
            }
            else
            {
                Atividade ativ3 = new Atividade();
                ativ3.DATAATIVIDADES3 = txtdata3.Text;
                ativ3.USERATIVIDADES3 = txtusername.Text;
                ativ3.EMPRESANOME3 = Empresa3.Text;
                ativ3.TAREFANOME3 = Tarefa3.Text;
                ativ3.COMPETENCIA3 = Comp3.Text;
                ativ3.COMENTARIO3 = txtcomentario3.Text;
                ativ3.HORAINICIO3 = txthorainicio3.Text;
                ativ3.HORAFINAL3 = txthorafinal3.Text;
                ativ3.TEMPOATIVIDADE3 = tempoatividade3.Text;

                Banco.novaatividade3(ativ3);

                timeratividade3.Stop();
                relogio3 = 0;
                tempoatividade3.Text = "Tempo";
                Empresa3.Text = "";
                Tarefa3.Text = "";
                Comp3.Text = "";
                txtcomentario3.Text = "";
                txthorainicio3.Text = "";
                txthorafinal3.Text = "";             
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menuprincipal form = new Menuprincipal();
            Atividades.ActiveForm.Close();
            form.Show();
        }

        private void Retornarmenu_Click(object sender, EventArgs e)
        {
            if(txthorainicio.Text == "" && txthorainicio2.Text == "" && txthorainicio3.Text == "")
            {
                //Menuprincipal form = new Menuprincipal();
                Atividades.ActiveForm.Close();
                //form.Show();
                Menuprincipal.ActiveForm.WindowState = FormWindowState.Maximized;
                Menuprincipal.ActiveForm.WindowState = FormWindowState.Normal;
                //Menuprincipal.ActiveForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Para voltar, finalize as tarafeas!");
            }
            
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtusername_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Atividades_MinimumSizeChanged(object sender, EventArgs e)
        {
            

        }
    }
}
