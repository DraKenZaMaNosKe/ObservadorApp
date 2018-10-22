using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObservadorApp
{
    public partial class Observaciones : Form
    {
        public Observaciones()
        {
            InitializeComponent();
        }

        ClassBD con = new ClassBD();
        int res = -1;

        private void Observaciones_Load(object sender, EventArgs e)
        {            
            getObservaciones();
        }

        private void getObservaciones()
        {                            
                DataSet datos = new DataSet();
                datos = con.ConsulTab("Observacion", "idObservacion");
                dataGridView1.DataSource = datos.Tables["Observacion"];                        
        }
        private void getEspecies()
        {
            DataSet datos = new DataSet();
            datos = con.ConsulTab("Especie", "idEspecie");
            dataGridView1.DataSource = datos.Tables["Especie"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addObservacion();
        }

        private void addObservacion()
        {            
            try
            {
                //Console.WriteLine("el bombo box tiene selecionado" + cmbObservadores.SelectedItem.ToString());
                string insertar = " insert into observacion " +
                    " (idObservador,idEspecie," +
                    " cantidad, fechaObservacion, " +
                    " horaOservacion) values(" + cmbObservadores.Text + "," +
                    cmbEspecies.Text +"," + cmbCantidad.Text + 
                    ", '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "', '12:12')";
                
                Console.WriteLine(insertar);
                res = con.ABM(insertar);
                if(res == 1)
                {
                    MessageBox.Show("Se ha agregado un registro", "Nueva observacion", 
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                }                
            }
            catch (Exception exB)
            {
                MessageBox.Show("algo fallo" + exB.Message.ToString());
            }
            finally
            {
               // ClassBD.conn.Close();
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            cmbObservadores.Items.Clear();
            try
            {
                DataSet ds = new DataSet();
                ds = con.getObservadores();
                foreach(DataRow fila in ds.Tables["Observador"].Rows)
                {
                    cmbObservadores.Items.Add(fila["idObservador"].ToString());
                }
                
            }catch(Exception exA)
            {
                
            }
            finally
            {
                ClassBD.conn.Close();
            }
        }

        private void comboBox1_Click_1(object sender, EventArgs e)
        {
            cmbObservadores.Items.Clear();
            try
            {
                DataSet ds = new DataSet();
                ds = con.getEspecies();
                foreach (DataRow fila in ds.Tables["Especie"].Rows)
                {
                    cmbEspecies.Items.Add(fila["idEspecie"].ToString());
                }

            }
            catch (Exception exA)
            {

            }
            finally
            {
                ClassBD.conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("evento click");
            DataSet datos = new DataSet();
            datos = con.ConsulTab("Observacion", "idObservacion");
            dataGridView1.DataSource = datos.Tables["Observacion"];
            Console.WriteLine("fin evento click");
        }
    }
}
