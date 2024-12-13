using System.Media;

namespace Proyecto_final
{
    public partial class Form1 : Form
    {
        #region Variables
        // Variables públicas para los nombres de los jugadores
        public static string Jugador1;
        public static string Jugador2;

        #endregion

        #region Metodos
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            
            // Guardar los nombres de los jugadores
            Jugador1 = txtJugador1.Text;
            Jugador2 = txtJugador2.Text;


            // Validar que ambos nombres estén ingresados
            if (string.IsNullOrEmpty(Jugador1) || string.IsNullOrEmpty(Jugador2))
            {
                MessageBox.Show("Por favor, ingresa ambos nombres.");
                return;

            }
            // Abrir el formulario del juego
            FormJuego juego = new FormJuego();
            juego.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            // Limpiar los cuadros de texto
            txtJugador1.Clear();
            txtJugador2.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
