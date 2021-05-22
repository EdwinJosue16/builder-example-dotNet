using System;
using System.Web.Mvc;
using Laboratorio3.Models;

namespace Laboratorio3.Controllers
{
    public class CalculadoraIMCController : Controller
    {
        
        public ActionResult ResultadoIMC()
        {
            PersonaModel[] personas = new PersonaModel[30];
            Random rnd = new Random();

            for (int i = 0; i < personas.Length; ++i)
            {
                //personas[i] = new PersonaModel.PersonaModelBuilder(i).setEdadMayor(18).setSalario(1500000);
                //.setPeso(rnd.NextDouble() * (150.0 - 20.0) + 20.0 ).setEstatura(rnd.NextDouble() * (2.0 - 1.0) + 1.0).build();

                personas[i].IMC = personas[i].Peso / (personas[i].Estatura * personas[i].Estatura);
            }



            ViewBag.personas = personas;

            return View();
        }
    }
}