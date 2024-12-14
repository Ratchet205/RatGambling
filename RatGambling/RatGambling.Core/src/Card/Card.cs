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

        private readonly CardType _type;
        public CardType Type => _type;
        public int Value => (int) _type;

        public Card(CardType type, CardSuit suit)
        {
            _suit = suit;
            _type = type;
        }

        public override string ToString() => $"{Enum.GetName(typeof(CardType), _type)} of {_suit}";
    }
}
