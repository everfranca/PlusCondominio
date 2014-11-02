using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Nucleo
{
    public class BaseInfo
    {
        public BaseInfo()
        {
            LoadCollection = true;
            IsDirty = false;
            IsNew = true;
            ErroMessage = string.Empty;
        }
        public BaseInfo(bool loadCollection )
        {
            LoadCollection = loadCollection;
        }
        private bool _isDirty;
        private bool _isNew;
        private bool _loadCollection;
        private string _erroMessage;

        /// <summary>
        /// Identificação do estado da classe(true[Inserção] / false[Edição])
        /// </summary>
        public bool IsNew
        {
            get { return _isNew; }
            set { _isNew = value; }
        }

        public bool IsDirty
        {
            get { return _isDirty; }
            set { _isDirty = value; }
        }

        public bool LoadCollection
        {
            get { return _loadCollection; }
            set { _loadCollection = value; }
        }

        public string ErroMessage
        {
            get { return _erroMessage; }
            set { _erroMessage = value; }
        }
    }
}
