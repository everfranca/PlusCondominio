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
    public partial class FrmVisitantes : FrmBase
    {
        public FrmVisitantes()
        {
            InitializeComponent();

            MontarGrid();
        }

        List<VisitanteInfo> lstVisitantes = new List<VisitanteInfo>();

        private void MontarGrid()
        {
            GridVisitantes.Rows.Add("Joaquim da Silva", "999.999-99", "16-99999-9999", "Registrar Entrada/Saída");
            GridVisitantes.Rows.Add("Antonio da Silva", "999.999-99", "16-99999-9999", "Registrar Entrada/Saída");
            GridVisitantes.Rows.Add("João da Silva", "999.999-99", "16-99999-9999", "Registrar Entrada/Saída");
            GridVisitantes.Rows.Add("Luis da Silva", "999.999-99", "16-99999-9999", "Registrar Entrada/Saída");
        }
        private void MontarListaVisitantes()
        {
            lstVisitantes = new List<VisitanteInfo>();
            VisitanteInfo visitanteInfo = new VisitanteInfo();
            visitanteInfo.CPF = "251.888.516-10";
            visitanteInfo.Nome = "Joaquim da Silva";
            visitanteInfo.Telefone = "(16)99999-9999";
            visitanteInfo.Veiculo = "Fiat Uno";
            visitanteInfo.Placa = "GBX-9023";
            visitanteInfo.Apartamento = "22 Bloco G";
            visitanteInfo.DataEntrada = new DateTime(2014, 6, 30, 10, 30, 25);
            visitanteInfo.DataSaída = new DateTime(2014, 6, 30, 15, 35, 25);
            visitanteInfo.Observacao = "Nenhuma";

            lstVisitantes.Add(visitanteInfo);

            visitanteInfo = new VisitanteInfo();
            visitanteInfo.CPF = "518.565.963-70";
            visitanteInfo.Nome = "Antonio da Silva";
            visitanteInfo.Telefone = "(16)99999-9999";
            visitanteInfo.Veiculo = "Fiat Palio";
            visitanteInfo.Placa = "GBX-9024";
            visitanteInfo.Apartamento = "23 Bloco G";
            visitanteInfo.DataEntrada = new DateTime(2014, 6, 30, 10, 30, 25);
            visitanteInfo.DataSaída = new DateTime(2014, 6, 30, 15, 35, 25);
            visitanteInfo.Observacao = "Nenhuma";

            lstVisitantes.Add(visitanteInfo);

            visitanteInfo = new VisitanteInfo();
            visitanteInfo.CPF = "518.565.963-70";
            visitanteInfo.Nome = "João da Silva";
            visitanteInfo.Telefone = "(16)99999-9999";
            visitanteInfo.Veiculo = "Fiat Bravo";
            visitanteInfo.Placa = "GBX-9025";
            visitanteInfo.Apartamento = "24 Bloco G";
            visitanteInfo.DataEntrada = new DateTime(2014, 6, 30, 10, 30, 25);
            visitanteInfo.DataSaída = new DateTime(2014, 6, 30, 15, 35, 25);
            visitanteInfo.Observacao = "Nenhuma";

            lstVisitantes.Add(visitanteInfo);

            visitanteInfo = new VisitanteInfo();
            visitanteInfo.CPF = "518.565.963-70";
            visitanteInfo.Nome = "Luis da Silva";
            visitanteInfo.Telefone = "(16)99999-9999";
            visitanteInfo.Veiculo = "Fiat Linea";
            visitanteInfo.Placa = "GBX-9026";
            visitanteInfo.Apartamento = "25 Bloco G";
            visitanteInfo.DataEntrada = new DateTime(2014, 6, 30, 10, 30, 25);
            visitanteInfo.DataSaída = new DateTime(2014, 6, 30, 15, 35, 25);
            visitanteInfo.Observacao = "Nenhuma";

            lstVisitantes.Add(visitanteInfo);

            //---
            ReportDataSource rds = new ReportDataSource("DataSetAcessoVisitantes", lstVisitantes);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
        }

        private void FrmVisitantes_Load(object sender, EventArgs e)
        {
            if (metroTabControl1.TabPages.Count > 0)
                metroTabControl1.SelectedIndex = 0;
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 2)
            {
                MontarListaVisitantes();

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
