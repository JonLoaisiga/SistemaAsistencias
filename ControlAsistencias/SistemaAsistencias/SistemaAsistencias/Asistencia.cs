using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistencias
{
   public static class Extension
    {
        public static void MostrarInfo(this Universidad.Estudiante estudiante, int Asistencias)
        {
            //Calculo de Porcentaje
            double porcentajeAsistencia = Universidad.Estudiante.Asistencia.CalcularAsistencias(estudiante.SesionesTotales,Asistencias);

            //Verificar el Minimo
            bool cumpleMinimo = Universidad.Estudiante.Asistencia.ComprobarMinimo(porcentajeAsistencia);

            //Registrar la informacion
            Console.WriteLine($"Nombre {estudiante.Nombre}");
            Console.WriteLine($"Asistencias: {Asistencias}/{estudiante.SesionesTotales}");
            Console.WriteLine($"Porcentaje: ({porcentajeAsistencia:F2}%)");

            // Verificar Condicion
            if ( cumpleMinimo )
            {
                Console.WriteLine("El estudiante cumple con el minimo de Asistencia");
                Console.WriteLine("Aprobado");

            }else
            {
                Console.WriteLine("El estudiante no cumple con el minimo de Asistencia");
                Console.WriteLine("Reprobado");
            }
        }
    }
}
