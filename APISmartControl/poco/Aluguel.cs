using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISmartControl.poco
{
    public class Aluguel
    {
        public int ID { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Fechamento { get; set; }
        public DateTime Data_Edicao { get; set; }
        public int Empresa_ID { get; set; }
        public int Equipamento_ID { get; set; }
    }
}
