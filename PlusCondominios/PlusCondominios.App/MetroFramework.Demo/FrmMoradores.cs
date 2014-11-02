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
    public partial class FrmMoradores : FrmBase
    {
        public FrmMoradores()
        {
            InitializeComponent();

            MontarGrid();
        }

        public void MontarGrid()
        {
            GridVisitantes.Rows.Add("Joaquim da Silva", "999.999-99", "16-99999-9999", "Editar", "Excluir");
            GridVisitantes.Rows.Add("Antonio da Silva", "999.999-99", "16-99999-9999", "Editar", "Excluir");
            GridVisitantes.Rows.Add("João da Silva", "999.999-99", "16-99999-9999", "Editar", "Excluir");
            GridVisitantes.Rows.Add("Luis da Silva", "999.999-99", "16-99999-9999", "Editar", "Excluir");
        }
    }
}
