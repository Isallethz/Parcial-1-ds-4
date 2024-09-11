using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1_ds_4
{
    public partial class Resultado : Form
    {
        
        public Resultado()
        {
            InitializeComponent();
            
        }

        public string Label2Text
        {
            get { return lbNombre.Text; }
            set { lbNombre.Text = value; }

        }
        public void MostrarNumeros(string[] numerosDeLaSuerte)
        {
        }
    }
}
