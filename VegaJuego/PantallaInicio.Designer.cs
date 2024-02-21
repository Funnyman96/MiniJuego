namespace VegaJuego
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            button1 = new Button();
            checkSonido = new CheckBox();
            pictureBox1 = new PictureBox();
            labelCreador = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Gold;
            button1.Image = Properties.Resources.Boton;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(273, 368);
            button1.Name = "button1";
            button1.Size = new Size(275, 46);
            button1.TabIndex = 1;
            button1.Text = "Comienza la aventura     ";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkSonido
            // 
            checkSonido.AutoSize = true;
            checkSonido.BackColor = Color.Transparent;
            checkSonido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkSonido.Location = new Point(602, 181);
            checkSonido.Name = "checkSonido";
            checkSonido.Size = new Size(133, 24);
            checkSonido.TabIndex = 2;
            checkSonido.Text = "Sonido On/Off";
            checkSonido.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.ZeldaLogo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(535, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 102);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // labelCreador
            // 
            labelCreador.AutoSize = true;
            labelCreador.BackColor = Color.Transparent;
            labelCreador.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCreador.Location = new Point(535, 17);
            labelCreador.Name = "labelCreador";
            labelCreador.Size = new Size(226, 20);
            labelCreador.TabIndex = 4;
            labelCreador.Text = "Creado por Mario Olaya Ortega";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.LogoBueno;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(264, 277);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // PantallaInicio
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.FondoPantalla;
            ClientSize = new Size(804, 459);
            Controls.Add(pictureBox2);
            Controls.Add(labelCreador);
            Controls.Add(pictureBox1);
            Controls.Add(checkSonido);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PantallaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaInicio";
            FormClosing += PantallaInicio_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button button1;
        private CheckBox checkSonido;
        private PictureBox pictureBox1;
        private Label labelCreador;
        private PictureBox pictureBox2;
    }
}