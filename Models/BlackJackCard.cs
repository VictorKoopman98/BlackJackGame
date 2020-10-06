using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace BlackJackGame.Models.Domain
{
    public class BlackJackCard : Card
    {
        public bool FaceUp { get; private set; }
        public int Value 
        {
            get { return FaceUp ? Math.Min(10, (int)FaceValue) : 0; } 
        }
        public BlackJackCard(FaceValue faceValue, Suit suit) : base(faceValue, suit)
        {
            FaceUp = false;
        }
        public void TurnCard()
        {
            FaceUp = !FaceUp;
        }
    }
}
