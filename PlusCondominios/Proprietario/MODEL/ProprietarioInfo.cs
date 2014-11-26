using Nucleo;
using System;
using System.Collections.Generic;
namespace PlusCondominios.Model
{
    public class ProprietarioInfo : BaseInfo
    {
        public ProprietarioInfo()
        { }

        private int _PRT_Codigo;
        private string _PRT_Cpf;
        private string _PRT_Rg;
        private string _PRT_Nome;
        private string _PRT_Foto;
        private bool _PRT_Ativo;
        private bool _PRT_Sindico;
        private bool _PRT_Aluguel;

        [AtributoCampo(true, "PRT_Codigo", 4, false)]
        public int PRT_Codigo
        {
            get { return _PRT_Codigo; }
            set
            {
                if (_PRT_Codigo != value)
                    IsDirty = true;
                _PRT_Codigo = value;
            }
        }

        [AtributoCampo("PRT_Cpf", 20, true)]
        public string PRT_Cpf
        {
            get { return _PRT_Cpf; }
            set
            {
                if (_PRT_Cpf != value)
                    IsDirty = true;
                _PRT_Cpf = value;
            }
        }

        [AtributoCampo("PRT_Rg", 20, true)]
        public string PRT_Rg
        {
            get { return _PRT_Rg; }
            set
            {
                if (_PRT_Rg != value)
                    IsDirty = true;
                _PRT_Rg = value;
            }
        }

        [AtributoCampo("PRT_Nome", 100, true)]
        public string PRT_Nome
        {
            get { return _PRT_Nome; }
            set
            {
                if (_PRT_Nome != value)
                    IsDirty = true;
                _PRT_Nome = value;
            }
        }

        [AtributoCampo("PRT_Foto", 300, true)]
        public string PRT_Foto
        {
            get { return _PRT_Foto; }
            set
            {
                if (_PRT_Foto != value)
                    IsDirty = true;
                _PRT_Foto = value;
            }
        }

        [AtributoCampo("PRT_Ativo", 1, true)]
        public bool PRT_Ativo
        {
            get { return _PRT_Ativo; }
            set
            {
                if (_PRT_Ativo != value)
                    IsDirty = true;
                _PRT_Ativo = value;
            }
        }

        [AtributoCampo("PRT_Sindico", 1, true)]
        public bool PRT_Sindico
        {
            get { return _PRT_Sindico; }
            set
            {
                if (_PRT_Sindico != value)
                    IsDirty = true;
                _PRT_Sindico = value;
            }
        }

        [AtributoCampo("PRT_Aluguel", 1, true)]
        public bool PRT_Aluguel
        {
            get { return _PRT_Aluguel; }
            set
            {
                if (_PRT_Aluguel != value)
                    IsDirty = true;
                _PRT_Aluguel = value;
            }
        }

        //---Veículo - TIRAR DAQUI DPS ISSO È KO
        [AtributoCampo(true, "PVE_Codigo", 4, false)]
        public int PVE_Codigo { get; set; }
        [AtributoCampo("PVE_Placa", 10, true)]
        public string PVE_Placa { get; set; }
        [AtributoCampo("PVE_PRT_Codigo", 4, false)]
        public int PVE_PRT_Codigo { get; set; }
        [AtributoCampo("PVE_Veiculo", 50, true)]
        public string PVE_Veiculo { get; set; }

        //---Telefone - TIRAR ESSE TBM
        [AtributoCampo(true, "PTE_Codigo", 4, false)]
        public int PTE_Codigo { get; set; }
        [AtributoCampo("PTE_PRT_Codigo", 4, false)]
        public int PTE_PRT_Codigo { get; set; }
        [AtributoCampo("PTE_Telefone", 15, true)]
        public string PTE_Telefone { get; set; }

        public string Veiculo
        {
            get { return PVE_Placa + "-" + PVE_Veiculo; }
        }
    }
}