using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackGame.Models.Domain
{
    public class BlackJackCard : Card
    {
        public bool FaceUp { get; private set; }
        public int Value { get; }
        public BlackJackCard(FaceValue faceValue, Suit suit) : base(faceValue, suit)
        {
            FaceUp = false;
        }
        public void TurnCard()
        {

            throw new NotImplementedException();
        }
    }
}
