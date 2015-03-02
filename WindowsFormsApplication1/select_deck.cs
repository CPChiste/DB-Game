using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class select_deck : Form
    {
       
        Bitmap deckImage;
        Bitmap Card;
        public select_deck(Bitmap Card_Image)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            
            InitializeComponent();
            Card = Card_Image;
            comboBox_Choose.SelectedIndex = 0;
            comboBox_Deck.SelectedIndex = 0;
            comboBox_upChoose.SelectedIndex = 0;
            comboBox_Deck.Hide();
            label_Update.Hide();
            label_Select.Hide();
            label_DeckList.Hide();
            label_Set.Hide();
            label_Delete.Hide();
            comboBox_upChoose.Hide();
            //this.BackgroundImage = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Image\Cool-Wallpapers-Card-Pictures-HD-Wallpaper-1080x607.jpg");
            this.BackgroundImage = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Image\textures-playing_00422327.jpg");
            pictureBox_deck1.Image = new Bitmap (@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\deck1.jpg");
            pictureBox_deck2.Image = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\deck2.jpg");
            pictureBox_deck3.Image = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\deck3.jpg");
            pictureBox_deck4.Image = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\deck4.jpg");
            pictureBox_deck5.Image = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\deck5.jpg");
            pictureBox_deck6.Image = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\deck6.jpg");
        }

        private static System.Resources.ResourceManager resourceManager =
                new System.Resources.ResourceManager("WindowsFormsApplication1.Images", System.Reflection.Assembly.GetExecutingAssembly());

        public Bitmap GetDeckImage()
        {
            
            deckImage = null;
            if (comboBox_Choose.SelectedItem.ToString() == "SELECT")
            {              
                if (comboBox_Deck.SelectedItem.ToString() == "Deck1")
                {
                    deckImage = (Bitmap)resourceManager.GetObject("deck1");
                }
                else if (comboBox_Deck.SelectedItem.ToString() == "Deck2")
                {
                    deckImage = (Bitmap)resourceManager.GetObject("deck2");
                }
                else if (comboBox_Deck.SelectedItem.ToString() == "Deck3")
                {
                    deckImage = (Bitmap)resourceManager.GetObject("deck3");
                }
                else if (comboBox_Deck.SelectedItem.ToString() == "Deck4")
                {
                    deckImage = (Bitmap)resourceManager.GetObject("deck4");
                }
                else if (comboBox_Deck.SelectedItem.ToString() == "Deck5" )
                {
                    deckImage = (Bitmap)resourceManager.GetObject("deck5");
                }
                else if (comboBox_Deck.SelectedItem.ToString() == "Deck6")
                {
                    deckImage = (Bitmap)resourceManager.GetObject("deck6");
                }
            }
                else if (comboBox_Choose.SelectedItem.ToString() == "UPDATE")
                {
                    deckImage = null;
                    if (comboBox_upChoose.SelectedItem.ToString() == "Deck1")
                    {
                        deckImage = (Bitmap)resourceManager.GetObject("deck1");
                    }
                    else if (comboBox_upChoose.SelectedItem.ToString() == "Deck2")
                    {
                        deckImage = (Bitmap)resourceManager.GetObject("deck2");
                    }
                    else if (comboBox_upChoose.SelectedItem.ToString() == "Deck3")
                    {
                        deckImage = (Bitmap)resourceManager.GetObject("deck3");
                    }
                    else if (comboBox_upChoose.SelectedItem.ToString() == "Deck4")
                    {
                        deckImage = (Bitmap)resourceManager.GetObject("deck4");
                    }
                    else if (comboBox_upChoose.SelectedItem.ToString() == "Deck5")
                    {
                        deckImage = (Bitmap)resourceManager.GetObject("deck5");
                    }
                    else if (comboBox_upChoose.SelectedItem.ToString() == "Deck6")
                    {
                        deckImage = (Bitmap)resourceManager.GetObject("deck6");
                    }

                }
                else
                {
                    deckImage = null;
                }
            

            return deckImage; 
        }
        
        private void Preview_button_Click(object sender, EventArgs e)
        {
            pictureBox_final.Image = GetDeckImage();
            if (pictureBox_final.Image == null)
            {
                comboBox_Choose.SelectedIndex = 1;
                MessageBox.Show("Select one Deck using SELECT or follow the instrustion");                
            }
            else
            {
                MessageBox.Show("Change Deck using UPDATE or follow the instrustion");
                comboBox_Choose.SelectedIndex = 2;
            }
        }
        
        private void button_Next_Click(object sender, EventArgs e)
        {
            if (pictureBox_final.Image == null)
            {
                MessageBox.Show("Select one Image or make a privew");
                this.Show();
            }
            else
            {
                rules rule = new rules(deckImage,Card);
                rule.Show();
                this.Hide();              
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

        private void comboBox_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Choose.SelectedItem.ToString() == "SELECT")
            {
                label_DeckList.Show();
                comboBox_Deck.Show();
                label_Select.Show();
                comboBox_upChoose.Hide();
                label_Update.Hide();
                label_Delete.Hide();
                label_Set.Hide();
                comboBox_Deck.Enabled = true;
            }
            else if (comboBox_Choose.SelectedItem.ToString() == "UPDATE")
            {
                label_DeckList.Hide();
                label_Update.Show();
                label_Set.Show();
                comboBox_upChoose.Show();
                comboBox_Deck.FormattingEnabled = false;
                label_Select.Hide();
                label_Delete.Hide();
                comboBox_Deck.Enabled = false;
            }
            else if (comboBox_Choose.SelectedItem.ToString() == "DELETE")
            {
                label_DeckList.Show();
                comboBox_Deck.Show();
                label_Select.Hide();
                comboBox_upChoose.Hide();
                label_Update.Hide();
                label_Set.Hide();
                label_Delete.Show();
                comboBox_Deck.SelectedIndex = comboBox_upChoose.SelectedIndex;
                comboBox_Deck.Enabled = false;
            }
        }

       

        
        
        
    }
    
}
