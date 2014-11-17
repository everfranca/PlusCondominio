﻿namespace MetroFramework.Demo
{
    partial class FrmUsuarios
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPerfil = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnSalva = new MetroFramework.Controls.MetroButton();
            this.GridUsuarios = new System.Windows.Forms.DataGridView();
            this.lblCodPerfil = new MetroFramework.Controls.MetroLabel();
            this.lblCodUsuario = new MetroFramework.Controls.MetroLabel();
            this.lblCodEmpresa = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 82);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 25);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUsuario.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(23, 107);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(206, 35);
            this.txtUsuario.TabIndex = 19;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(235, 82);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 25);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSenha.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(235, 107);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.Size = new System.Drawing.Size(206, 35);
            this.txtSenha.TabIndex = 21;
            this.txtSenha.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(23, 148);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 25);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Perfil";
            // 
            // txtPerfil
            // 
            this.txtPerfil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPerfil.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPerfil.Lines = new string[0];
            this.txtPerfil.Location = new System.Drawing.Point(23, 173);
            this.txtPerfil.MaxLength = 32767;
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.PasswordChar = '\0';
            this.txtPerfil.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPerfil.SelectedText = "";
            this.txtPerfil.Size = new System.Drawing.Size(354, 35);
            this.txtPerfil.TabIndex = 23;
            this.txtPerfil.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(383, 178);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(58, 23);
            this.metroButton1.TabIndex = 24;
            this.metroButton1.Text = "Buscar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(23, 217);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(306, 25);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(23, 242);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(418, 35);
            this.txtEmail.TabIndex = 26;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnCancelar.Highlight = true;
            this.btnCancelar.Location = new System.Drawing.Point(656, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(192, 35);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar Registro";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSalva.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnSalva.Highlight = true;
            this.btnSalva.Location = new System.Drawing.Point(458, 242);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(192, 35);
            this.btnSalva.TabIndex = 27;
            this.btnSalva.Text = "Salvar Registro";
            this.btnSalva.UseSelectable = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // GridUsuarios
            // 
            this.GridUsuarios.AllowUserToAddRows = false;
            this.GridUsuarios.AllowUserToDeleteRows = false;
            this.GridUsuarios.AllowUserToResizeColumns = false;
            this.GridUsuarios.AllowUserToResizeRows = false;
            this.GridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUsuarios.Location = new System.Drawing.Point(23, 283);
            this.GridUsuarios.Name = "GridUsuarios";
            this.GridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUsuarios.Size = new System.Drawing.Size(824, 214);
            this.GridUsuarios.TabIndex = 29;
            this.GridUsuarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridUsuarios_CellMouseClick);
            // 
            // lblCodPerfil
            // 
            this.lblCodPerfil.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCodPerfil.Location = new System.Drawing.Point(88, 148);
            this.lblCodPerfil.Margin = new System.Windows.Forms.Padding(3);
            this.lblCodPerfil.Name = "lblCodPerfil";
            this.lblCodPerfil.Size = new System.Drawing.Size(40, 25);
            this.lblCodPerfil.TabIndex = 30;
            this.lblCodPerfil.Visible = false;
            // 
            // lblCodUsuario
            // 
            this.lblCodUsuario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCodUsuario.Location = new System.Drawing.Point(157, 148);
            this.lblCodUsuario.Margin = new System.Windows.Forms.Padding(3);
            this.lblCodUsuario.Name = "lblCodUsuario";
            this.lblCodUsuario.Size = new System.Drawing.Size(40, 25);
            this.lblCodUsuario.TabIndex = 31;
            this.lblCodUsuario.Visible = false;
            // 
            // lblCodEmpresa
            // 
            this.lblCodEmpresa.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCodEmpresa.Location = new System.Drawing.Point(235, 148);
            this.lblCodEmpresa.Margin = new System.Windows.Forms.Padding(3);
            this.lblCodEmpresa.Name = "lblCodEmpresa";
            this.lblCodEmpresa.Size = new System.Drawing.Size(40, 25);
            this.lblCodEmpresa.TabIndex = 32;
            this.lblCodEmpresa.Visible = false;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 520);
            this.Controls.Add(this.lblCodEmpresa);
            this.Controls.Add(this.lblCodUsuario);
            this.Controls.Add(this.lblCodPerfil);
            this.Controls.Add(this.GridUsuarios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtPerfil);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtUsuario);
            this.Name = "FrmUsuarios";
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MetroLabel metroLabel2;
        private Controls.MetroTextBox txtUsuario;
        private Controls.MetroLabel metroLabel1;
        private Controls.MetroTextBox txtSenha;
        private Controls.MetroLabel metroLabel3;
        private Controls.MetroTextBox txtPerfil;
        private Controls.MetroButton metroButton1;
        private Controls.MetroLabel metroLabel4;
        private Controls.MetroTextBox txtEmail;
        private Controls.MetroButton btnCancelar;
        private Controls.MetroButton btnSalva;
        private System.Windows.Forms.DataGridView GridUsuarios;
        private Controls.MetroLabel lblCodPerfil;
        private Controls.MetroLabel lblCodUsuario;
        private Controls.MetroLabel lblCodEmpresa;
    }
}