using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace BlackJackGame.Models.Domain
{
    public class Deck
    {
        private static readonly Random _random = new Random();
        protected IList<BlackJackCard> _cards;
        public Deck()
        {
            _cards = new List<BlackJackCard>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (FaceValue faceValue in Enum.GetValues(typeof(FaceValue)))
                {
                    _cards.Add(new BlackJackCard(faceValue, suit));
                }
            }
            Shuffle();
        }
        public BlackJackCard Draw()
        {
            if (_cards.Count == 0)
                throw new InvalidOperationException("No cards left in deck");
            BlackJackCard card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }

        private void Shuffle()
        {
            for (int i = 0; i < _cards.Count; i++)
            {
                int position = _random.Next(0, _cards.Count);
                BlackJackCard card = _cards[position];
                _cards.RemoveAt(position);
                _cards.Add(card);
            }
        }
    }
}
