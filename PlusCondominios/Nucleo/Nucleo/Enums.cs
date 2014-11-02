using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Nucleo
{
    public enum ConexoesBanco { PlusCondominios };

    public enum DiasSemana
    {
        [Description("Domingo")]
        Domingo = 1,
        [Description("Segunda")]
        Segunda = 2,
        [Description("Terça")]
        Terca = 3,
        [Description("Quarta")]
        Quarta = 4,
        [Description("Quinta")]
        Quinta = 5,
        [Description("Sexta")]
        Sexta = 6,
        [Description("Sábado")]
        Sabado = 7
    };
}
