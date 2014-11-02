using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetroFramework.Demo.Model
{
    public class VisitanteInfo
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Veiculo { get; set; }
        public string Placa { get; set; }
        public string Apartamento { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaída { get; set; }
        public string Observacao { get; set; }
    }
}
