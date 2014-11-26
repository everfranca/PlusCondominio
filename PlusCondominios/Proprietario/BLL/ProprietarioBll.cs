using System;
using System.Collections.Generic;
using PlusCondominios.Model;
using PlusCondominios.Dal;
using System.Transactions;
namespace PlusCondominios.Bll
{
    public class ProprietarioBll : IProprietarioBll
    {
        class Acessor
        {
            private IProprietarioDal _ProprietarioDal;
            internal IProprietarioDal ProprietarioDal
            {
                get
                {
                    if (_ProprietarioDal == null)
                        _ProprietarioDal = new ProprietarioDal();
                    return _ProprietarioDal;
                }

            }

            internal ProprietarioTelefoneBll telefoneBll = new ProprietarioTelefoneBll();
            internal ProprietarioVeiculoBll veiculoBll = new ProprietarioVeiculoBll();
        }

        private bool ValidaProprietario(ProprietarioInfo proprietarioInfo)
        {
            bool sucesso = true;
            try
            {
                if (proprietarioInfo == null)
                    throw new Exception("Objeto ProprietarioInfo é nulo");
            }
            catch
            {
                sucesso = false;
            }
            return sucesso;
        }
        public bool Salvar(ProprietarioInfo proprietarioInfo)
        {
            Acessor acessor = new Acessor();
            bool sucesso = true;
            try
            {
                using (TransactionScope transacao = new TransactionScope())
                {
                    if (ValidaProprietario(proprietarioInfo))
                    {
                        if (proprietarioInfo.IsNew)
                            sucesso = acessor.ProprietarioDal.Inserir(proprietarioInfo);
                        else if (proprietarioInfo.IsDirty)
                            sucesso = acessor.ProprietarioDal.Editar(proprietarioInfo);

                        if (sucesso)
                        {
                            ProprietarioVeiculoInfo veiculoInfo = new ProprietarioVeiculoInfo();
                            if (proprietarioInfo.PVE_Codigo > 0)
                                veiculoInfo = acessor.veiculoBll.ListarPorCodigo(proprietarioInfo.PVE_Codigo);

                            veiculoInfo.PVE_Placa = proprietarioInfo.PVE_Placa;
                            veiculoInfo.PVE_Veiculo = proprietarioInfo.PVE_Veiculo;
                            veiculoInfo.PVE_PRT_Codigo = proprietarioInfo.PRT_Codigo;

                            sucesso = acessor.veiculoBll.Salvar(veiculoInfo);
                            if (!sucesso)
                                return sucesso;
                        }
                        
                        if(sucesso)
                        {
                            ProprietarioTelefoneInfo telefoneInfo = new ProprietarioTelefoneInfo();
                            if (proprietarioInfo.PTE_Codigo > 0)
                                telefoneInfo = acessor.telefoneBll.ListarPorCodigo(proprietarioInfo.PTE_Codigo);

                            telefoneInfo.PTE_PRT_Codigo = proprietarioInfo.PRT_Codigo;
                            telefoneInfo.PTE_Telefone = proprietarioInfo.PTE_Telefone;

                            sucesso = acessor.telefoneBll.Salvar(telefoneInfo);
                            if (!sucesso)
                                return sucesso;
                        }
                    }
                    transacao.Complete();
                }
                return sucesso;
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message, exc);
            }
            finally
            {
                acessor = null;

            }
        }

        public bool Excluir(int prt_codigo)
        {
            Acessor acessor = new Acessor();
            try
            {
                return acessor.ProprietarioDal.Excluir(prt_codigo);
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message, exc);
            }
            finally
            {
                acessor = null;
            }
        }

        public List<ProprietarioInfo> ListarPorParametro(ProprietarioInfo proprietarioInfo)
        {
            Acessor acessor = new Acessor();
            try
            {
                return acessor.ProprietarioDal.ListarPorParametro(proprietarioInfo);
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message, exc);
            }
            finally
            {
                acessor = null;
            }
        }

        public ProprietarioInfo ListarPorCodigo(int prt_codigo)
        {
            Acessor acessor = new Acessor();
            ProprietarioInfo proprietarioInfo = new ProprietarioInfo();
            try
            {
                return proprietarioInfo = acessor.ProprietarioDal.ListarPorCodigo(prt_codigo);
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message, exc);
            }
            finally
            {
                acessor = null;
            }
        }
    }
}