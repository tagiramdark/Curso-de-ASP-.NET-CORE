using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Curso_de_ASP_.NET_Core.Models;
namespace Curso_de_ASP_.NET_Core.Controllers
{


    public class EscuelaController:Controller
    {
        public IActionResult Index(){
           var escuela =new Escuela("Platzi School",2005);         
          escuela.Ciudad="Bogota";
          escuela.Pais="Colombia";
          escuela.Dirección="Sin domicilio";
          
          
           
            return View(escuela);
        }
    }

}