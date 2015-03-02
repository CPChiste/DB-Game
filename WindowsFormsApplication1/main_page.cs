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
    public partial class main_page : Form
    {
        System.Media.SoundPlayer s = new System.Media.SoundPlayer();
        public main_page()
        {
            //Media file                    
                s.SoundLocation = (@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\Krishna_flute_theme_full_Star_Plus_Mahabharat_conv.wav");
                s.Load();
                s.Play();     
            InitializeComponent();
            //Background Change
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.BackgroundImage = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Image\hd-wallpaper-15.jpg");
        }

       

        private void Start_Button_Click(object sender, EventArgs e)
        {
            select_card card = new select_card();
            card.Show();
            this.Hide();
            s.Stop();
            //Media file                    
            s.SoundLocation = (@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Image\button_click.wav");
            s.Load();
            s.Play();
        }
     
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.Stop();
            //Media file                    
            s.SoundLocation = (@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Image\button_click.wav");
            s.Load();
            s.Play();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            s.Stop();
            //Media file                    
            s.SoundLocation = (@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Image\button_click.wav");
            s.Load();
            s.Play();
            Start_Button_Click(sender, e);
        }

       
    }
}
