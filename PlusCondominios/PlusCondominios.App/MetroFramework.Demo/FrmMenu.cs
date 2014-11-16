using MetroFramework.Forms;
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
    public partial class FrmMenu : MetroForm
    {
        public FrmMenu()
        {
            InitializeComponent();

            metroStyleManager.Owner = this;
            metroStyleManager.Theme = MetroThemeStyle.Light;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            menuProfissionais.BackColor = Color.FromName("#009200");

            timer1.Start();
        }


        private void metroTileSwitch_Click(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 13);
            metroStyleManager.Style = (MetroColorStyle)next;

            if (metroStyleManager.Style == MetroColorStyle.White)
            {
                next = m.Next(0, 13);
                metroStyleManager.Style = (MetroColorStyle)next;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToLongDateString();
            lblHorario.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(metroButton5, new Point(0, metroButton5.Height));
        }

        private void menuMoradores_Click(object sender, EventArgs e)
        {
            FrmMoradores frmMoradores = new FrmMoradores();
            //frmVisitante.MdiParent = this;
            frmMoradores.ShowDialog();
        }

        private void menuVisitantes_Click(object sender, EventArgs e)
        {
            FrmVisitantes frmVisitante = new FrmVisitantes();
            //frmVisitante.MdiParent = this;
            frmVisitante.ShowDialog();
        }

        private void menuConfiguracoes_Click(object sender, EventArgs e)
        {

        }

        private void menuProfissionais_Click(object sender, EventArgs e)
        {
            FrmProfissionais frmProfissionais = new FrmProfissionais();
            //frmVisitante.MdiParent = this;
            frmProfissionais.ShowDialog();
        }

        private void menuRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void menuApartamento_Click(object sender, EventArgs e)
        {

        }

        private void menuAgendamento_Click(object sender, EventArgs e)
        {

        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }
    }
}
