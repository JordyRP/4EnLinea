
namespace Proyecto_final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtJugador1 = new TextBox();
            btnAceptar = new Button();
            btnBorrar = new Button();
            txtJugador2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtJugador1
            // 
            txtJugador1.Location = new Point(44, 193);
            txtJugador1.Name = "txtJugador1";
            txtJugador1.PlaceholderText = "Ingrese el nombre...";
            txtJugador1.Size = new Size(116, 23);
            txtJugador1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(63, 222);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Jugar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(204, 222);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click_1;
            // 
            // txtJugador2
            // 
            txtJugador2.Location = new Point(185, 193);
            txtJugador2.Name = "txtJugador2";
            txtJugador2.PlaceholderText = "Ingrese el nombre...";
            txtJugador2.Size = new Size(116, 23);
            txtJugador2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Image = Properties.Resources.Imagen_de_WhatsApp_2024_12_11_a_las_16_44_45_7631102e;
            label1.Location = new Point(74, 128);
            label1.Margin = new Padding(3);
            label1.MaximumSize = new Size(60, 60);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 5;
            label1.Text = "Jugador 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Yellow;
            label2.Image = Properties.Resources.Imagen_de_WhatsApp_2024_12_11_a_las_16_44_45_310f48b9;
            label2.Location = new Point(214, 127);
            label2.MaximumSize = new Size(120, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "Jugador 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(137, 9);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 10;
            label3.Text = "Bienvenido";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2024_12_11_a_las_16_44_45_7631102e;
            pictureBox1.Location = new Point(44, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Imagen_de_WhatsApp_2024_12_11_a_las_16_44_45_310f48b9;
            pictureBox2.Location = new Point(185, 81);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Imagen_de_WhatsApp_2024_12_11_a_las_16_44_44_3f93a4e1;
            pictureBox3.Location = new Point(96, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(353, 277);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtJugador2);
            Controls.Add(btnBorrar);
            Controls.Add(btnAceptar);
            Controls.Add(txtJugador1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtJugador1;
        private Button btnAceptar;
        private Button btnBorrar;
        private TextBox txtJugador2;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}