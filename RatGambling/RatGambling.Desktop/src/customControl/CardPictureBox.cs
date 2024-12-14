using RatGambling.Core.src.Card;
using RatGambling.Desktop.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatGambling.Desktop.src.customControl
{
    internal class CardPictureBox : PictureBox
    {
        /// <summary>
        /// Dictionary for getting card images by suit and value of card.
        /// </summary>
        public static readonly Dictionary<(CardSuit, CardType), Image> CardImagesBySuitAndValue = new(){
            // Hearts
            { (CardSuit.Hearts, CardType.Two)      ,   PokerCardsResources._2_of_hearts         },
            { (CardSuit.Hearts, CardType.Three)    ,   PokerCardsResources._3_of_hearts         },
            { (CardSuit.Hearts, CardType.Four)     ,   PokerCardsResources._4_of_hearts         },
            { (CardSuit.Hearts, CardType.Five)     ,   PokerCardsResources._5_of_hearts         },
            { (CardSuit.Hearts, CardType.Six)      ,   PokerCardsResources._6_of_hearts         },
            { (CardSuit.Hearts, CardType.Seven)    ,   PokerCardsResources._7_of_hearts         },
            { (CardSuit.Hearts, CardType.Eight)    ,   PokerCardsResources._8_of_hearts         },
            { (CardSuit.Hearts, CardType.Nine)     ,   PokerCardsResources._9_of_hearts         },
            { (CardSuit.Hearts, CardType.Ten)      ,   PokerCardsResources._10_of_hearts        },
            { (CardSuit.Hearts, CardType.Jack)     ,   PokerCardsResources.jack_of_hearts       },
            { (CardSuit.Hearts, CardType.Queen)    ,   PokerCardsResources.queen_of_hearts      },
            { (CardSuit.Hearts, CardType.King)     ,   PokerCardsResources.king_of_hearts       },
            { (CardSuit.Hearts, CardType.Ace)      ,   PokerCardsResources.ace_of_hearts        },

            { (CardSuit.Hearts, CardType.Joker)    ,   PokerCardsResources.red_joker            },
            // Clubs
            { (CardSuit.Clubs, CardType.Two)       ,   PokerCardsResources._2_of_clubs          },
            { (CardSuit.Clubs, CardType.Three)     ,   PokerCardsResources._3_of_clubs          },
            { (CardSuit.Clubs, CardType.Four)      ,   PokerCardsResources._4_of_clubs          },
            { (CardSuit.Clubs, CardType.Five)      ,   PokerCardsResources._5_of_clubs          },
            { (CardSuit.Clubs, CardType.Six)       ,   PokerCardsResources._6_of_clubs          },
            { (CardSuit.Clubs, CardType.Seven)     ,   PokerCardsResources._7_of_clubs          },
            { (CardSuit.Clubs, CardType.Eight)     ,   PokerCardsResources._8_of_clubs          },
            { (CardSuit.Clubs, CardType.Nine)      ,   PokerCardsResources._9_of_clubs          },
            { (CardSuit.Clubs, CardType.Ten)       ,   PokerCardsResources._10_of_clubs         },
            { (CardSuit.Clubs, CardType.Jack)      ,   PokerCardsResources.jack_of_clubs        },
            { (CardSuit.Clubs, CardType.Queen)     ,   PokerCardsResources.queen_of_clubs       },
            { (CardSuit.Clubs, CardType.King)      ,   PokerCardsResources.king_of_clubs        },
            { (CardSuit.Clubs, CardType.Ace)       ,   PokerCardsResources.ace_of_clubs         },

            { (CardSuit.Clubs, CardType.Joker)     ,   PokerCardsResources.black_joker          },
            // Diamonds
            { (CardSuit.Diamonds, CardType.Two)    ,   PokerCardsResources._2_of_diamonds       },
            { (CardSuit.Diamonds, CardType.Three)  ,   PokerCardsResources._3_of_diamonds       },
            { (CardSuit.Diamonds, CardType.Four)   ,   PokerCardsResources._4_of_diamonds       },
            { (CardSuit.Diamonds, CardType.Five)   ,   PokerCardsResources._5_of_diamonds       },
            { (CardSuit.Diamonds, CardType.Six)    ,   PokerCardsResources._6_of_diamonds       },
            { (CardSuit.Diamonds, CardType.Seven)  ,   PokerCardsResources._7_of_diamonds       },
            { (CardSuit.Diamonds, CardType.Eight)  ,   PokerCardsResources._8_of_diamonds       },
            { (CardSuit.Diamonds, CardType.Nine)   ,   PokerCardsResources._9_of_diamonds       },
            { (CardSuit.Diamonds, CardType.Ten)    ,   PokerCardsResources._10_of_diamonds      },
            { (CardSuit.Diamonds, CardType.Jack)   ,   PokerCardsResources.jack_of_diamonds     },
            { (CardSuit.Diamonds, CardType.Queen)  ,   PokerCardsResources.queen_of_diamonds    },
            { (CardSuit.Diamonds, CardType.King)   ,   PokerCardsResources.king_of_diamonds     },
            { (CardSuit.Diamonds, CardType.Ace)    ,   PokerCardsResources.ace_of_diamonds      },

            { (CardSuit.Diamonds, CardType.Joker)  ,   PokerCardsResources.red_joker            },
            // Spades
            { (CardSuit.Spades, CardType.Two)      ,   PokerCardsResources._2_of_spades         },
            { (CardSuit.Spades, CardType.Three)    ,   PokerCardsResources._3_of_spades         },
            { (CardSuit.Spades, CardType.Four)     ,   PokerCardsResources._4_of_spades         },
            { (CardSuit.Spades, CardType.Five)     ,   PokerCardsResources._5_of_spades         },
            { (CardSuit.Spades, CardType.Six)      ,   PokerCardsResources._6_of_spades         },
            { (CardSuit.Spades, CardType.Seven)    ,   PokerCardsResources._7_of_spades         },
            { (CardSuit.Spades, CardType.Eight)    ,   PokerCardsResources._8_of_spades         },
            { (CardSuit.Spades, CardType.Nine)     ,   PokerCardsResources._9_of_spades         },
            { (CardSuit.Spades, CardType.Ten)      ,   PokerCardsResources._10_of_spades        },
            { (CardSuit.Spades, CardType.Jack)     ,   PokerCardsResources.jack_of_spades       },
            { (CardSuit.Spades, CardType.Queen)    ,   PokerCardsResources.queen_of_spades      },
            { (CardSuit.Spades, CardType.King)     ,   PokerCardsResources.king_of_spades       },
            { (CardSuit.Spades, CardType.Ace)      ,   PokerCardsResources.ace_of_spades        },

            { (CardSuit.Spades, CardType.Joker)    ,   PokerCardsResources.black_joker          },
        };

        public readonly Image image;
        public readonly Card card;

        public CardPictureBox(Card card) : this()
        {
            this.card = card;
        }

        public CardPictureBox(CardSuit suit, CardType value) : this()
        {
            card = new Card(value, suit);
        }

        private CardPictureBox()
        {
            Debug.Assert(card != null);
            CardImagesBySuitAndValue.TryGetValue((card.Suit, card.Type), out Image? foundImage);
            if (foundImage != null) image = foundImage;
            else image = PokerCardsResources.not_found;
        }
    }
}
