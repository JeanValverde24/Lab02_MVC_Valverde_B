using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab02_Mvc_Valverde_B.Models;

namespace Lab02_Mvc_Valverde_B.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult MostrarUno()
        {
            ClsPersonas objPersona = new ClsPersonas();

            objPersona.DNI = "123456789";
            objPersona.Apellido = "Valverde";
            objPersona.Nombre = "Jean";
            objPersona.Sexo = true;
            objPersona.Edad = 21;
            objPersona.Peso = 80;
            objPersona.Talla = 1.52;
            return View(objPersona);
         
        }
        public ActionResult ListarTodo()
        {
            List<ClsPersonas> Lista = new List<ClsPersonas>();
            ClsPersonas objPersona1 = new ClsPersonas();

            objPersona1.DNI = "123456789";
            objPersona1.Apellido = "Valverde";
            objPersona1.Nombre = "Jean";
            objPersona1.Sexo = true;
            objPersona1.Edad = 21;
            objPersona1.Peso = 80;
            objPersona1.Talla = 1.70;

            Lista.Add(objPersona1);

            ClsPersonas objPersona2 = new ClsPersonas();

            objPersona2.DNI = "1122333";
            objPersona2.Apellido = "Cano";
            objPersona2.Nombre = "Sucso";
            objPersona2.Sexo = false;
            objPersona2.Edad = 21;
            objPersona2.Peso = 65;
            objPersona2.Talla = 1.80;

            Lista.Add(objPersona2);

            ClsPersonas objPersona3 = new ClsPersonas();

            objPersona3.DNI = "31313132";
            objPersona3.Apellido = "Chambilla";
            objPersona3.Nombre = "Josue";
            objPersona3.Sexo = false;
            objPersona3.Edad = 21;
            objPersona3.Peso = 60;
            objPersona3.Talla = 1.75;

            Lista.Add(objPersona3);

            ClsPersonas objPersona4 = new ClsPersonas();

            objPersona4.DNI = "2221122";
            objPersona4.Apellido = "Rivera";
            objPersona4.Nombre = "Jonny";
            objPersona4.Sexo = true;
            objPersona4.Edad = 21;
            objPersona4.Peso = 66;
            objPersona4.Talla = 1.85;

            Lista.Add(objPersona4);

            ClsPersonas objPersona5 = new ClsPersonas();

            objPersona5.DNI = "2221122";
            objPersona5.Apellido = "Jarro";
            objPersona5.Nombre = "Josue";
            objPersona5.Sexo = true;
            objPersona5.Edad = 21;
            objPersona5.Peso = 69;
            objPersona5.Talla = 1.79;

            Lista.Add(objPersona5);

            return View(Lista);
        }
    }
}