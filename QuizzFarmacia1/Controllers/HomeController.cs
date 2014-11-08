using QuizzFarmacia1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizzFarmacia1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(empleados far)
        {

            BussinesM Sucursal = new BussinesM(@"C:\Users\Yuthsil\Documents\Visual Studio 2013\Projects\DAW\QuizzFarmacia1\Models\file.csv");


            var usuario = Sucursal.GetEmployeeById(far.NumEmpleado);

            if (usuario != null)
            {
                return View("Resultado", usuario);
            }
            else
            {
                return View("NotFound", usuario);
            }

        }

     [HttpPost]
       
        public ActionResult NotFound()
        {

         //Metodo Nuevo
            ViewBag.errorCode = "NFE0001";

            ViewBag.Description = "Aki no se realiza nada....O no se encuentra";


         //Metodo Antiguo
         /*ViewData ["ErrorCode"]="NFE4560";  
          ViewData  ["Description"] ="La mascota que usted desea buscar no se encuentra"+
          "En la base de datos";*/
            return View();


          }
        


    }
}
