﻿using PlusCondominios.Bll;
using PlusCondominios.Model;
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

            proprietarioBindingSource.AddNew();
            txtRG.Focus();

            BuscaProprietarios();
        }

        ProprietarioBll proprietarioBll = new ProprietarioBll();

        private void BuscaProprietarios()
        {
            gridProprietario.AutoGenerateColumns = false;
            List<ProprietarioInfo> lstProprietarios = proprietarioBll.ListarPorParametro(new ProprietarioInfo());
            if (lstProprietarios.Count > 0)
            {
                //gridProprietario.DataSource = lstProprietarios;
                proprietarioGridBindingSource.DataSource = lstProprietarios;
                proprietarioGridBindingSource.EndEdit();
                proprietarioGridBindingSource.ResetBindings(false);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProprietarioInfo info = new ProprietarioInfo();

            proprietarioBindingSource.ResetBindings(false);

            ProprietarioInfo current = proprietarioBindingSource.Current as ProprietarioInfo;

            if (!string.IsNullOrEmpty(lblCodigoProprietario.Text))
                info = proprietarioBll.ListarPorCodigo(int.Parse(lblCodigoProprietario.Text));

            if (info == null)
                info = new ProprietarioInfo();

            if (current != null)
            {
                info.PRT_Aluguel = current.PRT_Aluguel;
                info.PRT_Ativo = current.PRT_Ativo;
                info.PRT_Cpf = current.PRT_Cpf;
                info.PRT_Foto = current.PRT_Foto;
                info.PRT_Nome = current.PRT_Nome;
                info.PRT_Rg = current.PRT_Rg;
                info.PRT_Sindico = current.PRT_Sindico;

                if (proprietarioBll.Salvar(info))
                    MetroMessageBox.Show(this, "Registro salvo com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroMessageBox.Show(this, "Erro ao salvar registro. Contate o Administrador do Sistema.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var info = proprietarioGridBindingSource.Current as ProprietarioInfo;
            if (info != null)
            {
                proprietarioBindingSource.DataSource = info;
                proprietarioBindingSource.EndEdit();
                proprietarioBindingSource.ResetBindings(false);
                txtCPF.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Confirma Exclusão do Registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                var info = proprietarioGridBindingSource.Current as ProprietarioInfo;
                if (info != null)
                {
                    proprietarioBindingSource.DataSource = info;
                    proprietarioBindingSource.EndEdit();
                    proprietarioBindingSource.ResetBindings(false);
                    txtCPF.Focus();
                }
            }
        }
    }
}
