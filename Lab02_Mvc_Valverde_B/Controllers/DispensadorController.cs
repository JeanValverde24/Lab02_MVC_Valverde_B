using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab02_Mvc_Valverde_B.Models;

namespace Lab02_Mvc_Valverde_B.Controllers
{
    public class DispensadorController : Controller
    {
        // GET: Dispensador
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularBilletes(ClsDispensador objDispensador)
        {
            if (objDispensador.monto > 0)
            {
                objDispensador.b100=Convert.ToInt32(objDispensador.monto/100);
                objDispensador.b50 = Convert.ToInt32(objDispensador.monto%100)/50;
                objDispensador.b20 = Convert.ToInt32((objDispensador.monto % 100)%50) / 20;
                objDispensador.b10 = Convert.ToInt32(((objDispensador.monto % 100) % 50)%20) / 10;
                objDispensador.b5 = Convert.ToInt32((((objDispensador.monto % 100) % 50) % 20) % 10)/5;
                objDispensador.b2 = Convert.ToInt32(((((objDispensador.monto % 100) % 50) % 20) % 10) % 5)/2;
                objDispensador.b1 = Convert.ToInt32((((((objDispensador.monto % 100) % 50) % 20) % 10) % 5) % 2)/1;
                objDispensador.b050 = (((((((objDispensador.monto % 100) % 50) % 20) % 10) % 5) % 2) % 1) / 0.5;
                objDispensador.b020 =((((((((objDispensador.monto % 100) % 50) % 20) % 10) % 5) % 2) % 1) % 0.5) / 0.2;
                objDispensador.b010 = (((((((((objDispensador.monto % 100) % 50) % 20) % 10) % 5) % 2) % 1)% 0.5) % 0.2) /0.1;
                objDispensador.cantidad = Convert.ToInt32(objDispensador.b100 + objDispensador.b50 + objDispensador.b20 + objDispensador.b10 + objDispensador.b5 + objDispensador.b2 + objDispensador.b1 +
                    objDispensador.b050 + objDispensador.b020 + objDispensador.b010);
            }
            else
            {
                Response.Write("<script language=javascript>alert('Ingrese monto correcto');</script>");
                return View("Index");
            }
            return View("CalcularBilletes", objDispensador);
        }
    }
}