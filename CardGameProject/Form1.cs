﻿using System;
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
            //fill deck with cards
            for (int x = 0; x < 4; x++)
            {
                for (int y = 1; y <= 13; y++)
                {
                    deck.addCardTop(x, y);
                }
            }
            // below needs to be added to its own class for gameplay
            deck = deck.Shuffle();
            string picBoxName = "Card";
            int xCor = 30;
            int yCor = 25;
            for (int i = 1; i <= 5; i++, xCor+=120)
            {
                //GameAction.drawCard(xCor, yCor, this, picBoxName + i);
                GameAction.fillCard(deck.drawCard(), GameAction.drawCard(xCor, yCor, this, picBoxName + i), ip);
                //GameAction.drawCard(xCor, yCor + 185, this, picBoxName+i+1);
                GameAction.fillCard(deck.drawCard(), GameAction.drawCard(xCor, yCor+185, this, picBoxName + i), ip);
            }

            /*
            GameAction.drawCard(xCor + 120, yCor, this);
            GameAction.drawCard(xCor, yCor + 185, this);
            GameAction.drawCard(xCor + 120, yCor + 185, this);
            GameAction.drawCard(xCor + 240, yCor, this);
            GameAction.drawCard(xCor + 360, yCor, this);
            GameAction.drawCard(xCor + 240, yCor + 185, this);
            GameAction.drawCard(xCor + 360, yCor + 185, this);
            GameAction.drawCard(xCor + 480, yCor, this);
            GameAction.drawCard(xCor + 480, yCor + 185, this);*/
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {   
        }
    }
}
