using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace NewAtividades
{
    public partial class Login : Form
    {
        Conexao ConecGeral = new Conexao();
        DataTable dt = new DataTable();

       

        public Login()
        {
            InitializeComponent();
            painellogin.Visible = false;
            
        }

        private void painellogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            painellogin.Location = new Point(this.Width / 2 - 180, this.Height / 2 - 195);
            painellogin.Visible = true;
            //botaologin.FlatAppearance.MouseOverBackColor = Color.FromArgb(218,175,3);
            //txtnome.Text = Application.

           
        }


       /* private void Login_Load(object sender, EventArgs e)
        {
            
        }*/

        private void botaologin_Click(object sender, EventArgs e)
        {
            chamarLogin();

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chamarLogin();
            }

        }

        //Evento chamando utilizando A tecla enter do teclado
        private void chamarLogin()
        {
            string username = txtnome.Text;
            string usersenha = txtsenha.Text;

            if (txtnome.Text == "")
            {
                MessageBox.Show("Preencher o usuário");
                txtnome.Focus();
                return;
            }
            if (txtsenha.Text == "")
            {
                MessageBox.Show("Preencher a senha");
                txtsenha.Focus();
                return;
            }
            else
            {   //Consulta o banco de dados e verifica se existe o usuário cadastrado
                string sql = "SELECT * FROM tb_usuarios WHERE USERNAME='"+username+"' AND USERSENHA='"+usersenha+"'";
                dt = Banco.consulta(sql);
                if(dt.Rows.Count ==1)
                {
                    //MessageBox.Show("Login realizado com sucesso!");
                    Form.ActiveForm.WindowState = FormWindowState.Minimized;
                    Globais.logado = true;
                    Globais.username = txtnome.Text;
                    Menuprincipal form = new Menuprincipal();                    
                    limpar();                    
                    form.ShowDialog();
                    //ActiveForm.Close();                    
                    //Globais.nivel = int.Parse(dt.Rows[0].Field<int>("NIVELACESSO").ToString());
                    
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado");
                }
            }
        }
        private void limpar()
        {
            txtsenha.Text = "";
            txtsenha.Focus();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroUser cadUser = new CadastroUser();
            cadUser.Show();
        }
    }
}
