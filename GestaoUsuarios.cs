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
    public partial class GestaoUsuarios : Form
    {
        public GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void GestaoUsuarios_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.ObterUsuariosIDNome();
            //Definindo o tamanho da largura das colunas do datagrid
            dgv_usuarios.Columns[0].Width = 50;
            dgv_usuarios.Columns[1].Width = 100;
            dgv_usuarios.Columns[2].Width = 50;
            dgv_usuarios.Columns[3].Width = 50;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {

            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt=Banco.ObterdadosUsuario(vid);
                txt_id.Text = dt.Rows[0].Field<Int64>("IDUSUARIO").ToString();
                txt_nome.Text = dt.Rows[0].Field<string>("USERNAME").ToString();
                txt_senha.Text = dt.Rows[0].Field<string>("USERSENHA").ToString();
                txt_email.Text = dt.Rows[0].Field<string>("USEREMAIL").ToString();
                txt_nivel.Text = dt.Rows[0].Field<Int64>("NIVELACESSO").ToString();
                txt_status.Text = dt.Rows[0].Field<string>("USERSTATUS").ToString();
                txt_departamento.Text = dt.Rows[0].Field<String>("USERDEPARTAMENTO").ToString();
            }

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            CadastroUser cadUser = new CadastroUser();
            cadUser.Show();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            //FINALIZAR A APLICAÇÃO QUANDO CLICAR EM SAIR
            GestaoUsuarios.ActiveForm.Close();
            this.Close();

        }
    }
}
