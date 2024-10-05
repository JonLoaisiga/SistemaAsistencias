using System;
using SistemaAsistencias;

namespace Principal
{
    class Program
    {
        //Aqui mostramos la informacion
        public static void Main(string[]args)
        {
            var estudiante1 = new Universidad.Estudiante("Jonathan", 30);
            var estudiante2 = new Universidad.Estudiante("Ana", 30);
            var estudiante3 = new Universidad.Estudiante("Bonnie", 30);

            estudiante1.MostrarInfo(24);
            estudiante2.MostrarInfo(27);
            estudiante3.MostrarInfo(15);
           
        }
    }
}   