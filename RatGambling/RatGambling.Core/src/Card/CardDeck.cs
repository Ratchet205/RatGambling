using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatGambling.Core.src.Card
{
    public class CardDeck : IEnumerable<Card>
    {
        private List<Card> cards = [];
        private List<CardType> excludees = [];
        public List<CardType> Excludees => excludees;

        public CardDeck() { }
        public CardDeck(List<Card> cards)
        {
            this.cards = cards;
        }

        public static implicit operator CardDeck(List<Card> cards)
        {
            return new CardDeck(cards);
        }

        #region CardDeckOperators
        public static CardDeck operator +(CardDeck a, CardDeck b)
        {
            foreach(Card card in b.cards)
            {
                a.cards.Add(card);
            }
            return a;
        }
        public static CardDeck operator +(CardDeck deck, Card card)
        {
            deck.cards.Add(card);
            return deck;
        }

        public static CardDeck operator -(CardDeck deck, Card[] cards)
        {
            foreach (var card in cards)
            {
                deck.cards.Remove(card);
            }
            return deck;
        }

        public static CardDeck operator -(CardDeck deck, Card card)
        {
            deck.cards.Remove(card);
            return deck;
        }
        #endregion

        public Card Draw()
        {
            Card drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;
        }

        public void Shuffle()
        {
            for(int i = 0; i < 5; i++)
            {
                // Split the deck roughly in half
                int halfSize = cards.Count / 2;
                List<Card> deckHalfA = new List<Card>(cards.Take(halfSize));
                List<Card> deckHalfB = new List<Card>(cards.Skip(halfSize));

                cards.Clear();
                Random rnd = new Random();

                // Perform a riffle shuffle by interleaving cards from each half
                while (deckHalfA.Count > 0 || deckHalfB.Count > 0)
                {
                    if (deckHalfA.Count > 0 && deckHalfB.Count > 0)
                    {
                        // Randomly choose which half to take the next card from
                        if (rnd.Next(2) == 0)
                        {
                            cards.Add(deckHalfA[0]);
                            deckHalfA.RemoveAt(0);
                        }
                        else
                        {
                            cards.Add(deckHalfB[0]);
                            deckHalfB.RemoveAt(0);
                        }
                    }
                    else if (deckHalfA.Count > 0)
                    {
                        // If one half is empty, add remaining cards from the other half
                        cards.Add(deckHalfA[0]);
                        deckHalfA.RemoveAt(0);
                    }
                    else if (deckHalfB.Count > 0)
                    {
                        cards.Add(deckHalfB[0]);
                        deckHalfB.RemoveAt(0);
                    }
                }
            }
        }

        public IEnumerator<Card> GetEnumerator()
        {
            return cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void CreateDeck()
        {
            List<Card> deck = new();
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardType type in Enum.GetValues(typeof(CardType)))
                {
                    if(!excludees.Contains(type))
                    {
                        deck.Add(new(type, suit));
                    }
                }
            }
            cards = deck;
        }

        public void CreateDeck(params CardType[] values)
        {
            List<Card> deck = new();
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardType type in Enum.GetValues(typeof(CardType)))
                {
                    if(!values.Contains(type))
                    {
                        deck.Add(new(type, suit));
                    }
                }
            }
            cards = deck;
        }
    }
}
