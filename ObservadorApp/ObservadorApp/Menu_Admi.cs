using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObservadorApp
{
    public partial class Menu_Admi : Form
    {
        public Menu_Admi()
        {
            InitializeComponent();
        }

        Observacion_admi observacion_Admi = null;
        Registro_Observador_Admi registro_Admi = null;
        Zona_Admi zona = null;
        Especie_Admi especie = null;
        Asociacion_Admi asociacion = null;

        private void btnObservador_Click(object sender, EventArgs e)
        {
            if(registro_Admi == null)
            {
                registro_Admi = new Registro_Observador_Admi();
                this.Hide();
                registro_Admi.Show();
            }
        }

        private void btnZona_Click(object sender, EventArgs e)
        {
            if(zona == null)
            {
                zona = new Zona_Admi();
                this.Hide();
                zona.Show();
            }
        }

        private void btnEspecie_Click(object sender, EventArgs e)
        {
            if(especie == null)
            {
                especie = new Especie_Admi();
                this.Hide();
                especie.Show();
            }
        }

        private void btnAsociacion_Click(object sender, EventArgs e)
        {
            if(asociacion == null)
            {
                asociacion = new Asociacion_Admi();
                this.Hide();
                asociacion.Show();
            }
        }

        private void btnObservacion_Click(object sender, EventArgs e)
        {
            if(observacion_Admi == null)
            {
                observacion_Admi = new Observacion_admi();
                this.Hide();
                observacion_Admi.Show();
            }
        }
    }
}
