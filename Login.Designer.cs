
namespace NewAtividades
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            System.Windows.Forms.Button botaologin;
            this.painellogin = new System.Windows.Forms.Panel();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            botaologin = new System.Windows.Forms.Button();
            this.painellogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // painellogin
            // 
            this.painellogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painellogin.BackgroundImage")));
            this.painellogin.Controls.Add(botaologin);
            this.painellogin.Controls.Add(this.txtsenha);
            this.painellogin.Controls.Add(this.txtnome);
            this.painellogin.Location = new System.Drawing.Point(313, 93);
            this.painellogin.Name = "painellogin";
            this.painellogin.Size = new System.Drawing.Size(360, 399);
            this.painellogin.TabIndex = 0;
            this.painellogin.Paint += new System.Windows.Forms.PaintEventHandler(this.painellogin_Paint);
            // 
            // botaologin
            // 
            botaologin.BackColor = System.Drawing.Color.Transparent;
            botaologin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaologin.BackgroundImage")));
            botaologin.CausesValidation = false;
            botaologin.Cursor = System.Windows.Forms.Cursors.Hand;
            botaologin.FlatAppearance.BorderSize = 0;
            botaologin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botaologin.ForeColor = System.Drawing.Color.Transparent;
            botaologin.Location = new System.Drawing.Point(28, 313);
            botaologin.Name = "botaologin";
            botaologin.Size = new System.Drawing.Size(287, 73);
            botaologin.TabIndex = 2;
            botaologin.UseVisualStyleBackColor = false;
            botaologin.Click += new System.EventHandler(this.botaologin_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtsenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtsenha.Location = new System.Drawing.Point(108, 256);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(197, 22);
            this.txtsenha.TabIndex = 1;
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtnome.Location = new System.Drawing.Point(108, 179);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(197, 22);
            this.txtnome.TabIndex = 0;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BtnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastrar.FlatAppearance.BorderSize = 0;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnCadastrar.Location = new System.Drawing.Point(30, 570);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 1;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 605);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.painellogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.painellogin.ResumeLayout(false);
            this.painellogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painellogin;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button BtnCadastrar;
    }
}

