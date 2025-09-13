using Ejercicio1.Models;

namespace Ejercicio1
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

        List<string> listaTelefonos = new List<string>() { "2324-2456556", "343-4817427", "2324-245a556", "343–-4817427", "343–-4817427-34", "2324-a-2456556" };
        List<string> listaPatentesViejas = new List<string> { "ABC 123", "ABC123", "123 ABC", "ABC 1 123", "ABC 123 1", "ABC A 123", "ABC A 123 B" };
        List<string> listaPatentesNuevas = new List<string> { "AB 1234 CD", "AB 1234 CDC", "ABC 1234 CD", "ABC 123 CD" };
        List<string> listaCuits = new List<string> { "20-28464555-2", "20-40158729-3", "20-284645535-2" };
        List<string> listaFechas = new List<string> { "23/1/2024", "23/01/2024", "23-01-2024" };
        private void btnChar_Click(object sender, EventArgs e)
        {

            lsbChar.Items.Clear();

            #region VALIDACION TELÉFONOS CON CHAR
            lsbChar.Items.Add("VALIDACIÓN DE TELÉFONOS CON CHAR:");
            foreach (string telef in listaTelefonos)
            {
                TelefonoCharValidador validarTelefono = new TelefonoCharValidador(telef);
                lsbChar.Items.Add($"Teléfono: {telef} - {validarTelefono.VerMensaje()}");
            }
            #endregion

            #region VALIDACION PATENTES VIEJAS CON CHAR
            lsbChar.Items.Add("VALIDACIÓN DE PATENTES VIEJAS CON CHAR:");
            foreach (string patVieja in listaPatentesViejas)
            {
                PatentesViejasCharValidador validarPatenteVieja = new PatentesViejasCharValidador(patVieja);
                lsbChar.Items.Add($"Patente Vieja: {patVieja} - {validarPatenteVieja.VerMensaje()}");
            }
            #endregion

            #region VALIDACION PATENTES NUEVAS CON CHAR
            lsbChar.Items.Add("VALIDACIÓN DE PATENTES NUEVAS CON CHAR:");
            foreach (string patNueva in listaPatentesNuevas)
            {
                PatentesNuevasCharValidador validarPatenteNueva = new PatentesNuevasCharValidador(patNueva);
                lsbChar.Items.Add($"Patente Nueva: {patNueva} - {validarPatenteNueva.VerMensaje()}");
            }
            #endregion

            #region VALIDACION CUITS CON CHAR
            lsbChar.Items.Add("VALIDACIÓN DE CUITS CON CHAR:");
            foreach (string cuit in listaCuits)
            {
                CuitsCharValidador validarCuit = new CuitsCharValidador(cuit);
                lsbChar.Items.Add($"CUIT: {cuit} - {validarCuit.VerMensaje()}");
            }
            #endregion

            #region VALIDACION FECHAS CON CHAR
            lsbChar.Items.Add("VALIDACIÓN DE FECHAS CON CHAR:");
            foreach (string fecha in listaFechas)
            {
                FechaCharValidador validarFecha = new FechaCharValidador(fecha);
                lsbChar.Items.Add($"Fecha: {fecha} - {validarFecha.VerMensaje()}");
            }
            #endregion
        }

        private void btnRegex_Click(object sender, EventArgs e)
        {
            lsbRegex.Items.Clear();
            #region VALIDACION TELÉFONOS CON REGEX
            lsbRegex.Items.Add("VALIDACIÓN DE TELÉFONOS CON REGEX:");
            foreach (string telef in listaTelefonos)
            {
                TelefonoRegexValidador validarTelefono = new TelefonoRegexValidador(telef);
                lsbRegex.Items.Add($"Teléfono: {telef} - {validarTelefono.VerMensaje()}");
            }
            #endregion

            #region VALIDACION PATENTES VIEJAS CON REGEX
            lsbRegex.Items.Add("VALIDACIÓN DE TELÉFONOS CON REGEX:");
            foreach (string patVieja in listaPatentesViejas)
            {
                PatentesViejasCharValidador validarPatenteVieja = new PatentesViejasCharValidador(patVieja);
                lsbRegex.Items.Add($"Patente Vieja: {patVieja} - {validarPatenteVieja.VerMensaje()}");
            }
            #endregion
        }
    }
}
