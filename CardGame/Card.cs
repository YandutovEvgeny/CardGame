using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CardGame
{
    class Card
    {
        public string Suit { get; private set; }    //Масть
        public int Number { get; private set; }     //Цифра
        public bool IsShirt { get; private set; }   //Сторона карты
        public Bitmap Front { get; private set; }   //Передняя сторона(картинка)
        public Bitmap Back { get; private set; }    //Задняя сторона(картинка)
        //Конструктор:
        public Card(string suit, int number, Bitmap front, Bitmap back)
        {
            Suit = suit;
            Number = number;
            Front = front;
            Back = back;
            IsShirt = false;    //Изначально карта лежит рубашкой вниз 
        }
        public void Reverse()
        {
            IsShirt = !IsShirt;     
        }
    }
}
