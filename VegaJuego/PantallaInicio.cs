﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VegaJuego
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level1 level1 = new Level1(checkSonido);
            level1.Show();
        }

        private void PantallaInicio_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

      
    }
}
