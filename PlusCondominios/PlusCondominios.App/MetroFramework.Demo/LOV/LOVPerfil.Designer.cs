namespace MetroFramework.Demo.LOV
{
    partial class LOVPerfil
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
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.GridPerfis = new System.Windows.Forms.DataGridView();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPerfis)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(18, 18);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(229, 25);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Descrição do Perfil";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescricao.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(18, 43);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.Size = new System.Drawing.Size(552, 35);
            this.txtDescricao.TabIndex = 19;
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.GridPerfis);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtDescricao);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(591, 241);
            this.metroPanel1.TabIndex = 20;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // GridPerfis
            // 
            this.GridPerfis.AllowUserToAddRows = false;
            this.GridPerfis.AllowUserToDeleteRows = false;
            this.GridPerfis.AllowUserToResizeColumns = false;
            this.GridPerfis.AllowUserToResizeRows = false;
            this.GridPerfis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPerfis.Location = new System.Drawing.Point(18, 84);
            this.GridPerfis.MultiSelect = false;
            this.GridPerfis.Name = "GridPerfis";
            this.GridPerfis.ReadOnly = true;
            this.GridPerfis.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridPerfis.RowTemplate.DefaultCellStyle.NullValue = null;
            this.GridPerfis.RowTemplate.Height = 50;
            this.GridPerfis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPerfis.Size = new System.Drawing.Size(552, 143);
            this.GridPerfis.TabIndex = 21;
            // 
            // LOVPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 342);
            this.Controls.Add(this.metroPanel1);
            this.Name = "LOVPerfil";
            this.Text = "Perfis ";
            this.Load += new System.EventHandler(this.LOVPerfil_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPerfis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MetroLabel metroLabel2;
        private Controls.MetroTextBox txtDescricao;
        private Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView GridPerfis;
    }
}