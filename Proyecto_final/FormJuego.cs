using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Microsoft.VisualBasic.Devices;

namespace Proyecto_final
{
    public partial class FormJuego : Form
    {
        #region Variables 

        // Variables para el tablero y el turno
        public Button[,] botones;
        public static string turno;
        

        #endregion

        #region Metodos
        public FormJuego()
        {

            InitializeComponent();
            InicializarTablero();
            turno = "X"; // Empieza el Jugador 1
            lblTurno.Text = $"Turno de {Form1.Jugador1}";
            lblJugadorR.Text = $" {Form1.Jugador1}";
            lblJugador2.Text = $" {Form1.Jugador2}";
        }

        private void InicializarTablero()
        {            
            // Crear una matriz de botones para el tablero 6x7
            botones = new Button[6, 7];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Button btn = new Button
                    {
                        Name = $"btn_{i}_{j}",
                        Text = "",
                        Width = 50,
                        Height = 50
                    };

                    btn.Click += BotonClick; // Asignar evento de clic
                    botones[i, j] = btn;
                    tableLayoutPanel1.Controls.Add(btn, j, i); // Agregar al TableLayoutPanel
                }
            }
        }

        private void BotonClick(object sender, EventArgs e)
        {            
            Button btn = sender as Button;

            if (btn != null && string.IsNullOrEmpty(btn.Text))
            {
                btn.Text = turno;

                // Verificar si hay un ganador
                if (VerificarGanador())
                {

                    FormGanador Ganador = new FormGanador();
                    Ganador.Show();
                    this.Hide();
                    ReiniciarJuego();
                    return;
                }                              

                // Cambiar el turno
                turno = turno == "X" ? "O" : "X";
                lblTurno.Text = $"Turno de {(turno == "X" ? Form1.Jugador1 : Form1.Jugador2)}";

            }
        }

        private bool VerificarGanador()
        {
            // Verificar filas, columnas y diagonales
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (!string.IsNullOrEmpty(botones[i, j].Text) &&
                        (VerificarDireccion(i, j, 1, 0) || // Horizontal
                         VerificarDireccion(i, j, 0, 1) || // Vertical
                         VerificarDireccion(i, j, 1, 1) || // Diagonal principal
                         VerificarDireccion(i, j, 1, -1))) // Diagonal secundaria
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool VerificarDireccion(int x, int y, int dx, int dy)
        {
            string simbolo = botones[x, y].Text;
            int count = 0;

            for (int k = 0; k < 4; k++)
            {
                int nx = x + k * dx;
                int ny = y + k * dy;

                if (nx >= 0 && ny >= 0 && nx < 6 && ny < 7 && botones[nx, ny].Text == simbolo)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count == 4;
        }

        private void ReiniciarJuego()
        {
            foreach (Button btn in botones)
            {
                btn.Text = ""; // Vaciar cada botón
            }

            turno = "X"; // Reiniciar el turno
            lblTurno.Text = $"Turno de {Form1.Jugador1}";

        }


        private void lblTurno_Click(object sender, EventArgs e)
        {

        }

        private void FormJuego_Load(object sender, EventArgs e)
        {

        }

       
    }
    #endregion
}