using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ConsoleApp1.Session_03_2
{
    internal class Bài_tập_1_xúc_xắc
    {
        public static void Main31(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" DICE RACE GAME");
            Random rand = new Random();
            int balance = 100;
            while (balance > 0)
            {
                int bet = 0;
                while (bet <= 0 || bet > balance)
                    Console.WriteLine("Nhập điểm đặt cược");
                bet = int.Parse(Console.ReadLine());
                int p1 = rand.Next(1, 7);
                int p2 = rand.Next(1, 7);
                int b1 = rand.Next(1, 7);
                int b2 = rand.Next(1, 7);
                Console.WriteLine($"Player rolled :{p1} and {p2}");
                Console.WriteLine($"Bot rolled :{b1} and {b2}");
                int playertotal = p1 + p2;
                int bottotal = b1 + b2;
                bool playerHasPair = (p1 == p2);
                bool botHasPair = (b1 == b2);
                if (playerHasPair && !botHasPair)
                {
                    Console.WriteLine(" player wins double!");
                    balance += bet * 2;
                }
                else if (!playerHasPair && botHasPair)
                {
                    Console.WriteLine(" bot wins double!");
                    balance -= bet * 2;
                }
                else if (playerHasPair && botHasPair)
                {
                    if (playertotal > bottotal)
                    {
                        Console.WriteLine("Both got pairs! player wins double!");
                        balance += bet * 2;
                    }
                    else if (playertotal < bottotal)
                    {
                        Console.WriteLine("Both got pairs! bot wins double!");
                        balance -= bet * 2;
                    }
                    else
                    {
                        Console.WriteLine("Both got identical pairs! It is tie");
                    }
                }
                else
                {
                    if (playertotal > bottotal)
                    {
                        Console.WriteLine("player wins");
                        balance += bet;
                    }
                    else if (playertotal < bottotal)
                    {
                        Console.WriteLine("bot wins");
                        balance -= bet;
                    }
                    else
                    {
                        Console.WriteLine("It is tie");
                    }
                }
                Console.WriteLine($"Current balance: {balance}");
            }

        }
    }
}
    

