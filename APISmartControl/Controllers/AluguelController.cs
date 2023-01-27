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

    public class AluguelController : Controller
    {
        [HttpGet]
        public string ListarAluguel()
        {
            Aluguel oAluguel = new Aluguel();
            return oAluguel.Listar();
        }


    }
}
