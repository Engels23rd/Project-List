using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Listado_de_proyectos.Class
{
    class Conexion
    {

        public static SqlConnection Conectar() 
        {

            //Cadena de conexion
            SqlConnection cn = new SqlConnection("SERVER=THEKRAKEN; DATABASE=project_list;integrated security=true;");

            cn.Open();


            return cn;
        
        
        
        
        }

    }
}
