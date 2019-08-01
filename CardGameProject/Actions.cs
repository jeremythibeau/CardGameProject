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
        public PictureBox drawCard(int xCor, int yCor, Form f, string name)
        {
            PictureBox p = new PictureBox();
            p.ClientSize = new Size(120, 170);
            p.BackColor = Color.Transparent;
            f.Controls.Add(p);
            p.Location = new Point(xCor, yCor);
            p.Name = name;
            return p;
            //dynamically gets the filename
            
        }
        public void fillCard(Card c, PictureBox p, ImageProcessor ip)
        {
            p.Image = ip.GetImageByName(c.getCardName(c));
        }
    }
}
