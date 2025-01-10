using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login;

namespace SplashScreen
{
    public partial class frm_SplashScreen : Form
    {
        private ProgressBar progressBar;
        private PictureBox pictureBox;
        private PictureBox pictureBox1;
        private Timer timer;
        private double progressFraction; // Fracción de progreso entre 0 y 1

        public frm_SplashScreen()
        {
            // Configuración del formulario
            this.Text = "Nave Voladora";
            this.Size = new Size(800, 450);
            // Establecer la imagen de fondo del formulario
            this.BackgroundImage = Bitmap.FromFile("Imatges/space.jpg"); // Ruta de la imagen de fondo
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;

            // Crear el ProgressBar
            progressBar = new ProgressBar
            {
                Location = new Point(0, 370),
                Size = new Size(810, 30),
                Minimum = 0,
                Maximum = 100,
                Visible = false
            };
            this.Controls.Add(progressBar);

            // Crear el PictureBox para la nave
            pictureBox1 = new PictureBox
            {
                Image = Bitmap.FromFile("Imatges/logo_sin_fondo.png"), // Ruta de la imagen
                SizeMode = PictureBoxSizeMode.StretchImage, // Redimensiona la imagen
                Size = new Size(250, 250),
                Location = new Point(275, 50),
                BackColor = Color.Transparent
            };
            this.Controls.Add(pictureBox1);

            // Crear el PictureBox para la nave
            pictureBox = new PictureBox
            {
                Image = Bitmap.FromFile("Imatges/battleship.png"), // Ruta de la imagen
                SizeMode = PictureBoxSizeMode.StretchImage, // Redimensiona la imagen
                Size = new Size(50, 50), // Ajusta el tamaño de la imagen
                BackColor = Color.Transparent
            };
            this.Controls.Add(pictureBox);

            // Coloca la imagen al inicio del ProgressBar
            pictureBox.Location = new Point(progressBar.Left - pictureBox.Width / 2, progressBar.Top - pictureBox.Height / 2);

            // Inicializamos la fracción de progreso
            progressFraction = 0;

            // Crear y configurar el Timer
            timer = new Timer
            {
                Interval = 10 // Intervalo en milisegundos (10 ms para mayor fluidez)
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Incrementa la fracción de progreso suavemente
            if (progressFraction < 1)
            {
                progressFraction += 0.01;  // Incremento más pequeño para suavizar el movimiento
                progressBar.Value = (int)(progressFraction * progressBar.Maximum);

                // Mueve la imagen de la nave de forma más suave
                int progressWidth = (int)(progressBar.Width * progressFraction);
                int newX = progressBar.Left + progressWidth - (pictureBox.Width / 2);
                pictureBox.Location = new Point(newX, progressBar.Top - (pictureBox.Height / 2));
            }
            else
            {
                timer.Stop(); // Detiene el timer al alcanzar el máximo
                this.Hide(); // Cierra el formulario al terminar la animación
                frmLogin frmlogin = new frmLogin();
                frmlogin.FormClosed += frmlogin_FormClosed;
                frmlogin.Show();
            }
        }

        private void frmlogin_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.Close();
        }
    }
}
