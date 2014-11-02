using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Nucleo
{
    public class NovaInstanciaClasse
    {
        Mapeador mapeador = new Mapeador();

        public T NovaInstancia<T>(SqlDataReader dr) where T : new()
        {
            var obj = Activator.CreateInstance<T>();
            mapeador.DefineInstanciaClasse(obj, dr);
            if (obj is BaseInfo)
            {
                (obj as BaseInfo).IsDirty = false;
                (obj as BaseInfo).IsNew = false;
            }
            return obj;
        }
    }
}
