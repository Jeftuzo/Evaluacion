using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    internal class Estudiante
    {
    
        

        public string NombreDelEstudiante { get; set; } = string.Empty;
        public int Matricula { get; set; } = 0;
        public string Carrera { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"El alumno se llama {NombreDelEstudiante}, su matricula es {Matricula} y estudia {Carrera}";
        }




    }
}
