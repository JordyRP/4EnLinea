namespace Proyecto_final
{
    partial class FormGanador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnReiniciar = new Button();
            btnSalir = new Button();
            lblGanador = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = SystemColors.ActiveCaptionText;
            btnReiniciar.ForeColor = SystemColors.Control;
            btnReiniciar.Location = new Point(36, 116);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(75, 23);
            btnReiniciar.TabIndex = 0;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveCaptionText;
            btnSalir.ForeColor = SystemColors.Control;
            btnSalir.Location = new Point(167, 116);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Location = new Point(73, 85);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(52, 15);
            lblGanador.TabIndex = 2;
            lblGanador.Text = "Ganador";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Imagen_de_WhatsApp_2024_12_11_a_las_16_44_44_3f93a4e1;
            pictureBox3.Location = new Point(63, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // FormGanador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(285, 150);
            Controls.Add(pictureBox3);
            Controls.Add(lblGanador);
            Controls.Add(btnSalir);
            Controls.Add(btnReiniciar);
            ForeColor = Color.Yellow;
            Name = "FormGanador";
            Text = "FormGanador";
            Load += FormGanador_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReiniciar;
        private Button btnSalir;
        private Label lblGanador;
        private PictureBox pictureBox3;
    }
}