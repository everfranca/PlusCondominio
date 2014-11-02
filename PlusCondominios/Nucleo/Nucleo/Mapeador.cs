using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Nucleo
{
    public class Mapeador
    {
        public void DefineInstanciaClasse(object classInstance, DbDataReader dataReader)
        {
            AtributoCampo atributoCustomizado = null;
            int ordinal = 0;
            object[] attributes;
            PropertyInfo[] itemTipoPropriedade = classInstance.GetType().GetProperties();
            PropertyInfo propriedade;

            var columns = new List<string>();

            for (int i = 0; i < dataReader.FieldCount; i++)
            {
                columns.Add(dataReader.GetName(i).ToUpper());
            }

            try
            {
                for (int i = 0; i < itemTipoPropriedade.Length; i++)
                {
                    propriedade = itemTipoPropriedade[i];
                    if (propriedade.PropertyType.IsSubclassOf(typeof(BaseInfo)))
                    {
                        object internalClass = Activator.CreateInstance(propriedade.PropertyType);
                        DefineInstanciaClasse(internalClass, dataReader);
                        propriedade.SetValue(classInstance, internalClass, null);
                    }
                    else
                    {
                        attributes = propriedade.GetCustomAttributes(typeof(AtributoCampo), true);
                        if (attributes != null && attributes.Length == 1)
                        {
                            atributoCustomizado = attributes[0] as AtributoCampo;
                            if (atributoCustomizado != null && atributoCustomizado.NomeCampo.Length > 0)
                            {
                                try
                                {
                                    if (columns.Exists(p => p == atributoCustomizado.NomeCampo.ToUpper()))
                                        ordinal = dataReader.GetOrdinal(atributoCustomizado.NomeCampo);
                                    else
                                        ordinal = -1;
                                }
                                catch
                                {
                                    ordinal = -1;
                                }
                                if (ordinal >= 0)
                                {
                                    object value = dataReader.GetValue(ordinal) == DBNull.Value ? string.Empty : dataReader.GetValue(ordinal);
                                    try
                                    {
                                        propriedade.SetValue(classInstance, value, null);
                                    }
                                    catch
                                    {
                                        if (propriedade.PropertyType == typeof(DateTime))
                                            propriedade.SetValue(classInstance, DateTime.MinValue, null);
                                        else if (propriedade.PropertyType == typeof(Int32))
                                            propriedade.SetValue(classInstance, 0, null);
                                        else if (propriedade.PropertyType == typeof(decimal))
                                            propriedade.SetValue(classInstance, new decimal(), null);
                                        else if (propriedade.PropertyType == typeof(DateTime?))
                                            propriedade.SetValue(classInstance, default(DateTime), null);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                throw new Exception(string.Format("Verifique o tipo da propriedade [{0}] na classe [{1}], pois {2}.", atributoCustomizado.NomeCampo, classInstance.GetType().Name, exc.Message));
            }
            finally
            {
                atributoCustomizado = null;
                itemTipoPropriedade = null;
                propriedade = null;
            }
        }
    }
}
