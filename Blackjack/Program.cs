// See https://aka.ms/new-console-template for more information
using Blackjack;
using System;
using System.ComponentModel;
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
                int totalNumDeal1 = 0;//dealer number holder 1, these are mainly for aces as they can be 1 or 11.
                int totalNumDeal2 = 0;//dealer number holder 2, So if an ace appears, one holder will have 1 added to it and the other 11.
                int totalNumPlay1 = 0;//player number holder 1
                int totalNumPlay2 = 0;//player number holder 2
                int hit = 1; //hit = 1, stand = 0
                int card = 1;//card number
                int aceCount = 0;
                string faceDown = "";
                while (gameOver != 0)
                {
                    int dealDone = 0;
                    int playDone = 0;
                    string dealer = "";
                    string player = "";
                    string win = "";
                    while (dealDone != 1 || playDone != 1)
                    {
                        utilities n = new utilities();

                        n.cardDraw(hit, ref totalNumDeal1, ref totalNumDeal2, ref totalNumPlay1, ref totalNumPlay2, ref aceCount, ref card, ref faceDown);

                        if (card >= 3)//If there are 2 or more cards (cards starts at 1)
                        {
                            if (hit == 1) //dealer
                            {
                                if (aceCount != 0)//If the dealer got an ace
                                {
                                    if (totalNumDeal2 > 21) //Checks to see if the max value is over 21
                                    {
                                        if (totalNumDeal1 <= 16)//If the minimum number is less than or equal to 16 the dealer gets another card
                                        {
                                        }
                                        else //If over 16, the acecount and card resets, the hit variable is changed to 2 so the program switches to adding card values to the player variable
                                        { // it sets the dealer to done and gives the dealer variable a basic sentence of their face down card and their point value
                                            aceCount = 0;
                                            hit = 2;
                                            dealer = "The dealers face down card is " + faceDown + " for a total of " + totalNumDeal1 + " points.";
                                            card = 1;
                                            dealDone = 1;
                                        }
                                    }
                                    else
                                    {
                                        if (totalNumDeal1 <= 16 && totalNumDeal2 <= 16)//If the minimum number is less than or equal to 16 and the max number less than or equal to 16
                                        {
                                        }
                                        else //If over 16, the acecount and card resets, the hit variable is changed to 2 so the program switches to adding card values to the player variable
                                        { // it sets the dealer to done and gives the dealer variable a basic sentence of their face down card and their point value
                                            aceCount = 0;
                                            dealer = "The dealers face down card is " + faceDown + " for a total of " + totalNumDeal2 + " points.";
                                            hit = 2;
                                            card = 1;
                                            dealDone = 1;
                                        }
                                    }
                                }
                                else
                                {

                                    if (totalNumDeal1 <= 16 || totalNumDeal2 <= 16)//If the minimum number is less than or equal to 16 and the max number less than or equal to 16
                                    {
                                    }
                                    else //If over 16, the acecount and card resets, the hit variable is changed to 2 so the program switches to adding card values to the player variable
                                    { // it sets the dealer to done and gives the dealer variable a basic sentence of their face down card and their point value
                                        dealer = "The dealers face down card is " + faceDown + " for a total of " + totalNumDeal2 + " points.";
                                        hit = 2;
                                        aceCount = 0;
                                        card = 1;
                                        dealDone = 1;
                                    }
                                }
                            }
                            else
                            {
                                if (totalNumPlay1 > 21) //Checks to see if the max value is over 21 and ends the game if it is
                                {
                                    player = "Your card total is " + totalNumPlay1 + " points.";
                                    gameOver = 0;
                                    break;
                                }
                                else
                                {
                                    if (aceCount != 0) //If the player got an ace, it informs them of their points and asks them if they want to hit or stand
                                    {
                                        Console.WriteLine("Your current point total is " + totalNumPlay1 + " or " + totalNumPlay2 + ", type 1 to hit or type 2 to stand!");
                                        hit = int.Parse(Console.ReadLine());
                                        while (hit != 1 && hit != 2)//while the number entered isn't 1 or 2 then the user will have to keep entering a number until it is 1 or 2
                                        {
                                            Console.WriteLine("Incorrect number submitted! Your current point total is " + totalNumPlay1 + " or " + totalNumPlay2 + ", type 1 to hit or type 2 to stand!");
                                            hit = int.Parse(Console.ReadLine());
                                        }
                                        if (hit == 1)//if hit is entered, then another card is drew
                                        {
                                            hit = 2;
                                        }
                                        else//if stand is entered
                                        {
                                            playDone = 1;//player done
                                            hit = 0;
                                            if (totalNumPlay2 >= 22)//if the max number is over 21 
                                            {
                                                player = "Your card total is " + totalNumPlay1 + " points.";
                                                if (totalNumDeal1 >= totalNumDeal2)// if the minimum dealer number is more than or equal to the max
                                                {
                                                    n.checkWin(totalNumPlay1, totalNumDeal1, ref win, ref gameOver);
                                                }
                                                else
                                                {
                                                    n.checkWin(totalNumPlay1, totalNumDeal2, ref win, ref gameOver);
                                                }
                                            }
                                            else
                                            {
                                                if (totalNumDeal1 >= totalNumDeal2)// if the minimum dealer number is more than or equal to the max
                                                {
                                                    n.checkWin(totalNumPlay2, totalNumDeal1, ref win, ref gameOver);
                                                }
                                                else
                                                {
                                                    n.checkWin(totalNumPlay2, totalNumDeal2, ref win, ref gameOver);
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {//if the player doesnt get an ace it tells them their point total and asks if they want to hit or stand
                                        Console.WriteLine("Your current point total is " + totalNumPlay1 + ", type 1 to hit or type 2 to stand!");
                                        hit = int.Parse(Console.ReadLine());
                                        while (hit != 1 && hit != 2) //while hit isnt 1 or 2, it keeps asking them to re enter it
                                        {
                                            Console.WriteLine("Incorrect number submitted! Your current point total is " + totalNumPlay2 + ", type 1 to hit or type 2 to stand!");
                                            hit = int.Parse(Console.ReadLine());
                                        }
                                        if (hit == 1)//if they choose to hit then another card is selected
                                        {
                                            hit = 2;
                                        }
                                        else
                                        {//if the player stand
                                            playDone = 1;//the player is set to finished
                                            hit = 0;
                                            player = "Your card total is " + totalNumPlay1 + " points.";
                                            if (totalNumDeal1 >= totalNumDeal2)// if the minimum dealer number is more than or equal to the max
                                            {
                                                n.checkWin(totalNumPlay1, totalNumDeal1, ref win, ref gameOver);
                                            }
                                            else
                                            {
                                                n.checkWin(totalNumPlay1, totalNumDeal2, ref win, ref gameOver);
                                            }


                                        }
                                    }
                                }
                            }
                            
                        }

                    }

                    if (totalNumPlay1 > 21)//If the players card count goes over 21 then they lose and go bust
                    {

                        win = "have went bust! You lose!";
                    }
                    else if (totalNumDeal1 > 21)//if the dealer goes over 21 then they lose and go bust
                    {
                        win = "win! The dealer went bust!";
                    }
                    Console.WriteLine(dealer);//prints message for the dealers total card count
                    Console.WriteLine(player);//prints message for the players total card count
                    Console.WriteLine("You " + win);//prints result of the game

                }
            }


        }
    }
}

