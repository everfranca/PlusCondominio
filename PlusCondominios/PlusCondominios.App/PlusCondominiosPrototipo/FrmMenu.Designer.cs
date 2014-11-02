namespace PlusCondominiosPrototipo
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnProfissionais = new System.Windows.Forms.Button();
            this.btnVisitantes = new System.Windows.Forms.Button();
            this.btnMoradores = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblData);
            this.panel4.Controls.Add(this.lblHorario);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(462, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(482, 50);
            this.panel4.TabIndex = 4;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(97, 25);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(55, 20);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "#data";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(386, 25);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(75, 20);
            this.lblHorario.TabIndex = 4;
            this.lblHorario.Text = "#horario";
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(56, 46);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administrador";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackgroundImage = global::PlusCondominiosPrototipo.Properties.Resources.usuario;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(287, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 42);
            this.panel2.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.Controls.Add(this.btnProfissionais);
            this.pnlMenuPrincipal.Controls.Add(this.btnVisitantes);
            this.pnlMenuPrincipal.Controls.Add(this.btnMoradores);
            this.pnlMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuPrincipal.Location = new System.Drawing.Point(0, 50);
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            this.pnlMenuPrincipal.Size = new System.Drawing.Size(130, 511);
            this.pnlMenuPrincipal.TabIndex = 4;
            // 
            // btnProfissionais
            // 
            this.btnProfissionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfissionais.Image = ((System.Drawing.Image)(resources.GetObject("btnProfissionais.Image")));
            this.btnProfissionais.Location = new System.Drawing.Point(3, 191);
            this.btnProfissionais.Name = "btnProfissionais";
            this.btnProfissionais.Size = new System.Drawing.Size(120, 88);
            this.btnProfissionais.TabIndex = 2;
            this.btnProfissionais.Text = "Profissionais";
            this.btnProfissionais.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfissionais.UseVisualStyleBackColor = true;
            // 
            // btnVisitantes
            // 
            this.btnVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitantes.Image = global::PlusCondominiosPrototipo.Properties.Resources.visitantes;
            this.btnVisitantes.Location = new System.Drawing.Point(3, 97);
            this.btnVisitantes.Name = "btnVisitantes";
            this.btnVisitantes.Size = new System.Drawing.Size(120, 88);
            this.btnVisitantes.TabIndex = 1;
            this.btnVisitantes.Text = "Visitantes";
            this.btnVisitantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisitantes.UseVisualStyleBackColor = true;
            this.btnVisitantes.Click += new System.EventHandler(this.btnVisitantes_Click);
            // 
            // btnMoradores
            // 
            this.btnMoradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoradores.Image = global::PlusCondominiosPrototipo.Properties.Resources.moradores1;
            this.btnMoradores.Location = new System.Drawing.Point(3, 3);
            this.btnMoradores.Name = "btnMoradores";
            this.btnMoradores.Size = new System.Drawing.Size(120, 88);
            this.btnMoradores.TabIndex = 0;
            this.btnMoradores.Text = "Moradores";
            this.btnMoradores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMoradores.UseVisualStyleBackColor = true;
            this.btnMoradores.Click += new System.EventHandler(this.btnMoradores_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.pnlMenuPrincipal);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu do Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlMenuPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlMenuPrincipal;
        private System.Windows.Forms.Button btnProfissionais;
        private System.Windows.Forms.Button btnVisitantes;
        private System.Windows.Forms.Button btnMoradores;

    }
}