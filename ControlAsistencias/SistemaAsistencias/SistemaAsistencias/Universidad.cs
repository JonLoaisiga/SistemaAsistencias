using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistencias
{
    public class Universidad
    {
        //Clase Anidada a Universidad
        public class Estudiante
        {
            public string Nombre { get; set; }
            public int SesionesTotales { get; set; }
            public double Asistencias {  get; private set; }

            public Estudiante(string nombre, int sesionesTotales)
            {
                this.Nombre = nombre;
                this.SesionesTotales = sesionesTotales;
                this.Asistencias = 0;
            }

            //Metodo para las Asistencias
            public void RegistrarAsistencias(int sesiones)
            {
                this.Asistencias += sesiones;
            }

            //Clase Interna de la Asistencia
            internal class Asistencia
            {
                public static double CalcularAsistencias(int sesionesTotales, int asistencias)
                {
                    return (double)asistencias / sesionesTotales * 100;
                }

                //Verificar Minimo de Asistencia
                public static bool ComprobarMinimo(double porcentaje, double minimo = 75.0)
                {
                    return porcentaje >= minimo; 
                }
            }
        }
    }
}
