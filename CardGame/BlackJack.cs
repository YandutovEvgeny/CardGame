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

        public void GetCard()
        {
            Table.Add(deck.GetCard());  //Метод, который берёт карту из колоды и кладёт на стол
            ChangeScore();
        }

        public void ChangeScore()
        {
            Score = 0;
            int count = 0;
            foreach(Card card in Table)
            {
                if(card.Number != 1)    //если карта не туз
                {
                    Score += card.Number < 10 ? card.Number : 10;
                }
                else
                {
                    count++;
                }
            }
            for (int i = 0; i < count; i++)
            {
                if(Score + 11 <= 21)
                {
                    Score += 11;
                }
                else
                {
                    Score++;
                }
            }
        }
    }
}
