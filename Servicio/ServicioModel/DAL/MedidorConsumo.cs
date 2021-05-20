using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModel.DAL
{
    
    public class Service
    {
        public static Mensajes CreateDal()
        {
            return Mensajes.GetInstancia();
        }

    }
}
