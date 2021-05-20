using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioModel.DTO;
using System.IO;

namespace ServiceModel.DAL
{
    public class MedidorConsumo : MedidorTrafico
    {

        private MedidorConsumo()
        {

        }

        private static MedidorTrafico instancia;
        
        public static MedidorTrafico GetInstancia()
        {
            if (instancia == null)
                instancia = new MedidorConsumo();
            return instancia;
        }




        private string archivo = Directory.GetCurrentDirectory()
            + Path.DirectorySeparatorChar + "mensajes.csv";


        public List<Mensaje> GetAll()
        {
            List<Mensaje> mensajes = new List<Mensaje>();
            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    string texto = null;
                    do
                    {
                        texto = reader.ReadLine();
                        if (texto != null)
                        {
                            
                            string[] textoArray = texto.Split(';');
                            Mensaje m = new Mensaje()
                            {
                                Nombre = textoArray[0],
                                Detalle = textoArray[1],
                                Tipo = textoArray[2]
                            };
                            mensajes.Add(m);
                        }


                    } while (texto != null);
                }
            }
            catch (IOException ex)
            {

            }

            return mensajes;
        }

        public void Save(Mensaje m)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo, true))
                {
                    writer.WriteLine(m);
                    writer.Flush();
                }


            }
            catch (IOException ex)
            {

            }
        }
    }
}