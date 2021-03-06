﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jihanki
{
    //自販機クラス
    class Jihanki
    {
        //飲み物名前配
        public string[] name = new string[5];
        public int[] price = new int[5];
        public int[] num = new int[5];

        //コンストラクタ
        public Jihanki()
        {
            name[0] = "水";
            name[1] = "コーラ";
            name[2] = "おしるこ";
            name[3] = "めんつゆ";
            name[4] = "RedBlue";
            price[0] = 120;
            price[1] = 60;
            price[2] = 160;
            price[3] = 220;
            price[4] = 230;
            num[0] = 5;
            num[1] = 3;
            num[2] = 2;
            num[3] = 8;
            num[4] = 255;
        }

        //すべてのドリンクの表示
        public void ShowDrink()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + "." + name[i] + " " + price[i] + "円 " + num[i] + "個");
            }
        }
        


        //ドリンク購入
        /// <param name="coin"> 支払う額</param>
        /// <param name="index"> 買いたいDrink配列の要素番号</param>
        public void DrinkBuy(int coin, int index)
        {
            if (price[index] == coin)
            {
                if (num[index] == 0)
                    Console.WriteLine("品切れデス");
                else
                {
                    Console.WriteLine("アリガトウゴザマス！！");
                    num[index]--;
                }
            }
            else
                Console.WriteLine("チョウドガイイデスナァ！");

        }

    }
}
