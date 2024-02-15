using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegaJuego
{
    internal class Personaje
    {
        private int coordx;
        private int coordy;
        private Level1 lienzo;
        private PictureBox caja = new PictureBox();
        private String direccion;


        public Personaje(Level1 vegaZelda, int x, int y)
        {
            coordx = x;
            coordy = y;
            lienzo = vegaZelda;
            direccion = "Derecha";
            caja.Location= new System.Drawing.Point(coordx,coordy);
            caja.BackColor = System.Drawing.Color.Transparent; ;
            caja.Size = new System.Drawing.Size(110, 110);
            caja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            caja.BackgroundImage = global::VegaJuego.Properties.Resources.derecha;

            vegaZelda.Controls.Add(caja); caja.Visible = true;
        }
        public String Direcion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int CoordY{
            get { return coordy; }
            set { coordy = value; }
        }

        public int CoordX
        {
            get { return coordx; }
            set { coordx = value; }
        }

        public Level1 Lienzo
        {
            get { return lienzo; }
            set { lienzo = value; }
        }

        public PictureBox Caja
        {
            get { return caja; }
            set { caja = value; }   
        }

        // Método que se usara en cada clase hija
        public void mover()
        {

        }
        


    }
}
