using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApplication1
{
    public enum CardSuits
    {
        Heart,
        Spade,
        Club,
        Diamond
    }

    public enum CardValues
    {
        Ace, Deuce, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }

    public enum FacingSides
    {
        FaceUp,
        FaceDown
    }

    public class Card
    {
        private Image faceImage;
        private Image backImage;
        private CardSuits cardSuit;
        private CardValues cardValue;
        private FacingSides facingSide = FacingSides.FaceDown;
        private string tag;

        public Card(CardSuits suit, CardValues cardVal)
        {
            cardSuit = suit;
            cardValue = cardVal;

            faceImage = ImageHelper.GetFaceImageForCard(this);
            backImage = ImageHelper.GetBackImage();
        }

        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }

        public Image FaceImage
        {
            get { return faceImage; }
        }

        public Image BackImage
        {
            get { return backImage; }
        }

        public FacingSides FacingSide
        {
            get { return facingSide; }
            set { facingSide = value; }
        }

        public Image FacingImage
        {
            get
            {
                if (facingSide == FacingSides.FaceDown)
                    return BackImage;
                else
                    return FaceImage;
            }
        }

        public CardSuits Suit
        {
            get { return cardSuit; }
            set { cardSuit = value; }
        }

        public CardValues Value
        {
            get { return cardValue; }
            set { cardValue = value; }
        }

        public string TextValue
        {
            get
            {
                string val = "";

                val += Convert.ToInt32(this.Value + 1).ToString();

                if (val == "1") val = "A";
                if (val == "11") val = "J";
                if (val == "12") val = "Q";
                if (val == "13") val = "K";

                if (this.Suit == CardSuits.Club) val += ",Clubs";
                if (this.Suit == CardSuits.Diamond) val += ",Diamonds";
                if (this.Suit == CardSuits.Heart) val += ",Hearts";
                if (this.Suit == CardSuits.Spade) val += ",Spades";

                return val;
            }
        }

        public FacingSides Flip()
        {
            if (facingSide == FacingSides.FaceDown)
                this.FacingSide = FacingSides.FaceUp;
            else
                this.FacingSide = FacingSides.FaceDown;

            return FacingSide;
        }

        public override string ToString()
        {
            string val = "";

            val += Convert.ToInt32(this.Value + 1).ToString();

            if (val == "1") val = "A";
            if (val == "11") val = "J";
            if (val == "12") val = "Q";
            if (val == "13") val = "K";

            if (this.Suit == CardSuits.Club) val += ",Clubs";
            if (this.Suit == CardSuits.Diamond) val += ",Diamonds";
            if (this.Suit == CardSuits.Heart) val += ",Hearts";
            if (this.Suit == CardSuits.Spade) val += ",Spades";

            return val;
        }


    }
}
