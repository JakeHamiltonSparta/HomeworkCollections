using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Week2Day3Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach therapy = new Coach();
            Coach tobiamus = new Coach();
            Player josh = new Player();
            Player tom = new Player();
            Player jake = new Player();
            Player joe = new Player();
            Player ben = new Player();

            Squad newSquad = new Squad();
            newSquad.SquadArray();
        }


        class FreeAgents : Player
        {
            private double kd = 1.3;

            public void SetKD(double gameKD)
            {
                if (gameKD < 0)
                {
                    gameKD = 0;
                }
                else
                {
                    kd = gameKD;
                }
            }
            public double GetKD()
            {
                return kd;
            }


            private int previousEarnings;
            public void SetPreviousEarnings(int earings)
            {
                if (earings < 0)
                {
                    earings = 0;
                }
                else
                {
                    previousEarnings = earings;
                }
            }
            public int GetPreviousEarnings()
            {
                return previousEarnings;
            }
            public FreeAgents()
            {
                previousEarnings = 100;
            }
            public void PrintStatus()
            {
                Console.WriteLine("My previous earnings are "+ previousEarnings);
                Console.WriteLine("My current K/D"+ kd);
            }

        }

        class Squad : Player
        {
            private int wins;
            public void SetWins(int squadWins)
            {
                if (squadWins < 0)
                {
                    squadWins = 0;
                }
                else
                {
                    wins = squadWins;
                }
            }
            public int GetWins()
            {
                return wins;
            }

            private string player1;
            public void SetPlayer1(string player1Info)
            {
                for (int i = 0; i < player1Info.Length; i++)
                {
                    if (Char.IsUpper(player1Info[i]))
                    {
                        Char.ToLower(player1Info[i]);
                    }
                }
                Char.ToUpper(player1Info[0]);
            }
            public string GetPlayer1()
            {
                return player1;
            }

            private string player2;
            public void SetPlayer2(string player2Info)
            {
                for (int i = 0; i < player2Info.Length; i++)
                {
                    if (Char.IsUpper(player2Info[i]))
                    {
                        Char.ToLower(player2Info[i]);
                    }
                }
                Char.ToUpper(player2Info[0]);
            }
            public string GetPlayer2()
            {
                return player2;
            }

            private string player3;
            public void SetPlayer3(string player3Info)
            {
                for (int i = 0; i < player3Info.Length; i++)
                {
                    if (Char.IsUpper(player3Info[i]))
                    {
                        Char.ToLower(player3Info[i]);
                    }
                }
                Char.ToUpper(player3Info[0]);
            }
            public string GetPlayer3()
            {
                return player3;
            }

            private string player4;
            public void SetPlayer4(string player4Info)
            {
                for (int i = 0; i < player4Info.Length; i++)
                {
                    if (Char.IsUpper(player4Info[i]))
                    {
                        Char.ToLower(player4Info[i]);
                    }
                }
                Char.ToUpper(player4Info[0]);
            }
            public string GetPlayer4()
            {
                return player4;
            }

            private string player5;
            public void SetPlayer5(string player5Info)
            {
                for (int i = 0; i < player5Info.Length; i++)
                {
                    if (Char.IsUpper(player5Info[i]))
                    {
                        Char.ToLower(player5Info[i]);
                    }
                }
                Char.ToUpper(player5Info[0]);
            }
            public string GetPlayer5()
            {
                return player5;
            }

            private string player6;
            public void SetPlayer6(string player6Info)
            {
                for (int i = 0; i < player6Info.Length; i++)
                {
                    if (Char.IsUpper(player6Info[i]))
                    {
                        Char.ToLower(player6Info[i]);
                    }
                }
                Char.ToUpper(player6Info[0]);
            }
            public string GetPlayer6()
            {
                return player6;
            }

            string[] playerArray = new string[5];
            public void SquadArray()
            {
                playerArray[0] = "Josh : 1.4";
                playerArray[1] = "Joe : 1.32";
                playerArray[2] = "Ben : 1.23";
                playerArray[3] = "Tom : 1.1";
                playerArray[4] = "Jake : 1.17";
                playerArray[5] = "Toby : 1.39";

                //for (int i = 0; i < playerArray.Length -1; i++)
                //{
                //    Console.WriteLine(playerArray[i]);
                //}
                Console.WriteLine(playerArray[0] + "\r\n" + playerArray[1] + "\r\n" + playerArray[2] + "\r\n" + playerArray[3] + "\r\n" + playerArray[4] + "\r\n" + playerArray[5]);
                Console.ReadLine();
            }
        }
    }
}
