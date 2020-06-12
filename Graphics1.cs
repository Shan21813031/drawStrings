using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Graphics1
{
    public partial class drawStrings : Form
    {
        /// Unit 6: Tasks 6.1
        /// Author: Shan Ahmed
        /// </summary>
 
        public drawStrings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// In the below block of code, the application displays the line of text out 6 times
        /// The "g.Clear(BackColor)" also clears the screen at the end of the loop
        /// but also keeping the back color set to Yellow giving the line of text the effect of it disappearing
        /// </summary>

        private void drawString(object sender, PaintEventArgs e)
        {
            int x = 50;
            int y = 20;
            BackColor = Color.Yellow;
            ForeColor = Color.Red;

            for (int count = 0; count < 6; count++)
            {
                Graphics g = e.Graphics;                // create a new graphics object g
                Font myFont = new Font("Calibri", 30);    // create a font myFont
                g.DrawString("Shan is texting a Window", myFont, Brushes.Blue, x, y);
                y = y + 30;
                System.Threading.Thread.Sleep(500);
                g.Clear(BackColor);
            }
        }

        private void Graphics1_Load(object sender, EventArgs e)
        {

        }
    }
}
