using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Nucleo
{
    public class StoredProcedure : BaseDal
    {
        public StoredProcedure(String storedProcedure, List<SqlParameter> param, ConexoesBanco banco)
            : base(banco)
        {
            Sql = new SqlCommand(storedProcedure);
            Sql.CommandType = CommandType.StoredProcedure;
            Sql.Parameters.Clear();
            if (param != null)
            {
                foreach (SqlParameter item in param)
                {
                    Sql.Parameters.Add(item);
                }
            }

        }
    }
}
