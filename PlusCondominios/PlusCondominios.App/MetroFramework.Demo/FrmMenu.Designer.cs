namespace MetroFramework.Demo
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.menuAgendamento = new MetroFramework.Controls.MetroTile();
            this.menuApartamento = new MetroFramework.Controls.MetroTile();
            this.menuUsuarios = new MetroFramework.Controls.MetroTile();
            this.menuRelatorios = new MetroFramework.Controls.MetroTile();
            this.metroTileSwitch = new MetroFramework.Controls.MetroTile();
            this.menuProfissionais = new MetroFramework.Controls.MetroTile();
            this.menuVisitantes = new MetroFramework.Controls.MetroTile();
            this.menuMoradores = new MetroFramework.Controls.MetroTile();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.lblHorario = new MetroFramework.Controls.MetroLabel();
            this.lblData = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel5);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(968, 47);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(249, 16);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(129, 25);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Administrador";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(152, 120);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.toolsToolStripMenuItem.Text = "P&roprietários";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.menuMoradores_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.fileToolStripMenuItem.Text = "&Visitantes";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.menuVisitantes_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.maintenanceToolStripMenuItem.Text = "&Profissionais";
            this.maintenanceToolStripMenuItem.Click += new System.EventHandler(this.menuProfissionais_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.settingsToolStripMenuItem.Text = "&Configurações";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.menuConfiguracoes_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "&Sair";
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroButton5
            // 
            this.metroButton5.BackgroundImage = global::MetroFramework.Demo.Properties.Resources.usuario;
            this.metroButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton5.Location = new System.Drawing.Point(384, 3);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(43, 42);
            this.metroButton5.TabIndex = 18;
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroPanel3);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(20, 540);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(968, 40);
            this.metroPanel4.TabIndex = 2;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.menuAgendamento);
            this.metroPanel2.Controls.Add(this.menuApartamento);
            this.metroPanel2.Controls.Add(this.menuUsuarios);
            this.metroPanel2.Controls.Add(this.menuRelatorios);
            this.metroPanel2.Controls.Add(this.metroTileSwitch);
            this.metroPanel2.Controls.Add(this.menuProfissionais);
            this.metroPanel2.Controls.Add(this.menuVisitantes);
            this.metroPanel2.Controls.Add(this.menuMoradores);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 107);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(968, 433);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // menuAgendamento
            // 
            this.menuAgendamento.ActiveControl = null;
            this.menuAgendamento.Location = new System.Drawing.Point(659, 139);
            this.menuAgendamento.Name = "menuAgendamento";
            this.menuAgendamento.Size = new System.Drawing.Size(117, 115);
            this.menuAgendamento.TabIndex = 9;
            this.menuAgendamento.Text = "Agendamentos";
            this.menuAgendamento.TileImage = global::MetroFramework.Demo.Properties.Resources.Calendario;
            this.menuAgendamento.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuAgendamento.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menuAgendamento.UseSelectable = true;
            this.menuAgendamento.UseTileImage = true;
            this.menuAgendamento.Click += new System.EventHandler(this.menuAgendamento_Click);
            // 
            // menuApartamento
            // 
            this.menuApartamento.ActiveControl = null;
            this.menuApartamento.Location = new System.Drawing.Point(526, 139);
            this.menuApartamento.Name = "menuApartamento";
            this.menuApartamento.Size = new System.Drawing.Size(127, 115);
            this.menuApartamento.Style = MetroFramework.MetroColorStyle.Red;
            this.menuApartamento.TabIndex = 8;
            this.menuApartamento.Text = "Apartamentos";
            this.menuApartamento.TileImage = global::MetroFramework.Demo.Properties.Resources.apartamento;
            this.menuApartamento.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuApartamento.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menuApartamento.UseSelectable = true;
            this.menuApartamento.UseTileImage = true;
            this.menuApartamento.Click += new System.EventHandler(this.menuApartamento_Click);
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.ActiveControl = null;
            this.menuUsuarios.Location = new System.Drawing.Point(526, 18);
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(250, 115);
            this.menuUsuarios.Style = MetroFramework.MetroColorStyle.Lime;
            this.menuUsuarios.TabIndex = 7;
            this.menuUsuarios.Text = "Usuários do Sistema";
            this.menuUsuarios.TileImage = global::MetroFramework.Demo.Properties.Resources.usuarioSistema;
            this.menuUsuarios.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuUsuarios.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menuUsuarios.UseSelectable = true;
            this.menuUsuarios.UseTileImage = true;
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.ActiveControl = null;
            this.menuRelatorios.Location = new System.Drawing.Point(270, 139);
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(250, 115);
            this.menuRelatorios.Style = MetroFramework.MetroColorStyle.Green;
            this.menuRelatorios.TabIndex = 6;
            this.menuRelatorios.Text = "Relatórios";
            this.menuRelatorios.TileImage = global::MetroFramework.Demo.Properties.Resources.relatorio2;
            this.menuRelatorios.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuRelatorios.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menuRelatorios.UseSelectable = true;
            this.menuRelatorios.UseTileImage = true;
            this.menuRelatorios.Click += new System.EventHandler(this.menuRelatorios_Click);
            // 
            // metroTileSwitch
            // 
            this.metroTileSwitch.ActiveControl = null;
            this.metroTileSwitch.Location = new System.Drawing.Point(14, 360);
            this.metroTileSwitch.Name = "metroTileSwitch";
            this.metroTileSwitch.Size = new System.Drawing.Size(84, 30);
            this.metroTileSwitch.TabIndex = 5;
            this.metroTileSwitch.Text = "Switch Style";
            this.metroTileSwitch.UseSelectable = true;
            this.metroTileSwitch.Visible = false;
            // 
            // menuProfissionais
            // 
            this.menuProfissionais.ActiveControl = null;
            this.menuProfissionais.Location = new System.Drawing.Point(14, 139);
            this.menuProfissionais.Name = "menuProfissionais";
            this.menuProfissionais.Size = new System.Drawing.Size(250, 115);
            this.menuProfissionais.Style = MetroFramework.MetroColorStyle.Orange;
            this.menuProfissionais.TabIndex = 4;
            this.menuProfissionais.Text = "Profissionais";
            this.menuProfissionais.TileImage = global::MetroFramework.Demo.Properties.Resources.profissionais3;
            this.menuProfissionais.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuProfissionais.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menuProfissionais.UseSelectable = true;
            this.menuProfissionais.UseTileImage = true;
            this.menuProfissionais.Click += new System.EventHandler(this.menuProfissionais_Click);
            // 
            // menuVisitantes
            // 
            this.menuVisitantes.ActiveControl = null;
            this.menuVisitantes.Location = new System.Drawing.Point(270, 18);
            this.menuVisitantes.Name = "menuVisitantes";
            this.menuVisitantes.Size = new System.Drawing.Size(250, 115);
            this.menuVisitantes.Style = MetroFramework.MetroColorStyle.Purple;
            this.menuVisitantes.TabIndex = 3;
            this.menuVisitantes.Text = "Visitantes";
            this.menuVisitantes.TileImage = global::MetroFramework.Demo.Properties.Resources.visitantes2;
            this.menuVisitantes.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuVisitantes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menuVisitantes.UseSelectable = true;
            this.menuVisitantes.UseTileImage = true;
            this.menuVisitantes.Click += new System.EventHandler(this.menuVisitantes_Click);
            // 
            // menuMoradores
            // 
            this.menuMoradores.ActiveControl = null;
            this.menuMoradores.BackColor = System.Drawing.Color.White;
            this.menuMoradores.Location = new System.Drawing.Point(14, 18);
            this.menuMoradores.Name = "menuMoradores";
            this.menuMoradores.Size = new System.Drawing.Size(250, 115);
            this.menuMoradores.Style = MetroFramework.MetroColorStyle.Teal;
            this.menuMoradores.TabIndex = 2;
            this.menuMoradores.Text = "Proprietários";
            this.menuMoradores.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.menuMoradores.TileImage = global::MetroFramework.Demo.Properties.Resources.moradores3;
            this.menuMoradores.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuMoradores.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.menuMoradores.UseSelectable = true;
            this.menuMoradores.UseTileImage = true;
            this.menuMoradores.Click += new System.EventHandler(this.menuMoradores_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.lblHorario);
            this.metroPanel3.Controls.Add(this.lblData);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(581, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(387, 40);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // lblHorario
            // 
            this.lblHorario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHorario.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHorario.Location = new System.Drawing.Point(299, 10);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(3);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(85, 25);
            this.lblHorario.TabIndex = 10;
            this.lblHorario.Text = "#horario";
            this.lblHorario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblHorario.UseStyleColors = true;
            // 
            // lblData
            // 
            this.lblData.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblData.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblData.Location = new System.Drawing.Point(3, 10);
            this.lblData.Margin = new System.Windows.Forms.Padding(3);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(290, 25);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "#data";
            this.lblData.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblData.UseStyleColors = true;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.metroLabel1);
            this.metroPanel5.Controls.Add(this.metroButton5);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(538, 0);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(430, 47);
            this.metroPanel5.TabIndex = 19;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 600);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmMenu";
            this.Text = "Menu do Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MetroPanel metroPanel1;
        private Components.MetroStyleManager metroStyleManager;
        private Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Components.MetroStyleExtender metroStyleExtender;
        private Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.Timer timer1;
        private Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private Controls.MetroButton metroButton5;
        private Controls.MetroPanel metroPanel2;
        private Controls.MetroTile menuAgendamento;
        private Controls.MetroTile menuApartamento;
        private Controls.MetroTile menuUsuarios;
        private Controls.MetroTile menuRelatorios;
        private Controls.MetroTile metroTileSwitch;
        private Controls.MetroTile menuProfissionais;
        private Controls.MetroTile menuVisitantes;
        private Controls.MetroTile menuMoradores;
        private Controls.MetroPanel metroPanel4;
        private Controls.MetroPanel metroPanel3;
        private Controls.MetroLabel lblHorario;
        private Controls.MetroLabel lblData;
        private Controls.MetroPanel metroPanel5;
    }
}