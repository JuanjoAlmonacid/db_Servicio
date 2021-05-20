using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioModel.DTO
{
   public  class Modelo
    {
        private int medidor;
        private string lectura;
        private string direccion;
        private string estacion;
        private string ciudad;
        private string region;
        private string zonaH;

        public int Medidor
        {
            get
            {
                return medidor;
            }

            set
            {
                medidor = value;
            }
        }

        public string Lectura
        {
            get
            {
                return lectura;
            }

            set
            {
                lectura = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Estacion
        {
            get
            {
                return estacion;
            }

            set
            {
                estacion = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return ciudad;
            }

            set
            {
                ciudad = value;
            }
        }

        public string Region
        {
            get
            {
                return region;
            }

            set
            {
                region = value;
            }
        }

        public string ZonaH
        {
            get
            {
                return zonaH;
            }

            set
            {
                zonaH = value;
            }
        }
    }
}
