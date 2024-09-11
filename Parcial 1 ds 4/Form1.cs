namespace Parcial_1_ds_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            Dictionary<int, bool> numerosDeLaSuerte = new Dictionary<int, bool>();

            while (numerosDeLaSuerte.Count < 3)
            {
                int numero = random.Next(0, 99);
                if (!numerosDeLaSuerte.ContainsKey(numero))
                {
                    numerosDeLaSuerte[numero] = true;
                }
            }

            string[] numerosFormateados = numerosDeLaSuerte.Keys.Select(n => n.ToString("D2")).ToArray();

            Resultado resultadoForm = new Resultado();

            resultadoForm.MostrarNumeros(numerosFormateados);

            resultadoForm.Show();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            // Obtener el nombre del TextBox
            string nombre = tbNombre.Text;

            // Crear una instancia del formulario Resultado
            Resultado resultadoForm = new Resultado();

            // Pasar el nombre al formulario Resultado
            resultadoForm.Label2Text = tbNombre.Text;

            // Mostrar el formulario Resultado
            resultadoForm.Show();
        }
    }
}
