using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlusCondominiosPrototipo
{
    public partial class FrmVisitantes : Form
    {
        public FrmVisitantes()
        {
            InitializeComponent();
        }

        public void MontarGrid()
        {
            GridVisitantes.Rows.Add("Joaquim da Silva", "999.999-99", "16-99999-9999");
            GridVisitantes.Rows.Add("Antonio da Silva", "999.999-99", "16-99999-9999");
            GridVisitantes.Rows.Add("João da Silva", "999.999-99", "16-99999-9999");
            GridVisitantes.Rows.Add("Luis da Silva", "999.999-99", "16-99999-9999");
        }

        private void FrmVisitantes_Load(object sender, EventArgs e)
        {
            MontarGrid();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            FrmVisitantesCadastro frmVisitantesCadastro = new FrmVisitantesCadastro();
            //frmVisitantesCadastro.Parent = this;
            frmVisitantesCadastro.ShowDialog();
        }
    }
}
