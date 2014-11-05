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

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
