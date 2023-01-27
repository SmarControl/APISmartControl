using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISmartControl.poco
{
    public class Endereco
    {
        public int ID { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Fechamento { get; set; }
        public DateTime Data_Edicao { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        public string Email { get; set; }
        public string telefone { get; set; }
        public string EFR { get; set; }
        public int Empresa_ID { get; set; }
    }
}
