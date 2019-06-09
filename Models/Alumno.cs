using System;
using System.Collections.Generic;

namespace Curso_de_ASP_.NET_Core.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
    }
}