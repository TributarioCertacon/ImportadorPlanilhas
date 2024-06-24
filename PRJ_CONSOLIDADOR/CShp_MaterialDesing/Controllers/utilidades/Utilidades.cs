using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.utilidades
{
    class Utilidades
    {
        static public string GetConnectionString()
        {
            return "Data Source=192.168.0.223; Initial Catalog=PETZ;user=aplicacao; pwd=certa@2022";
        }


    }
}
