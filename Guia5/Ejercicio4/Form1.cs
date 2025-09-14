using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (tbPalabra.Text != "")
            {
                // 1. Inicializar frase
                string frase = "La casa es grande y la casa tiene un jardín. La casa también tiene un perro en la casa.";

                // 2. Palabra a resaltar
                string palabraAResaltar = tbPalabra.Text;

                // 3. Usar Regex → reemplazar palabra por versión en RTF con negrita
                string patron = Regex.Escape(palabraAResaltar);
                string textoRTF = Regex.Replace(frase, patron, $@"{{\b {palabraAResaltar}\b0}}", RegexOptions.IgnoreCase);


                // 4. Muestro en RichTextBox
                richTextBox1.Rtf = $@"{{\rtf1\ansi {textoRTF}}}";

                //5. Mostrar cantidad de coincidencias
                MatchCollection matches = Regex.Matches(frase, patron, RegexOptions.IgnoreCase);
                lbCantidad.Text = $"{matches.Count}";
            }
            else
            {
                MessageBox.Show("Debes ingresar una palabra a buscar");
            }

        }


    }
}
