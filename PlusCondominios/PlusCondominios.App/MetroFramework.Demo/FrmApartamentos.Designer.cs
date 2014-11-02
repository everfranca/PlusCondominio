namespace MetroFramework.Demo
{
    partial class FrmApartamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.GridVisitantes = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acao = new System.Windows.Forms.DataGridViewButtonColumn();
            this.acao1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVisitantes)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1047, 531);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.AutoScroll = true;
            this.metroTabPage1.Controls.Add(this.metroPanel2);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.HorizontalScrollbar = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Padding = new System.Windows.Forms.Padding(25);
            this.metroTabPage1.Size = new System.Drawing.Size(1039, 483);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Pesquisa";
            this.metroTabPage1.VerticalScrollbar = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.GridVisitantes);
            this.metroPanel2.Controls.Add(this.metroPanel3);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(25, 139);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(989, 319);
            this.metroPanel2.TabIndex = 23;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // GridVisitantes
            // 
            this.GridVisitantes.AllowUserToAddRows = false;
            this.GridVisitantes.AllowUserToDeleteRows = false;
            this.GridVisitantes.AllowUserToResizeColumns = false;
            this.GridVisitantes.AllowUserToResizeRows = false;
            this.GridVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVisitantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF,
            this.Telefone,
            this.acao,
            this.acao1});
            this.GridVisitantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridVisitantes.Location = new System.Drawing.Point(0, 35);
            this.GridVisitantes.MultiSelect = false;
            this.GridVisitantes.Name = "GridVisitantes";
            this.GridVisitantes.ReadOnly = true;
            this.GridVisitantes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridVisitantes.RowTemplate.DefaultCellStyle.NullValue = null;
            this.GridVisitantes.RowTemplate.Height = 50;
            this.GridVisitantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridVisitantes.Size = new System.Drawing.Size(989, 284);
            this.GridVisitantes.TabIndex = 19;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.DefaultCellStyle = dataGridViewCellStyle6;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CPF
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CPF.DefaultCellStyle = dataGridViewCellStyle7;
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 200;
            // 
            // Telefone
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Telefone.DefaultCellStyle = dataGridViewCellStyle8;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 200;
            // 
            // acao
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acao.DefaultCellStyle = dataGridViewCellStyle9;
            this.acao.HeaderText = "Editar";
            this.acao.Name = "acao";
            this.acao.ReadOnly = true;
            this.acao.Text = "Editar";
            this.acao.Width = 250;
            // 
            // acao1
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acao1.DefaultCellStyle = dataGridViewCellStyle10;
            this.acao1.HeaderText = "Excluir";
            this.acao1.Name = "acao1";
            this.acao1.ReadOnly = true;
            this.acao1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acao1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.acao1.Text = "Excluir";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroLabel1);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(989, 35);
            this.metroPanel3.TabIndex = 18;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 3);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(280, 25);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Apartamentos Cadastrados";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnNovo);
            this.metroPanel1.Controls.Add(this.btnPesquisar);
            this.metroPanel1.Controls.Add(this.lblUsuario);
            this.metroPanel1.Controls.Add(this.txtUsuario);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(25, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(989, 114);
            this.metroPanel1.TabIndex = 22;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnNovo
            // 
            this.btnNovo.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNovo.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnNovo.Highlight = true;
            this.btnNovo.Location = new System.Drawing.Point(766, 69);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(215, 35);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "Cadastrar Novo Apartamento";
            this.btnNovo.UseSelectable = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPesquisar.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnPesquisar.Highlight = true;
            this.btnPesquisar.Location = new System.Drawing.Point(766, 28);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(215, 35);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.Text = "Pesquisar Apartamento";
            this.btnPesquisar.UseSelectable = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUsuario.Location = new System.Drawing.Point(3, 3);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(3);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(305, 25);
            this.lblUsuario.TabIndex = 16;
            this.lblUsuario.Text = "Digite o Nome do Apartamento";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUsuario.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(3, 28);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(750, 35);
            this.txtUsuario.TabIndex = 17;
            this.txtUsuario.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroPanel4);
            this.metroTabPage3.HorizontalScrollbar = true;
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Padding = new System.Windows.Forms.Padding(25);
            this.metroTabPage3.Size = new System.Drawing.Size(1034, 492);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Cadastro";
            this.metroTabPage3.VerticalScrollbar = true;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            this.metroTabPage3.Visible = false;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroLabel8);
            this.metroPanel4.Controls.Add(this.metroTextBox6);
            this.metroPanel4.Controls.Add(this.metroButton3);
            this.metroPanel4.Controls.Add(this.metroLabel7);
            this.metroPanel4.Controls.Add(this.metroButton5);
            this.metroPanel4.Controls.Add(this.metroLabel6);
            this.metroPanel4.Controls.Add(this.metroTextBox5);
            this.metroPanel4.Controls.Add(this.metroLabel5);
            this.metroPanel4.Controls.Add(this.metroTextBox4);
            this.metroPanel4.Controls.Add(this.metroLabel4);
            this.metroPanel4.Controls.Add(this.metroTextBox3);
            this.metroPanel4.Controls.Add(this.metroLabel3);
            this.metroPanel4.Controls.Add(this.metroTextBox2);
            this.metroPanel4.Controls.Add(this.metroButton1);
            this.metroPanel4.Controls.Add(this.metroButton2);
            this.metroPanel4.Controls.Add(this.metroLabel2);
            this.metroPanel4.Controls.Add(this.metroTextBox1);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(25, 25);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(984, 442);
            this.metroPanel4.TabIndex = 25;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(661, 69);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(197, 25);
            this.metroLabel8.TabIndex = 33;
            this.metroLabel8.Text = "Apartamento";
            // 
            // metroTextBox6
            // 
            this.metroTextBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTextBox6.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox6.Lines = new string[0];
            this.metroTextBox6.Location = new System.Drawing.Point(659, 94);
            this.metroTextBox6.MaxLength = 32767;
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.PasswordChar = '\0';
            this.metroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox6.SelectedText = "";
            this.metroTextBox6.Size = new System.Drawing.Size(312, 35);
            this.metroTextBox6.TabIndex = 34;
            this.metroTextBox6.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton3.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(128, 197);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(89, 35);
            this.metroButton3.TabIndex = 32;
            this.metroButton3.Text = "Trocar Foto";
            this.metroButton3.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(16, 141);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(82, 25);
            this.metroLabel7.TabIndex = 31;
            this.metroLabel7.Text = "Foto";
            // 
            // metroButton5
            // 
            this.metroButton5.BackgroundImage = global::MetroFramework.Demo.Properties.Resources.usuario;
            this.metroButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton5.Location = new System.Drawing.Point(16, 166);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(106, 101);
            this.metroButton5.TabIndex = 30;
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton5.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(501, 69);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 25);
            this.metroLabel6.TabIndex = 28;
            this.metroLabel6.Text = "Placa";
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTextBox5.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox5.Lines = new string[0];
            this.metroTextBox5.Location = new System.Drawing.Point(501, 94);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.Size = new System.Drawing.Size(152, 35);
            this.metroTextBox5.TabIndex = 29;
            this.metroTextBox5.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(228, 69);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 25);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Veículo";
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTextBox4.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(228, 94);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.Size = new System.Drawing.Size(267, 35);
            this.metroTextBox4.TabIndex = 27;
            this.metroTextBox4.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(16, 69);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 25);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Telefone";
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(16, 94);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.Size = new System.Drawing.Size(206, 35);
            this.metroTextBox3.TabIndex = 25;
            this.metroTextBox3.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(228, 3);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 25);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Nome";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(228, 28);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.Size = new System.Drawing.Size(743, 35);
            this.metroTextBox2.TabIndex = 23;
            this.metroTextBox2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(779, 376);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(192, 35);
            this.metroButton1.TabIndex = 21;
            this.metroButton1.Text = "Cancelar Registro";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(581, 376);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(192, 35);
            this.metroButton2.TabIndex = 20;
            this.metroButton2.Text = "Salvar Registro";
            this.metroButton2.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(16, 3);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 25);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "CPF";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(16, 28);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(206, 35);
            this.metroTextBox1.TabIndex = 17;
            this.metroTextBox1.UseSelectable = true;
            // 
            // FrmApartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 611);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "FrmApartamentos";
            this.Text = "Controle de Apartamentos";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridVisitantes)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MetroTabControl metroTabControl1;
        private Controls.MetroTabPage metroTabPage1;
        private Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.DataGridView GridVisitantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewButtonColumn acao;
        private System.Windows.Forms.DataGridViewButtonColumn acao1;
        private Controls.MetroPanel metroPanel3;
        private Controls.MetroLabel metroLabel1;
        private Controls.MetroPanel metroPanel1;
        private Controls.MetroButton btnNovo;
        private Controls.MetroButton btnPesquisar;
        private Controls.MetroLabel lblUsuario;
        private Controls.MetroTextBox txtUsuario;
        private Controls.MetroTabPage metroTabPage3;
        private Controls.MetroPanel metroPanel4;
        private Controls.MetroLabel metroLabel8;
        private Controls.MetroTextBox metroTextBox6;
        private Controls.MetroButton metroButton3;
        private Controls.MetroLabel metroLabel7;
        private Controls.MetroButton metroButton5;
        private Controls.MetroLabel metroLabel6;
        private Controls.MetroTextBox metroTextBox5;
        private Controls.MetroLabel metroLabel5;
        private Controls.MetroTextBox metroTextBox4;
        private Controls.MetroLabel metroLabel4;
        private Controls.MetroTextBox metroTextBox3;
        private Controls.MetroLabel metroLabel3;
        private Controls.MetroTextBox metroTextBox2;
        private Controls.MetroButton metroButton1;
        private Controls.MetroButton metroButton2;
        private Controls.MetroLabel metroLabel2;
        private Controls.MetroTextBox metroTextBox1;
    }
}