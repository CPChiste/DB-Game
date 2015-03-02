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
    public partial class select_card : Form
    {
        System.Media.SoundPlayer s = new System.Media.SoundPlayer();
        Bitmap cardBack; 
        public select_card()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            
            InitializeComponent();
            comboBox_Choose.SelectedIndex = 0;
            comboBox_CradList.SelectedIndex = 0;
            comboBox_CradList.Hide();
            lable_Select.Hide();
            label_SelEx.Hide();
            comboBox_Update.Hide();
            label_UpEx.Hide();
            Lable_Set.Hide();
            label_DelEx.Hide();
            this.BackgroundImage = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Image\Cool-Wallpapers-Card-Pictures-HD-Wallpaper-1080x607.jpg");         
            pbDeck.Image = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\card-back.jpg");
            deck.Image = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\card_Image2.jpg");
            deck_3.Image = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\card_Image3.jpg");
            deck_4.Image = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\card_Image4.jpg");
            deck_5.Image = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\card_image5.jpg");
            deck_6.Image = new Bitmap(@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Resources\card_Image6.jpg");
        }
       
            private static System.Resources.ResourceManager resourceManager =
                new System.Resources.ResourceManager("WindowsFormsApplication1.Images", System.Reflection.Assembly.GetExecutingAssembly());
        

            public static Bitmap GetFaceImageForCard(Card card)
            {
                Bitmap cardImages = (Bitmap)resourceManager.GetObject("cardfaces");

                int topx = 0;
                int topy = 0;
                
                if (card.Suit == CardSuits.Club) topy = 0;
                if (card.Suit == CardSuits.Spade) topy = 98;
                if (card.Suit == CardSuits.Heart) topy = 196;
                if (card.Suit == CardSuits.Diamond) topy = 294;
                topx = 73 * Convert.ToInt32(card.Value);
                Rectangle rect = new Rectangle(topx, topy, 73, 97);
                Bitmap cropped = cardImages.Clone(rect, cardImages.PixelFormat);
                return cropped;
            }
            
        
            public Bitmap GetBackImage()
            {               
                cardBack = null;
                if (comboBox_Choose.SelectedItem.ToString() == "SELECT")
                {
                    if (comboBox_CradList.SelectedItem.ToString() == "Card1")
                    {
                        cardBack = (Bitmap)resourceManager.GetObject("card_back");
                    }
                    else if (comboBox_CradList.SelectedItem.ToString() == "Card2")
                    {
                        cardBack = (Bitmap)resourceManager.GetObject("card_Image2");
                    }
                    else if (comboBox_CradList.SelectedItem.ToString() == "Card3")
                    {
                        cardBack = (Bitmap)resourceManager.GetObject("card_Image3");
                    }
                    else if (comboBox_CradList.SelectedItem.ToString() == "Card4")
                    {
                        cardBack = (Bitmap)resourceManager.GetObject("card_Image4");
                    }
                    else if (comboBox_CradList.SelectedItem.ToString() == "Card5")
                    {
                        cardBack = (Bitmap)resourceManager.GetObject("card_Image5");
                    }
                    else if (comboBox_CradList.SelectedItem.ToString() == "Card6")
                    {
                        cardBack = (Bitmap)resourceManager.GetObject("card_Image6");
                    }
                }
                else if (comboBox_Choose.SelectedItem.ToString() == "UPDATE")
                {
                    if (comboBox_Update.SelectedItem.ToString() == "Card1")
                    {
                        cardBack = (Bitmap)resourceManager.GetObject("card_back");
                    }
                    else if (comboBox_Update.SelectedItem.ToString() == "Card2")
                    {
                        cardBack = (Bitmap)resourceManager.GetObject("card_Image2");
                    }
                    else if (comboBox_Update.SelectedItem.ToString() == "Card3")
                    {
                        cardBack = (Bitmap)resourceManager.GetObject("card_Image3");
                    }
                    else if (comboBox_Update.SelectedItem.ToString() == "Card4")
                    {
                        cardBack = (Bitmap)resourceManager.GetObject("card_Image4");
                    }
                    else if (comboBox_Update.SelectedItem.ToString() == "Card5")
                    {
                        cardBack = (Bitmap)resourceManager.GetObject("card_Image5");
                    }
                    else if (comboBox_Update.SelectedItem.ToString() == "Card6")
                    {
                        cardBack = (Bitmap)resourceManager.GetObject("card_Image6");
                    }
                }
                else
                {
                    cardBack = null;
                }
                return cardBack;
            }
            private void button_final_Click(object sender, EventArgs e)
            {
                //Media file                    
                s.SoundLocation = (@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Image\button_click.wav");
                s.Load();
                s.Play();
                pictureBox_Final.Image = GetBackImage();
                if (pictureBox_Final.Image == null)
                {
                    s.SoundLocation = (@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Image\button_error.wav");
                    s.Load();
                    s.Play();
                    comboBox_Choose.SelectedIndex = 1;
                    MessageBox.Show("Choose Image Using SELECT or fallow the Instrction");
                }
                else
                {
                    s.SoundLocation = (@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Image\button_error.wav");
                    s.Load();
                    s.Play();
                    MessageBox.Show("Change Deck using UPDATE or follow the instrustion");
                    comboBox_Choose.SelectedIndex = 2;
                }
                
            }

            private void button_next_Click(object sender, EventArgs e)
            {
                //Media file                    
                s.SoundLocation = (@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Image\button_click.wav");
                s.Load();
                s.Play();
                if (pictureBox_Final.Image == null)
                {
                    s.SoundLocation = (@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Image\button_error.wav");
                    s.Load();
                    s.Play();
                    MessageBox.Show("Select an Image or make a preview");
                    this.Show();
                }
                else
                {
                    select_deck deck = new select_deck(cardBack);
                    deck.Show();
                    this.Hide();
                }

            }

            private void toolStripMenuItem1_Click(object sender, EventArgs e)
            {
                //Media file                    
                s.SoundLocation = (@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Image\button_click.wav");
                s.Load();
                s.Play();
                main_page main = new main_page();
                main.Show();
                this.Hide();
            }

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                //Media file                    
                s.SoundLocation = (@"C:\Users\niraj.deval\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Image\button_click.wav");
                s.Load();
                s.Play();
                this.Close();
            }

            private void comboBox_Choose_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (comboBox_Choose.SelectedItem.ToString() == "SELECT")
                {
                    comboBox_CradList.Show();
                    lable_Select.Show();
                    label_SelEx.Show();
                    label_DelEx.Hide();
                    comboBox_CradList.SelectedIndex = 0;
                    comboBox_CradList.Enabled = true;
                    Lable_Set.Hide();
                    comboBox_Update.Hide();
                }
                else if (comboBox_Choose.SelectedItem.ToString() == "UPDATE")
                {
                    comboBox_Update.Show();
                    label_UpEx.Show();
                    Lable_Set.Show();
                    comboBox_CradList.Show();
                    label_SelEx.Hide();
                    lable_Select.Hide();
                    comboBox_Update.SelectedIndex = 0;
                    comboBox_CradList.Enabled = false;
                }
                else if (comboBox_Choose.SelectedItem.ToString() == "DELETE")
                {
                    comboBox_CradList.Show();
                    label_DelEx.Show();
                    lable_Select.Show();
                    comboBox_Update.Hide();
                    label_SelEx.Hide();
                    label_UpEx.Hide();
                    Lable_Set.Hide();
                    comboBox_CradList.SelectedIndex = comboBox_Update.SelectedIndex;
                    

                }
            }    
        }
    }
//}

    

