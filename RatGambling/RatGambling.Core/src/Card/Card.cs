using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatGambling.Core.src.Card
{
    public class Card
    {
        public static List<Card> CreateDeck()
        {
            List<Card> deck = new();
            foreach(CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach(CardValue type in Enum.GetValues(typeof(CardValue)))
                {
                    deck.Add(new(type, suit));
                }
            }
            return deck;
        }


        private readonly CardSuit _suit;
        public CardSuit Suit => _suit;

        private readonly CardValue _type;
        public CardValue Type => _type;
        public int Value => (int) _type;

        public Card(CardValue type, CardSuit suit)
        {
            _suit = suit;
            _type = type;
        }

        public override string ToString() => $"{_type} of {_suit}";
    }
}
