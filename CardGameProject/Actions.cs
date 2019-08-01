using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CardGameProject
{
    class Actions
    {
        public Actions()
        {
        }
        public void drawCard(int xCor, int yCor, Card c, ImageProcessor ip, Form f)
        {
            PictureBox p = new PictureBox();
            p.ClientSize = new Size(120, 170);
            p.BackColor = Color.Transparent;
            f.Controls.Add(p);
            p.Location = new Point(xCor, yCor);
            //dynamically gets the filename
            p.Image = ip.GetImageByName(c.getCardName(c));
        }
    }
}
