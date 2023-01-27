using APISmartControl.Dados;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISmartControl.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipamentoController : Controller
    {
        [HttpGet]
        public string ListarEquipamento()
        {
            Equipamento oEquipamento = new Equipamento();
            return oEquipamento.Listar();
        }
        [HttpPost]
        public void InsertEquipamento(
             DateTime Data_Inicio,
             DateTime Data_fechamento,
             DateTime Data_Edicao,
             string device,
             string manufacturer,
             string deviceName,
             string Version,
             string platform,
             string idiom,
             string deviceType,
             string Imei)
        {
            string Retorno = string.Empty; 
            try
            {
                Equipamento oEquipamento = new Equipamento();
                Retorno = oEquipamento.Insert_Equipamento(  
                                                            Data_Inicio,
                                                            Data_fechamento,
                                                            Data_Edicao,
                                                            device,
                                                            manufacturer,
                                                            deviceName,
                                                            Version,
                                                            platform,
                                                            idiom,
                                                            deviceType,
                                                            Imei
                                                            );

            }
            catch (Exception)
            {

                throw;
            }
            //return Retorno;
        }
    }
}
