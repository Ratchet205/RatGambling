using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatGambling.Core.src.Card
{
    public class Card
    {
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

        public override string ToString() => $"{Enum.GetName(typeof(CardValue), _type)} of {_suit}";
    }
}
