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

            while(menuChoice != 0)
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
                while(gameOver != 0)
                {
                    int totalNumDeal = 0;
                    int totalNumPlay = 0;
                    int hit = 1;
                    while(totalNumDeal < 21 || totalNumPlay < 21 || hit != 0)
                    {
                        switch(randNum.Next(12))
                        {
                            case 0:

                            break;
                            case 1:

                            break;
                            case 2:

                            break;
                            case 3:
                        }
                    }
                }
            }


        }
    }
}
