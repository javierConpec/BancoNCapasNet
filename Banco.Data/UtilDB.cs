using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Data
{
    public static class UtilDB
    {
        public static string CadenaConexion()
        {
            string cadenaConexion = @"Server = localhost\sqlexpress; DataBase=BancoBD; User = APPData; Password = jxvier150604";
                return cadenaConexion;
        }
    }
}
