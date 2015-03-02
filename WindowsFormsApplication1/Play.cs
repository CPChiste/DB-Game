using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Play : Form
    {
        //private select_deck Deck;
        public Play(Bitmap Deck, Bitmap Card, String GameName)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();

            BackgroundImage = Deck;
            pictureBox1.Image = Card;
            label_Name.Text = GameName;
        }                                                                                                                                                  

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            main_page main = new main_page();
            main.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
