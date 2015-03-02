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
    public partial class rules : Form
    {
        Bitmap Deck_Image;
        Bitmap Card_Image;
        //String Game_Name = " ";
        public rules(Bitmap Image, Bitmap Card)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Deck_Image = Image;
            Card_Image = Card;
            this.BackgroundImage = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Image\Cool-Wallpapers-Card-Pictures-HD-Wallpaper-1080x607.jpg");
            InitializeComponent();
            //Game_Name = textBox_GameName.Text;
        }

        private void Next_rule_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox_GameName.Text))
            {
                Name = textBox_GameName.Text;
                Play play = new Play(Deck_Image, Card_Image, Name);
                play.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Give Name");
            }
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
