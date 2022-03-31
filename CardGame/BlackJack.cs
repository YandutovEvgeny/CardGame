using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class BlackJack
    {
        Deck deck;
        public List<Card> Table { get; private set; }
        public int Score { get; private set; }

        public BlackJack()
        {
            deck = new Deck();
            Table = new List<Card>();
            Score = 0;
            deck.Shuffle();
        }
    }
}
