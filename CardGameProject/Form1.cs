using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;


namespace CardGameProject
{
    public partial class Form1 : Form
    {
        Deck deck = new Deck();
        Hand p1Hand = new Hand();
        ImageProcessor ip = new ImageProcessor();
        Actions GameAction = new Actions();
        public Form1()
        {
            InitializeComponent();            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            int xCor = 30;
            int yCor = 25;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 1; y <= 13; y++)
                {
                    deck.addCardTop(x, y);
                    /*
                    xCor += 140;
                    if (xCor >= 550)
                    {
                        xCor = 10;
                        yCor += 200;
                    }*/
                }
            }
            deck = deck.Shuffle();
            GameAction.drawCard(xCor, yCor, deck.drawCard(), ip, this);
            GameAction.drawCard(xCor + 120, yCor, deck.drawCard(), ip, this);
            GameAction.drawCard(xCor, yCor + 185, deck.drawCard(), ip, this);
            GameAction.drawCard(xCor + 120, yCor + 185, deck.drawCard(), ip, this);
            GameAction.drawCard(xCor + 240, yCor, deck.drawCard(), ip, this);
            GameAction.drawCard(xCor + 360, yCor, deck.drawCard(), ip, this);
            GameAction.drawCard(xCor + 240, yCor + 185, deck.drawCard(), ip, this);
            GameAction.drawCard(xCor + 360, yCor + 185, deck.drawCard(), ip, this);
            GameAction.drawCard(xCor + 480, yCor, deck.drawCard(), ip, this);
            GameAction.drawCard(xCor + 480, yCor + 185, deck.drawCard(), ip, this);
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {   
        }
    }
}
