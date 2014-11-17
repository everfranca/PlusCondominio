using MetroFramework.Forms;
using PlusCondominios.Bll;
using PlusCondominios.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetroFramework.Demo
{
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();

            txtUsuario.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioBll usuarioBll = new UsuarioBll();
            UsuarioInfo usuarioInfo = new UsuarioInfo();

            usuarioInfo = usuarioBll.AutenticaUsuario(txtUsuario.Text, txtSenha.Text);

            if (usuarioInfo != null)
            {
                this.Visible = false;
                FrmMenu frmMenu = new FrmMenu(usuarioInfo);
                frmMenu.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Usuário ou Senha Inválido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("Usuário ou Senha Inválido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
