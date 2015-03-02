using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public static class ImageHelper
    {
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

        public static Bitmap GetBackImage()
        {
           
            Bitmap cardBack = (Bitmap)resourceManager.GetObject("card_back");

            return cardBack;
        }
    }

}
