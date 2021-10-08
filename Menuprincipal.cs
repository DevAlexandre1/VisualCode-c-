using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewAtividades
{
    public partial class Menuprincipal : Form
    {
        public Menuprincipal()
        {
            InitializeComponent();
        }

        private void dúvidaSugestõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.WindowState = FormWindowState.Minimized;
            Atividades ativ = new Atividades();
            ativ.ShowDialog();


        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FINALIZAR A APLICAÇÃO QUANDO CLICAR EM SAIR
            Login.ActiveForm.Close();           
            this.Close();

           

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Globais.logado)
            {
               
                if(Globais.nivel ==0)
                {
                    GestaoUsuarios gestaousuarios = new GestaoUsuarios();
                    gestaousuarios.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso negado!");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");

            }
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Globais.logado)
            {
                if (Globais.nivel ==0)
                {
                    //Procedimentos

                }
                else
                {
                    MessageBox.Show("Acesso negado!");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");

            }
        }

        private void Menuprincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
