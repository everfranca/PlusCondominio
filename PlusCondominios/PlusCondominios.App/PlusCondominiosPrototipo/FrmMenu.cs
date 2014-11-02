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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToLongDateString();
            lblHorario.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FrmMoradores frm = new FrmMoradores();
            //frm.TopLevel = false;
            //frm.AutoScroll = true;
            //pnlConteudo.Controls.Clear();
            //pnlConteudo.Controls.Add(frm);
            //frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FrmVisitantes frm = new FrmVisitantes();
            //frm.TopLevel = false;
            //frm.AutoScroll = true;
            //pnlConteudo.Controls.Clear();
            //pnlConteudo.Controls.Add(frm);
            //frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //FrmProfissionais frm = new FrmProfissionais();
            //frm.TopLevel = false;
            //frm.AutoScroll = true;
            //pnlConteudo.Controls.Clear();
            //pnlConteudo.Controls.Add(frm);
            //frm.Show();
        }

        private void btnVisitantes_Click(object sender, EventArgs e)
        {
            FrmVisitantes frmVisitante = new FrmVisitantes();
            frmVisitante.MdiParent = this;
            frmVisitante.Show();
        }

        private void btnMoradores_Click(object sender, EventArgs e)
        {
            FrmMoradores frmMoradores = new FrmMoradores();
            frmMoradores.MdiParent = this;
            frmMoradores.Show();
        }
    }
}
