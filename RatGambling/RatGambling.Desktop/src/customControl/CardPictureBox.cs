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
        public static readonly Dictionary<(CardSuit, CardValue), Image> CardImagesBySuitAndValue = new(){
            // Hearts
            { (CardSuit.Hearts, CardValue.Two)      ,   PokerCardsResources._2_of_hearts         },
            { (CardSuit.Hearts, CardValue.Three)    ,   PokerCardsResources._3_of_hearts         },
            { (CardSuit.Hearts, CardValue.Four)     ,   PokerCardsResources._4_of_hearts         },
            { (CardSuit.Hearts, CardValue.Five)     ,   PokerCardsResources._5_of_hearts         },
            { (CardSuit.Hearts, CardValue.Six)      ,   PokerCardsResources._6_of_hearts         },
            { (CardSuit.Hearts, CardValue.Seven)    ,   PokerCardsResources._7_of_hearts         },
            { (CardSuit.Hearts, CardValue.Eight)    ,   PokerCardsResources._8_of_hearts         },
            { (CardSuit.Hearts, CardValue.Nine)     ,   PokerCardsResources._9_of_hearts         },
            { (CardSuit.Hearts, CardValue.Ten)      ,   PokerCardsResources._10_of_hearts        },
            { (CardSuit.Hearts, CardValue.Jack)     ,   PokerCardsResources.jack_of_hearts       },
            { (CardSuit.Hearts, CardValue.Queen)    ,   PokerCardsResources.queen_of_hearts      },
            { (CardSuit.Hearts, CardValue.King)     ,   PokerCardsResources.king_of_hearts       },
            { (CardSuit.Hearts, CardValue.Ace)      ,   PokerCardsResources.ace_of_hearts        },

            { (CardSuit.Hearts, CardValue.Joker)    ,   PokerCardsResources.red_joker            },
            // Clubs
            { (CardSuit.Clubs, CardValue.Two)       ,   PokerCardsResources._2_of_clubs          },
            { (CardSuit.Clubs, CardValue.Three)     ,   PokerCardsResources._3_of_clubs          },
            { (CardSuit.Clubs, CardValue.Four)      ,   PokerCardsResources._4_of_clubs          },
            { (CardSuit.Clubs, CardValue.Five)      ,   PokerCardsResources._5_of_clubs          },
            { (CardSuit.Clubs, CardValue.Six)       ,   PokerCardsResources._6_of_clubs          },
            { (CardSuit.Clubs, CardValue.Seven)     ,   PokerCardsResources._7_of_clubs          },
            { (CardSuit.Clubs, CardValue.Eight)     ,   PokerCardsResources._8_of_clubs          },
            { (CardSuit.Clubs, CardValue.Nine)      ,   PokerCardsResources._9_of_clubs          },
            { (CardSuit.Clubs, CardValue.Ten)       ,   PokerCardsResources._10_of_clubs         },
            { (CardSuit.Clubs, CardValue.Jack)      ,   PokerCardsResources.jack_of_clubs        },
            { (CardSuit.Clubs, CardValue.Queen)     ,   PokerCardsResources.queen_of_clubs       },
            { (CardSuit.Clubs, CardValue.King)      ,   PokerCardsResources.king_of_clubs        },
            { (CardSuit.Clubs, CardValue.Ace)       ,   PokerCardsResources.ace_of_clubs         },

            { (CardSuit.Clubs, CardValue.Joker)     ,   PokerCardsResources.black_joker          },
            // Diamonds
            { (CardSuit.Diamonds, CardValue.Two)    ,   PokerCardsResources._2_of_diamonds       },
            { (CardSuit.Diamonds, CardValue.Three)  ,   PokerCardsResources._3_of_diamonds       },
            { (CardSuit.Diamonds, CardValue.Four)   ,   PokerCardsResources._4_of_diamonds       },
            { (CardSuit.Diamonds, CardValue.Five)   ,   PokerCardsResources._5_of_diamonds       },
            { (CardSuit.Diamonds, CardValue.Six)    ,   PokerCardsResources._6_of_diamonds       },
            { (CardSuit.Diamonds, CardValue.Seven)  ,   PokerCardsResources._7_of_diamonds       },
            { (CardSuit.Diamonds, CardValue.Eight)  ,   PokerCardsResources._8_of_diamonds       },
            { (CardSuit.Diamonds, CardValue.Nine)   ,   PokerCardsResources._9_of_diamonds       },
            { (CardSuit.Diamonds, CardValue.Ten)    ,   PokerCardsResources._10_of_diamonds      },
            { (CardSuit.Diamonds, CardValue.Jack)   ,   PokerCardsResources.jack_of_diamonds     },
            { (CardSuit.Diamonds, CardValue.Queen)  ,   PokerCardsResources.queen_of_diamonds    },
            { (CardSuit.Diamonds, CardValue.King)   ,   PokerCardsResources.king_of_diamonds     },
            { (CardSuit.Diamonds, CardValue.Ace)    ,   PokerCardsResources.ace_of_diamonds      },

            { (CardSuit.Diamonds, CardValue.Joker)  ,   PokerCardsResources.red_joker            },
            // Spades
            { (CardSuit.Spades, CardValue.Two)      ,   PokerCardsResources._2_of_spades         },
            { (CardSuit.Spades, CardValue.Three)    ,   PokerCardsResources._3_of_spades         },
            { (CardSuit.Spades, CardValue.Four)     ,   PokerCardsResources._4_of_spades         },
            { (CardSuit.Spades, CardValue.Five)     ,   PokerCardsResources._5_of_spades         },
            { (CardSuit.Spades, CardValue.Six)      ,   PokerCardsResources._6_of_spades         },
            { (CardSuit.Spades, CardValue.Seven)    ,   PokerCardsResources._7_of_spades         },
            { (CardSuit.Spades, CardValue.Eight)    ,   PokerCardsResources._8_of_spades         },
            { (CardSuit.Spades, CardValue.Nine)     ,   PokerCardsResources._9_of_spades         },
            { (CardSuit.Spades, CardValue.Ten)      ,   PokerCardsResources._10_of_spades        },
            { (CardSuit.Spades, CardValue.Jack)     ,   PokerCardsResources.jack_of_spades       },
            { (CardSuit.Spades, CardValue.Queen)    ,   PokerCardsResources.queen_of_spades      },
            { (CardSuit.Spades, CardValue.King)     ,   PokerCardsResources.king_of_spades       },
            { (CardSuit.Spades, CardValue.Ace)      ,   PokerCardsResources.ace_of_spades        },

            { (CardSuit.Spades, CardValue.Joker)    ,   PokerCardsResources.black_joker          },
        };

        public readonly Image image;
        public readonly Card card;

        public CardPictureBox(Card card) : this()
        {
            this.card = card;
        }

        public CardPictureBox(CardSuit suit, CardValue value) : this()
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
