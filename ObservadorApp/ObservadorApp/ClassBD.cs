using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ObservadorApp
{
    class ClassBD
    {        
        public static SqlConnection conn = new SqlConnection(
             new SqlConnectionStringBuilder()
                  {
                    DataSource = "LAPDELALIYO",
                    InitialCatalog = "Observaciones",
                    UserID = "sa",
                    Password = "root"
                  }.ConnectionString
        );

        public DataSet ConsulTab(string tabla, string campo)
        {            
            DataSet datSet = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            String consulta = " select * from " + tabla + " order by " + campo +" asc ";
            SqlCommand comando = new SqlCommand(consulta, conn);
            adaptador.SelectCommand = comando;
            try
            {
                conn.Open();
                adaptador.Fill(datSet, tabla);
            }
            catch(Exception e)
            {

            }                        
            conn.Close();        
            Console.WriteLine("algo fallo");                        
            return datSet;
        }

        public SqlDataReader Buscar(string codConsulta)
        {
            SqlCommand comando = new SqlCommand(codConsulta, conn);
            conn.Open();
            SqlDataReader lector = comando.ExecuteReader();
            return lector;
        }

        public int ABM(string instruccion)
        {
            int respuesta = 1;
            SqlCommand comando = new SqlCommand(instruccion, conn);
            try
            {
                conn.Open();
            }
            catch(Exception e)
            {

            }
            respuesta = comando.ExecuteNonQuery();
            conn.Close();
            return respuesta;
            
        }
        public DataSet BuscarCliente(string consu, string tabla)
        {
            DataSet conjuntoDatos = new DataSet();
            SqlCommand comando = new SqlCommand(consu, conn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            conn.Open();
            adaptador.Fill(conjuntoDatos, tabla);
            conn.Close();
            return conjuntoDatos;
        }
        public DataSet getObservaciones()
        {
            DataSet conjuntoDatos = new DataSet();
            SqlCommand comando = new SqlCommand("select * from observacion", conn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            conn.Open();
            adaptador.Fill(conjuntoDatos, "observacion");
            conn.Close();
            return conjuntoDatos;
        }
        public DataSet getObservadores()
        {
            DataSet conjuntoDatos = new DataSet();
            SqlCommand comando = new SqlCommand("select * from observador", conn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            conn.Open();
            adaptador.Fill(conjuntoDatos, "observador");
            conn.Close();
            return conjuntoDatos;
        }
        public DataSet getEspecies()
        {
            DataSet conjuntoDatos = new DataSet();
            SqlCommand comando = new SqlCommand("select * from especie", conn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            conn.Open();
            adaptador.Fill(conjuntoDatos, "especie");
            conn.Close();
            return conjuntoDatos;
        }
    }


    

}
