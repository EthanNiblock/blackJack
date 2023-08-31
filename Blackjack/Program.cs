// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace BlackjackTest
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int menuChoice = 1;

            while (menuChoice != 0)
            {

                string menu = @"**********************************
*              Menu              *
*         Press 1 to Play        *
*         Press 0 to Exit        *
*                                *
**********************************";
                Console.WriteLine(menu);
                menuChoice = int.Parse(Console.ReadLine());

                int gameOver = 1;
                var randNum = new Random();
                int totalNumDeal1 = 0;//dealer number holder 1, these are mainly for aces as they can be 1 or 11.
                int totalNumDeal2 = 0;//dealer number holder 2, So if an ace appears, one holder will have 1 added to it and the other 11.
                int totalNumPlay1 = 0;//player number holder 1
                int totalNumPlay2 = 0;//player number holder 2
                int hit = 1; //hit = 1, stand = 0
                int card = 1;//card number
                string faceDown = "";
                while (gameOver != 0)
                {
                    int randomNum = randNum.Next(0, 13);
                    //Dealer first then player
                    switch (randomNum)
                    {
                        case 0: //ace

                            //int hold;
                            //do
                            //{
                            //    Console.WriteLine("Your first card is an Ace, do you want it to be worth 1 or 11?");
                            //    hold = int.Parse(Console.ReadLine());
                            //    if (hold != 1 || hold != 11)
                            //    {
                            //        Console.WriteLine("Please enter only 1 or 11.\n");
                            //    }
                            //    else if (hold == 1)
                            //    {
                            //    }
                            //}
                            // while (hold != 1 || hold != 11);

                            break;
                        case 1:
                            if (hit == 1)
                            {
                                totalNumDeal1 += 2;
                                totalNumDeal2 += 2;
                                if (card == 1)
                                {
                                    faceDown = "Two";
                                    card++;
                                }
                                else
                                {
                                    card++;
                                    Console.WriteLine("The dealers face up card is a Two.");
                                }
                            }
                            break;
                        case 2:
                            if (hit == 1)
                            {
                                totalNumDeal1 += 3;
                                totalNumDeal2 += 3;
                                if (card == 1)
                                {
                                    faceDown = "Three";
                                    card++;
                                }
                                else
                                {
                                    card++;
                                    Console.WriteLine("The dealers face up card is a Three.");
                                }
                            }
                            break;
                        case 3:
                            if (hit == 1)
                            {
                                totalNumDeal1 += 4;
                                totalNumDeal2 += 4;
                                if (card == 1)
                                {
                                    faceDown = "Four";
                                    card++;
                                }
                                else
                                {
                                    card++;
                                    Console.WriteLine("The dealers face up card is a Four.");
                                }
                            }
                            break;
                        case 4:
                            if (hit == 1)
                            {
                                totalNumDeal1 += 5;
                                totalNumDeal2 += 5;
                                if (card == 1)
                                {
                                    faceDown = "Five";
                                    card++;
                                }
                                else
                                {
                                    card++;
                                    Console.WriteLine("The dealers face up card is a Five.");
                                }
                            }
                            break;
                        case 5:
                            if (hit == 1)
                            {
                                totalNumDeal1 += 6;
                                totalNumDeal2 += 6;
                                if (card == 1)
                                {
                                    faceDown = "Six";
                                    card++;
                                }
                                else
                                {
                                    card++;
                                    Console.WriteLine("The dealers face up card is a Six.");
                                }
                            }
                            break;
                        case 6:
                            if (hit == 1)
                            {
                                totalNumDeal1 += 7;
                                totalNumDeal2 += 7;
                                if (card == 1)
                                {
                                    faceDown = "Seven";
                                    card++;
                                }
                                else
                                {
                                    card++;
                                    Console.WriteLine("The dealers face up card is a Seven.");
                                }
                            }
                            break;
                        case 7:
                            if (hit == 1)
                            {
                                totalNumDeal1 += 8;
                                totalNumDeal2 += 8;
                                if (card == 1)
                                {
                                    faceDown = "Eight";
                                    card++;
                                }
                                else
                                {
                                    card++;
                                    Console.WriteLine("The dealers face up card is a Eight.");
                                }
                            }
                            break;
                        case 8:
                            if (hit == 1)
                            {
                                totalNumDeal1 += 9;
                                totalNumDeal2 += 9;
                                if (card == 1)
                                {
                                    faceDown = "Nine";
                                    card++;
                                }
                                else
                                {
                                    card++;
                                    Console.WriteLine("The dealers face up card is a Nine.");
                                }
                            }
                            break;
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                            if (hit == 1)
                            {

                                totalNumDeal1 += 10;
                                totalNumDeal2 += 10; ;
                                if (randomNum == 9)
                                {
                                    if (card == 1)
                                    {
                                        faceDown = "Ten";
                                        card++;
                                    }
                                    else
                                    {
                                        card++;
                                        Console.WriteLine("The dealers face up card is a Ten.");
                                    }
                                }
                                else if (randomNum == 10)
                                {
                                    if (card == 1)
                                    {
                                        faceDown = "Jack";
                                        card++;
                                    }
                                    else
                                    {
                                        card++;
                                        Console.WriteLine("The dealers face up card is a Jack.");
                                    }
                                }
                                else if (randomNum == 11)
                                {
                                    if (card == 1)
                                    {
                                        faceDown = "Queen";
                                        card++;
                                    }
                                    else
                                    {
                                        card++;
                                        Console.WriteLine("The dealers face up card is a Queen.");
                                    }
                                }
                                else
                                {
                                    if (card == 1)
                                    {
                                        faceDown = "King";
                                        card++;
                                    }
                                    else
                                    {
                                        card++;
                                        Console.WriteLine("The dealers face up card is a King.");
                                    }
                                }
                            }
                            break;
                    }

                    if (card == 3)
                    {
                        Console.WriteLine("The dealers face down card is {0} for a total of {1} points.", faceDown, totalNumDeal1);
                        break;
                    }







                }
            }
        }


    }
}

