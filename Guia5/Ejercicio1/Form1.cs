using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChar_Click(object sender, EventArgs e)
        {

            #region VALIDACION TELÉFONOS CON CHAR
            List<string> listaTelefonos = new List<string>() { "2324-2456556", "343-4817427", "2324-245a556", "343–-4817427", "343–-4817427-34", "2324-a-2456556" };

            lsbChar.Items.Clear();
            lsbChar.Items.Add($"VALIDACIÓN DE TELÉFONOS CON CHAR:");
            foreach(string telef in listaTelefonos)
            {
                TelefonoCharValidador validarTelefono = new TelefonoCharValidador( telef );
                lsbChar.Items.Add($"Teléfono: {telef} - {validarTelefono.VerMensaje()}");
            }
            #endregion

            #region VALIDACION PATENTES VIEJAS CON CHAR
            List<string> listaPatentesViejas = new List<string> {"ABC 123", "ABC123","123 ABC", "ABC 1 123", "ABC 123 1", "ABC A 123", "ABC A 123 B"};

            lsbChar.Items.Add($"VALIDACIÓN DE PATENTES VIEJAS CON CHAR:");
            foreach(string patVieja in listaPatentesViejas)
            {
                PatentesViejasCharValidador validarPatenteVieja = new PatentesViejasCharValidador(patVieja);
                lsbChar.Items.Add($"Patente Vieja: {patVieja} - {validarPatenteVieja.VerMensaje()}");
            }
            #endregion

            #region VALIDACION PATENTES NUEVAS CON CHAR
            #endregion

            #region VALIDACION CUITS CON CHAR
            #endregion
        }
    }
}
