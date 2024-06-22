using System.Text;

namespace Estudiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CargarAlumnos();
        }
        static void CargarAlumnos()
        {

            List<Estudiante> alumnos = new List<Estudiante>();
            int _principio = 0;
            int _final = 2;

            Estudiante Denika = new Estudiante();
            Denika.NombreDelEstudiante = "Denika Escalante";
            Denika.Matricula = 221206295;
            Denika.Carrera = "Licenciatura en Geologia";
            alumnos.Add(Denika);

            Estudiante Miguel = new Estudiante();
            Miguel.NombreDelEstudiante = "Miguel Morales";
            Miguel.Matricula = 221205130;
            Miguel.Carrera = "Ingeniería en Electrónica";
            alumnos.Add(Miguel);


            bool EstaVacio()
            {
                return alumnos.Count == 0;
            }

            void Eliminar()
            {
                if (EstaVacio())
                {
                    throw new Exception("Lista vacia");
                }
                alumnos.RemoveAt(alumnos.Count - 1);
            }

            void Agregar()
            {

                Console.WriteLine("Ingrese el nombre del estudiante:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la matricula del estudiante:");
                int matricula = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la carrera del estudiante");
                string carrera = Console.ReadLine();

                Estudiante nuevoEstudiante = new Estudiante()
                {
                    NombreDelEstudiante = nombre,
                    Matricula = matricula,
                    Carrera = carrera
                };
                alumnos.Add(nuevoEstudiante);
            }
            void MostrarAlumnos()
            {
                foreach (Estudiante alumno in alumnos)
                {
                    Console.WriteLine($"{alumno}");
                }
            }
            
            MostrarAlumnos();
            Agregar();
            MostrarAlumnos();
            Console.WriteLine("----------Ahora va a eliminar el ultimo dato----------");
            Eliminar();
            MostrarAlumnos();

        }
    }

}
