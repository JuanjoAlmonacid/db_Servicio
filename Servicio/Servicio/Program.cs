using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioModel.DAL;
using ServicioModel.DTO;
using System.Reflection;

namespace TerminatorsApp
{
    class Program
    {
        static Modelo dal = new modelo();

        static void IngresarMedidor()
        {
            string nroMedidor, fecha;
            Tipo tipo;
            

            do
            {
                Console.WriteLine("Ingrese nro de medidor");
                nroMedidor = Console.ReadLine().Trim();
                if (nroMedidor.Length != 10)
                {
                    Console.WriteLine("El nro de medidor debe ser de largo 10");
                    nroMedidor = string.Empty;
                }
                else if (dal.FindByNroMedidor(nroMedidor) != null)
                {
                    Console.WriteLine("el medidor ya esta en uso");
                }

            } while (nroMedidor == string.Empty);
            string resp;

            do
            {
                Console.WriteLine("Ingrese fecha ");
                fecha = Console.ReadLine().Trim();

          
              

        static void MostrarMedidor()
        {

            List<Medidor> medidors = dal.GetALL();
            medidors.ForEach(Console.WriteLine);

        }

   

        static Boolean Menu()
        {
            bool continuar = true;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("medidores ev2");
            Console.WriteLine("1.Ingresar medidor\n2.Mostrar medidor" +
                "\n0.Salir");
            string opcion = Console.ReadLine().Trim();
            switch (opcion)
            {
                case "1":
                    IngresarMedidor();
                    break;
                case "2":
                    MostrarMedidor();
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("eror al ingresar datos");
                    break;
            }
            return continuar;
        }

        static void Main(string[] args)
        {
            while (Menu()) ;

        }
    }
}