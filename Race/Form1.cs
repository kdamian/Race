using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race
{
    public partial class Form1 : Form
    {
        private bool if_game_active;

        public Form1()
        {
            InitializeComponent();
            if_game_active = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (if_game_active)
            {
                game_field.CreateGraphics().Clear(Color.Black);
            }
            else
            {
                FontFamily ff1 = new FontFamily("Arial");
                Font f = new Font(ff1, 15);
                Brush b = new SolidBrush(Color.AliceBlue);
                game_field.CreateGraphics().DrawString("Press Start to begin the game", f, b, 3 ,135);
            }
        }

        private void sTARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if_game_active = true;
        }
    }
}
