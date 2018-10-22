using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ObservadorApp{
    class Conexion{
        public static SqlConnection conn = new SqlConnection("Initial Catalog= Observaciones; Data Source=localhost; Integrated Security=SSPI;");
        
        public SqlDataReader Buscar(string CodConsulta){
            SqlCommand comando = new SqlCommand(CodConsulta, conn);
            conn.Open();
            SqlDataReader lector = comando.ExecuteReader();
            return lector;
        }

    }
}
