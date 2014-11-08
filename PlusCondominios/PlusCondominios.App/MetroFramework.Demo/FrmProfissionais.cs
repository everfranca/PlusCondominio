using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Demo;
using PlusCondominios.Model;
using PlusCondominios.Bll;

namespace MetroFramework.Demo
{
    public partial class FrmProfissionais : FrmBase
    {
        public FrmProfissionais()
        {
            InitializeComponent();
        }

        private void FrmProfissionais_Load(object sender, EventArgs e)
        {
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ProfissionalInfo info = new ProfissionalInfo();
            ProfissionalBll bll = new ProfissionalBll();

            try
            {
                if (VerificaCamposObrigatorios())
                {
                    info.PRO_Cpf = txtCpf.Text.Replace(".", "").Replace("-", "");
                    info.PRO_Nome = txtNome.Text;
                    info.PRO_Telefone = txtTelefone.Text.Replace("()", "").Replace("-", "");
                    info.PRO_Veiculo = txtVeiculo.Text;
                    info.PRO_Placa = txtPlaca.Text.Replace("-", "");
                    info.PRO_Empresa = txtEmpresa.Text;
                    info.PRO_Foto = "";
                    if(bll.Salvar(info))
                        MetroMessageBox.Show(this, "Dados salvo com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MetroMessageBox.Show(this, "Erro ao salvar dados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception exc)
            {
                MetroMessageBox.Show(this, "Campo CPF obrigatório.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                info = null;
            }

        }

        private bool VerificaCamposObrigatorios()
        {

            if (string.IsNullOrEmpty(txtCpf.Text))
            {
                MetroMessageBox.Show(this, "Campo CPF obrigatório.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MetroMessageBox.Show(this, "Campo Nome obrigatório.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(txtTelefone.Text))
            {
                MetroMessageBox.Show(this, "Campo Telefone obrigatório.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(txtVeiculo.Text))
            {
                MetroMessageBox.Show(this, "Campo Veículo obrigatório.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                MetroMessageBox.Show(this, "Campo Placa obrigatório.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(txtEmpresa.Text))
            {
                MetroMessageBox.Show(this, "Campo Empresa obrigatório.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            Nucleo.Validations info = new Validations();

            try
            {
                if(!info.isCPF(txtCpf.Text))
                    MetroMessageBox.Show(this, "CPF informado inválido ! Verifique os dados informado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception exc)
            {

            }
            finally
            {
                info = null;
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            //WebCamCapture web = new WebCamCapture();
            //web.Start(0);
            //web.ImageCaptured(web, WebcamEventArgs);
        }
    }
}
