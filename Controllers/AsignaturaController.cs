using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Curso_de_ASP_.NET_Core.Models;
namespace Curso_de_ASP_.NET_Core.Controllers
{


    public class AsignaturaController:Controller
    {
        public IActionResult Index(){
           var asignatura=new Asignatura{
               Nombre="Programacion"
           };

           return View(asignatura);
        }
    }

}