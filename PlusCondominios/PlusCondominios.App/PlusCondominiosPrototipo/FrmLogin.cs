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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToUpper().Equals("ADMIN") && textBox2.Text.ToUpper().Equals("ADMIN"))
            {
                this.Visible = false;
                FrmMenu frmMenu = new FrmMenu();
                frmMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Inválido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
            }
        }
    }
}
