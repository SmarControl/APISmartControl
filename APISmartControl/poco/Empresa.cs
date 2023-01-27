using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISmartControl.poco
{
    public class Empresa
    {
        public int ID { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Fechamento { get; set; }
        public DateTime Data_Edicao { get; set; }
        public string status { get; set; }
        public string ultima_atualizacao { get; set; }
        public string cnpj { get; set; }
        public string tipo { get; set; }
        public string porte { get; set; }
        public string nome_fantasia { get; set; }
        public string abertura { get; set; }
        public string Empresa_ID { get; set; }
    }
}
