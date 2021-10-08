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
    public partial class CadastroUser : Form
    {
        public CadastroUser()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1.Location = new Point(this.Width / 2 - 180, this.Height / 2 - 195);
            //panel1.Visible = true;


        }

        private void CadastroUser_Load(object sender, EventArgs e)
        {
            /*Conexao kd = new Conexao();
            {
                kd.AbrirConectar();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.USERNAME = txtcadastronome.Text;
            user.USERSENHA = txtcadastrosenha.Text;
            user.USEREMAIL = txtcadastroemail.Text;
            user.USERDEPARTAMENTO = txtcadastroemail.Text;
            user.USERSTATUS = txtsituacao.Text;
            user.USERNIVEL = Convert.ToInt32(Math.Round(nivel_Acesso.Value, 0));

            Banco.novousuario(user);
            CadastroUser.ActiveForm.Close();



        }

        private void txtcadastronome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
