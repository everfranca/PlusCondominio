using MetroFramework.Demo.Model;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmProfissionais : FrmBase
    {
        public FrmProfissionais()
        {
            InitializeComponent();
            MontarGrid();
        }

        List<ProfissionalInfo> lstProfissionais = new List<ProfissionalInfo>();

        public void MontarGrid()
        {
            GridVisitantes.Rows.Add("Joaquim da Silva", "999.999-99", "16-99999-9999", "Marcão Ar Condicionados", "Editar", "Excluir");
            GridVisitantes.Rows.Add("Antonio da Silva", "999.999-99", "16-99999-9999", "Marcão Ar Condicionados", "Editar", "Excluir");
            GridVisitantes.Rows.Add("João da Silva", "999.999-99", "16-99999-9999", "Marcão Ar Condicionados", "Editar", "Excluir");
            GridVisitantes.Rows.Add("Luis da Silva", "999.999-99", "16-99999-9999", "Marcão Ar Condicionados", "Editar", "Excluir");
        }

        private void MontarListaProfissionais()
        {
            lstProfissionais = new List<ProfissionalInfo>();
            ProfissionalInfo profissionalInfo = new ProfissionalInfo();
            profissionalInfo.CPF = "251.888.516-10";
            profissionalInfo.Nome = "Joaquim da Silva";
            profissionalInfo.Telefone = "(16)99999-9999";
            profissionalInfo.Veiculo = "Fiat Uno";
            profissionalInfo.Placa = "GBX-9023";
            profissionalInfo.Apartamento = "22 Bloco G";
            profissionalInfo.Empresa = "Marcão Ar Condicionados";
            profissionalInfo.DataEntrada = new DateTime(2014, 6, 30, 10, 30, 25);
            profissionalInfo.DataSaída = new DateTime(2014, 6, 30, 15, 35, 25);
            profissionalInfo.Observacao = "Nenhuma";

            lstProfissionais.Add(profissionalInfo);

            profissionalInfo = new ProfissionalInfo();
            profissionalInfo.CPF = "518.565.963-70";
            profissionalInfo.Nome = "Antonio da Silva";
            profissionalInfo.Telefone = "(16)99999-9999";
            profissionalInfo.Veiculo = "Fiat Palio";
            profissionalInfo.Placa = "GBX-9024";
            profissionalInfo.Apartamento = "23 Bloco G";
            profissionalInfo.Empresa = "Marcão Ar Condicionados";
            profissionalInfo.DataEntrada = new DateTime(2014, 6, 30, 10, 30, 25);
            profissionalInfo.DataSaída = new DateTime(2014, 6, 30, 15, 35, 25);
            profissionalInfo.Observacao = "Nenhuma";

            lstProfissionais.Add(profissionalInfo);

            profissionalInfo = new ProfissionalInfo();
            profissionalInfo.CPF = "518.565.963-70";
            profissionalInfo.Nome = "João da Silva";
            profissionalInfo.Telefone = "(16)99999-9999";
            profissionalInfo.Veiculo = "Fiat Bravo";
            profissionalInfo.Placa = "GBX-9025";
            profissionalInfo.Apartamento = "24 Bloco G";
            profissionalInfo.Empresa = "Marcão Ar Condicionados";
            profissionalInfo.DataEntrada = new DateTime(2014, 6, 30, 10, 30, 25);
            profissionalInfo.DataSaída = new DateTime(2014, 6, 30, 15, 35, 25);
            profissionalInfo.Observacao = "Nenhuma";

            lstProfissionais.Add(profissionalInfo);

            profissionalInfo = new ProfissionalInfo();
            profissionalInfo.CPF = "518.565.963-70";
            profissionalInfo.Nome = "Luis da Silva";
            profissionalInfo.Telefone = "(16)99999-9999";
            profissionalInfo.Veiculo = "Fiat Linea";
            profissionalInfo.Placa = "GBX-9026";
            profissionalInfo.Apartamento = "25 Bloco G";
            profissionalInfo.Empresa = "Marcão Ar Condicionados";
            profissionalInfo.DataEntrada = new DateTime(2014, 6, 30, 10, 30, 25);
            profissionalInfo.DataSaída = new DateTime(2014, 6, 30, 15, 35, 25);
            profissionalInfo.Observacao = "Nenhuma";

            lstProfissionais.Add(profissionalInfo);

            //---
            ReportDataSource rds = new ReportDataSource("DataSetAcessoProfissionais", lstProfissionais);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
        }

        private void FrmProfissionais_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 2)
            {
                MontarListaProfissionais();

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
