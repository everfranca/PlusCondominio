using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nucleo
{
    /// <summary>
    /// Nome do campo na Tabela e/ou Procedure
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class AtributoCampo : Attribute
    {
        public bool PK { get; set; }

        public int TamanhoCampo { get; set; }

        public string NomeCampo { get; set; }

        public bool PermiteNulo { get; set; }

        public AtributoCampo(bool pk, string nomeCampo, int tamanhoCampo, bool permiteNulo)
        {
            PK = pk;
            NomeCampo = nomeCampo;
            TamanhoCampo = tamanhoCampo;
            PermiteNulo = permiteNulo;
        }
        public AtributoCampo(string nomeCampo, int tamanhoCampo, bool permiteNulo)
        {
            NomeCampo = nomeCampo;
            TamanhoCampo = tamanhoCampo;
            PermiteNulo = permiteNulo;
        }
    }
}
