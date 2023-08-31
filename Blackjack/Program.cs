// See https://aka.ms/new-console-template for more information
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
                var randNum = new Random();
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

                        int randomNum = randNum.Next(0, 13);
                        //Dealer first then player
                        switch (randomNum)
                        {
                            case 0: //Ace
                                if (hit == 1)
                                {
                                    totalNumDeal1 += 1;

                                    totalNumDeal2 += 11;
                                    
                                    aceCount++;
                                    if (card == 1)
                                    {
                                        faceDown = "Ace";
                                        card++;
                                    }
                                    else
                                    {
                                        card++;
                                        Console.WriteLine("The dealers face up card is an Ace.");
                                    }
                                }
                                else
                                {
                                    totalNumPlay1 += 1;
                                    totalNumPlay2 += 11;
                                    
                                    aceCount++;
                                    if (card == 1)
                                    {
                                        Console.WriteLine("Your first card is an Ace.");
                                        card++;
                                    }
                                    else
                                    {
                                        card++;
                                        Console.WriteLine("Your next card is an Ace.");
                                    }
                                }
                                break;
                            case 1: //Two
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
                                else
                                {
                                    totalNumPlay1 += 2;
                                    totalNumPlay2 += 2;
                                    if (card == 1)
                                    {
                                        Console.WriteLine("Your first card is an Two.");
                                        card++;
                                    }
                                    else
                                    {
                                        card++;
                                        Console.WriteLine("Your next card is an Two.");
                                    }
                                }
                                break;
                            case 2: //Three
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
                                else
                                {
                                    totalNumPlay1 += 3;
                                    totalNumPlay2 += 3;
                                    if (card == 1)
                                    {
                                        Console.WriteLine("Your first card is an Three.");
                                        card++;
                                    }
                                    else
                                    {
                                        card++;
                                        Console.WriteLine("Your next card is an Three.");
                                    }
                                }
                                break;
                            case 3: //Four
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
                                else
                                {
                                    totalNumPlay1 += 4;
                                    totalNumPlay2 += 4;
                                    if (card == 1)
                                    {
                                        Console.WriteLine("Your first card is an Four.");
                                        card++;
                                    }
                                    else
                                    {
                                        card++;
                                        Console.WriteLine("Your next card is an Four.");
                                    }
                                }
                                break;
                            case 4://Five
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
                                else
                                {
                                    totalNumPlay1 += 5;
                                    totalNumPlay2 += 5;
                                    if (card == 1)
                                    {
                                        Console.WriteLine("Your first card is an Five.");
                                        card++;
                                    }
                                    else
                                    {
                                        card++;
                                        Console.WriteLine("Your next card is an Five.");
                                    }
                                }
                                break;
                            case 5://Six
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
                                else
                                {
                                    totalNumPlay1 += 6;
                                    totalNumPlay2 += 6;
                                    if (card == 1)
                                    {
                                        Console.WriteLine("Your first card is an Six.");
                                        card++;
                                    }
                                    else
                                    {
                                        card++;
                                        Console.WriteLine("Your next card is an Six.");
                                    }
                                }
                                break;
                            case 6://Seven
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
                                else
                                {
                                    totalNumPlay1 += 7;
                                    totalNumPlay2 += 7;
                                    if (card == 1)
                                    {
                                        Console.WriteLine("Your first card is an Seven.");
                                        card++;
                                    }
                                    else
                                    {
                                        card++;
                                        Console.WriteLine("Your next card is an Seven.");
                                    }
                                }
                                break;
                            case 7://Eight
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
                                else
                                {
                                    totalNumPlay1 += 8;
                                    totalNumPlay2 += 8;
                                    if (card == 1)
                                    {
                                        Console.WriteLine("Your first card is an Eight.");
                                        card++;
                                    }
                                    else
                                    {
                                        card++;
                                        Console.WriteLine("Your next card is an Eight.");
                                    }
                                }
                                break;
                            case 8://Nine
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
                                else
                                {
                                    totalNumPlay1 += 9;
                                    totalNumPlay2 += 9;
                                    if (card == 1)
                                    {
                                        Console.WriteLine("Your first card is an Nine.");
                                        card++;
                                    }
                                    else
                                    {
                                        card++;
                                        Console.WriteLine("Your next card is an Nine.");
                                    }
                                }
                                break;
                            case 9://Ten and Face Cards
                            case 10:
                            case 11:
                            case 12:
                                if (hit == 1)
                                {

                                    totalNumDeal1 += 10;
                                    totalNumDeal2 += 10;
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
                                else
                                {
                                    totalNumPlay1 += 10;
                                    totalNumPlay2 += 10;
                                    if (randomNum == 9)
                                    {
                                        if (card == 1)
                                        {
                                            Console.WriteLine("Your first card is an Ten.");
                                            card++;
                                        }
                                        else
                                        {
                                            card++;
                                            Console.WriteLine("Your face up card is a Ten.");
                                        }
                                    }
                                    else if (randomNum == 10)
                                    {
                                        if (card == 1)
                                        {
                                            Console.WriteLine("Your first card is an Jack.");
                                            card++;
                                        }
                                        else
                                        {
                                            card++;
                                            Console.WriteLine("Your face up card is a Jack.");
                                        }
                                    }
                                    else if (randomNum == 11)
                                    {
                                        if (card == 1)
                                        {
                                            Console.WriteLine("Your first card is an Queen.");
                                            card++;
                                        }
                                        else
                                        {
                                            card++;
                                            Console.WriteLine("Your face up card is a Queen.");
                                        }
                                    }
                                    else
                                    {
                                        if (card == 1)
                                        {
                                            Console.WriteLine("Your first card is an King.");
                                            card++;
                                        }
                                        else
                                        {
                                            card++;
                                            Console.WriteLine("Your face up card is a King.");
                                        }
                                    }
                                }
                                break;
                        }
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
                                                if (totalNumDeal1 > totalNumDeal2 || totalNumDeal1 == totalNumDeal2)// if the minimum dealer number is more than or equal to the max
                                                {
                                                    if (totalNumPlay1 > totalNumDeal1)//if the player number1 is greater than the dealer number
                                                    {
                                                        win = "win!"; //player wins and gameover is set to 0
                                                        gameOver = 0;
                                                    }
                                                    else if (totalNumPlay1 < totalNumDeal1)//if the player number1 is less than the dealer number
                                                    {
                                                        win = "lose!";//player loses and gameover is set to 0
                                                        gameOver = 0;
                                                    }
                                                    else
                                                    {
                                                        win = "draw!";//player draws
                                                        gameOver = 0;
                                                    }
                                                }
                                                else
                                                {
                                                    if (totalNumPlay1 > totalNumDeal2)// if player number1 is greater than dealer max number
                                                    {
                                                        win = "win!";//player wins and gameover is set to 0
                                                        gameOver = 0;
                                                    }
                                                    else if (totalNumPlay1 < totalNumDeal2)//if the player number1 is less than the dealer number
                                                    {
                                                        win = "lose!";//player loses and gameover is set to 0
                                                        gameOver = 0;
                                                    }
                                                    else
                                                    {
                                                        win = "draw!";//player draws
                                                        gameOver = 0;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (totalNumDeal1 > totalNumDeal2 || totalNumDeal1 == totalNumDeal2)// if the minimum dealer number is more than or equal to the max
                                                {
                                                    if (totalNumPlay2 > totalNumDeal1)//if the player number2 is greater than the dealer number
                                                    {
                                                        win = "win!";//player wins and gameover is set to 0
                                                        gameOver = 0;
                                                    }
                                                    else if (totalNumPlay2 < totalNumDeal1)//if the player number2 is less than the dealer number
                                                    {
                                                        win = "lose!";//player loses and gameover is set to 0
                                                        gameOver = 0;
                                                    }
                                                    else
                                                    {
                                                        win = "draw!";//player draws
                                                        gameOver = 0;
                                                    }
                                                }
                                                else
                                                {
                                                    if (totalNumPlay2 > totalNumDeal2)//if the player number2 is greater than the max dealer number
                                                    {
                                                        win = "win!";//player wins and gameover is set to 0
                                                        gameOver = 0;
                                                    }
                                                    else if (totalNumPlay2 < totalNumDeal2)//if the player number2 is less than the max dealer number
                                                    {
                                                        win = "lose!";//player loses and gameover is set to 0
                                                        gameOver = 0;
                                                    }
                                                    else
                                                    {
                                                        win = "draw!";//player draws
                                                        gameOver = 0;
                                                    }
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
                                            if (totalNumDeal1 > totalNumDeal2 || totalNumDeal1 == totalNumDeal2)// if the minimum dealer number is more than or equal to the max
                                            {
                                                if (totalNumPlay1 > totalNumDeal1)//if the player number1 is greater than the dealer number
                                                {
                                                    win = "win!";//player wins and gameover is set to 0
                                                    gameOver = 0;
                                                }
                                                else if (totalNumPlay1 < totalNumDeal1)//if the player number1 is less than the dealer number
                                                {
                                                    win = "lose!";//player loses and gameover is set to 0
                                                    gameOver = 0;
                                                }
                                                else
                                                {
                                                    win = "draw!";//player draws
                                                    gameOver = 0;
                                                }
                                            }
                                            else
                                            {
                                                if (totalNumPlay1 > totalNumDeal2)//if the player number1 is greater than the max dealer number
                                                {
                                                    win = "win!";//player wins and gameover is set to 0
                                                    gameOver = 0;
                                                }
                                                else if (totalNumPlay1 < totalNumDeal2)//if the player number1 is less than the dealer number
                                                {
                                                    win = "lose!";//player loses and gameover is set to 0
                                                    gameOver = 0;
                                                }
                                                else
                                                {
                                                    win = "draw!";//player draws
                                                    gameOver = 0;
                                                }
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

