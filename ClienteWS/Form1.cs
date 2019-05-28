using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            var identificacion = idField.Text;

            using (WSPersonas.WSPersonasClient client = new WSPersonas.WSPersonasClient())
            {
                var persona = client.ObtenerPersona(identificacion);
                if (string.IsNullOrEmpty(persona.Nombre))
                {
                    infoText.Text = persona.Error;
                    
                }
                else
                {
                    infoText.Text = persona.Nombre;
                }
                
            }
        }
    }
}
