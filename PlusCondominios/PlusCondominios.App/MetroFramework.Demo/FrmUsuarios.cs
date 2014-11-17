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
            PerfilBll perfilBll = new PerfilBll();
            LOV.LOVPerfil frmX = new LOV.LOVPerfil();
            frmX.ShowDialog();

            try
            {
                if (frmX.Tag.ToString() != "0")
                {
                    lblCodPerfil.Text = frmX.Tag.ToString();
                    txtPerfil.Text = perfilBll.ListarPorCodigo(int.Parse(lblCodPerfil.Text)).PRF_Nome;
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Erro ao buscar as informações sobre o Perfil solicitado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                perfilBll = null;
            }
            
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

            try
            {
                if (!string.IsNullOrEmpty(lblCodUsuario.Text))
                    usuarioInfo = usuarioBll.ListarPorCodigo(int.Parse(lblCodUsuario.Text));

                usuarioInfo.USU_Login = txtUsuario.Text;
                usuarioInfo.USU_Senha = txtSenha.Text;
                usuarioInfo.USU_Email = txtEmail.Text;
                usuarioInfo.USU_PRF_Codigo = int.Parse(lblCodPerfil.Text);
                usuarioInfo.USU_EMP_Codigo = "101"; // Mudar pra pegar do acessoInfo

                sucesso = usuarioBll.Salvar(usuarioInfo);
                if (sucesso)
                    MetroMessageBox.Show(this, "Usuário Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroMessageBox.Show(this, "Erro ao inserir o Usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MetroMessageBox.Show(this, exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            UsuarioBll usuarioBll = new UsuarioBll();

            var info = usuarioBll.ListarUsuario(txtUsuario.Text);
            if (info != null)
            {
                MetroMessageBox.Show(this, "Usuário já existe", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSalva.Enabled = false;
                txtUsuario.Focus();
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

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            UsuarioBll usuarioBll = new UsuarioBll();

            var lst = usuarioBll.ListarTodos();

            GridUsuarios.DataSource = lst;
        }

        private void GridUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PerfilBll perfilBll = new PerfilBll();

            try
            {
                lblCodUsuario.Text = GridUsuarios.SelectedRows[0].Cells[0].Value.ToString();
                txtUsuario.Text = GridUsuarios.SelectedRows[0].Cells[1].Value.ToString();
                txtSenha.Text = GridUsuarios.SelectedRows[0].Cells[2].Value.ToString();
                txtEmail.Text = GridUsuarios.SelectedRows[0].Cells[3].Value.ToString();
                lblCodPerfil.Text = GridUsuarios.SelectedRows[0].Cells[4].Value.ToString();
                lblCodEmpresa.Text = GridUsuarios.SelectedRows[0].Cells[5].Value.ToString();

                txtPerfil.Text = perfilBll.ListarPorCodigo(int.Parse(lblCodPerfil.Text)).PRF_Nome;
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Erro ao buscar as informações sobre o Usuário solicitado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
