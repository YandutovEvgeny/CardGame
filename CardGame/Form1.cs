using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class Form1 : Form
    {
        BlackJack blackJack;
        List<PictureBox> myCards;
        public Form1()
        {
            InitializeComponent();
            blackJack = new BlackJack();
            myCards = new List<PictureBox>()
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7
            };
        }

        void ShowTable()
        {
            for (int i = 0; i < blackJack.Table.Count; i++)     //Идём по картам на нашем столе
            {
                if(i<myCards.Count) //Если карт на столе не больше чем нужно
                {
                    myCards[i].Image = blackJack.Table[i].Front;    //Показываем на экран карту
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blackJack.GetCard();
            ShowTable();
            label1.Text = "Счёт:" + blackJack.Score.ToString();
            if(blackJack.Score == 21)
            {
                MessageBox.Show("Вы выйграли!");
                button3.PerformClick();     //Программное нажатие кнопки
            }
            else if(blackJack.Score > 21)
            {
                MessageBox.Show("Вы проиграли!");
                button3.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            blackJack = new BlackJack();                //Новая колода карт
            for (int i = 0; i < myCards.Count; i++)     //Обнуляем картинки
            {
                myCards[i].Image = null;
            }
            label1.Text = "Счёт: ";                     //Обнуляем счёт
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Вы закончили игру с {blackJack.Score} очками");
            button3.PerformClick();
        }
    }
}
