namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string expresion = textBox1.Text;

            int cantNums = 0;
            for (int i = 0; i < expresion.Length; i++)
            {
                if (char.IsNumber(expresion[i]) == true) {
                    cantNums++;
                }
            }

            if (cantNums == expresion.Length)
            {
                textBox2.Text = "Es válido";

            }
            else
            {
                textBox2.Text = "No es válido";
            }
        }
    }
}
