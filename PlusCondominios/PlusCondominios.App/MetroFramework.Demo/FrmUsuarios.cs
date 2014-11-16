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
    public partial class FrmUsuarios : FrmBase
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            LOV.LOVPerfil frmX = new LOV.LOVPerfil();
            frmX.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            bool sucesso = false;
            UsuarioBll usuarioBll = new UsuarioBll();
            UsuarioInfo usuarioInfo = new UsuarioInfo();

            usuarioInfo.USU_Login = txtUsuario.Text;
            usuarioInfo.USU_Senha = txtSenha.Text;
            usuarioInfo.USU_Email = txtEmail.Text;
            usuarioInfo.USU_PRF_Codigo = 1; // mudar pra pegar do LOV
            usuarioInfo.USU_EMP_Codigo = "101"; // Mudar pra pegar do acessoInfo

            sucesso = usuarioBll.Salvar(usuarioInfo);
            if (sucesso)
                MetroMessageBox.Show(this, "Usuário Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "Erro ao inserir o Usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            UsuarioBll usuarioBll = new UsuarioBll();

            var info = usuarioBll.ListarUsuario(txtUsuario.Text);
            if (info != null)
            {
                MetroMessageBox.Show(this, "Usuário já existe", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSalva.Enabled = false;
                return;
            }
            else
                btnSalva.Enabled = true;

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Contains("@"))
                txtEmail.BackColor = System.Drawing.Color.Red;
            else
                txtEmail.BackColor = System.Drawing.Color.Green;
        }
    }
}
