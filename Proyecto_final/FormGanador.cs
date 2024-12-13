using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    #region Metodos
    public partial class FormGanador : Form
    {
        public FormGanador()
        {
            InitializeComponent();
        }

        private void FormGanador_Load(object sender, EventArgs e)
        {
            lblGanador.Text = $"¡{(FormJuego.turno == "X" ? Form1.Jugador1 : Form1.Jugador2)} !Felicidades has ganado!";
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Form1 juego = new Form1();
            juego.Show();

            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
                                 
        }
   

    }
    #endregion

}
