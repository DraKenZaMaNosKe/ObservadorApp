using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ObservadorApp{
    class Conexion{
        public static SqlConnection conn =
            new SqlConnection("Initial Catalog= Observaciones;" +
                " Data Source=localhost; Integrated Security=SSPI;");

        public DataSet ConsulTab(string cliente, string codigo_cli){
            DataSet datSet = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            String consulta = "Select * from " + cliente + " order by " + codigo_cli + " ASC;";
            SqlCommand comando = new SqlCommand(consulta, conn);
            adaptador.SelectCommand = comando;
            conn.Open();
            adaptador.Fill(datSet, cliente);
            conn.Close();
            return datSet;
        }
        
        public SqlDataReader Buscar(string CodConsulta){
            SqlCommand comando = new SqlCommand(CodConsulta, conn);
            conn.Open();
            SqlDataReader lector = comando.ExecuteReader();
            return lector;
        }
    }
}
