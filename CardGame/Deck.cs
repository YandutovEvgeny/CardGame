using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CardGame
{
    class Deck
    {
        List<Card> cards;   //Список карт
        string[] names;     //Массив мастей
        public int Count { get; private set; }

        public Deck()
        {
            cards = new List<Card>();
            names = new string[4] { "♥", "♦", "♣", "♠" };
            GenerateDeck();
            Count = cards.Count;
        }

        void GenerateDeck()
        {
            int count = 1;
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    string path = "c:\\cards\\image_part_0";
                    if (count < 10) //если число в пути к файлу меньше 10
                        path += "0";    //добавляем 0 к пути к файлу
                    path += count.ToString() + ".jpg";
                    cards.Add(new Card(names[j], i + 1, new Bitmap(path), new Bitmap("c:\\cards\\back.jpg")));
                    count++;
                }
            }
        }
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < Count; i++)
            {
                int index = random.Next(Count);
                Card buffer = cards[i];
                cards[i] = cards[index];
                cards[index] = buffer;
            }
        }
        public Card GetCard()
        {

            if (Count - 1 >= 0) //если карты ещё есть в колоде
            {
                Card buffer = cards[Count - 1]; //берём первую карту
                cards.RemoveAt(Count - 1);      //удаляем карту которую достали
                Count = cards.Count;            //теперь в колоде -1 карта
                return buffer;                  //возвращаем выбранную карту 
            }
            else
                return null;
        }
        public void AddCard(Card card)
        {
            cards.Add(card);
            Count = cards.Count;
        }
    }
}
