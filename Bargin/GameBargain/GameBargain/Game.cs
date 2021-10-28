using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using static System.Console;
using static GameBargain.CenterText;


namespace GameBargain
{
    public class Game
    {
        public bool FoundPaperclip;
        public bool FColorPaper;
        public bool FPen;
        public bool FCandy;
        public bool FClaw;
        public bool FDice;
        public bool FQuarter;

       
        Player player = new Player();
        Items quarter = new Items ("quarter");
        Items dice = new Items("dice");
        Items Paperclip = new Items("paper clip");
        Items Candy = new Items("candy");
        Items necklace = new Items("necklaces");
        Items pen = new Items("pen");
        Items colorpaper = new Items("color paper");
        void NamePlayer()
        {
            
            WriteLine("What's your name?");
            player.name = ReadLine();
            WriteLine($"Hello {player.name}");
        }

        //CenterText ct = new CenterText();

        public Game()
        {
            GameStartText();
        }
        //the text thats id first on the screen.
        public void GameStartText()
        {
            string start;
            CT("Welcome to the Bargain!");
            CT("Would you like to start?");
            CT("(Yes or No)");
            
            CT("\n\n\n\n\n");
            CT("Hint: Whenever you see '...' mean to press enter to continue. ");
            start = ReadLine();
            if (start.ToLower() == "yes" || start.ToLower() == "y")
            {
                Clear();
                Start();

            }
            else
            //dont say now
            {
                CT("You can't say no");
                ReadKey();
                GameStartText();

            }
        }
        //ask askes the  player what diraction they want to go.
        public void PressEnter()
        {
            CT("Whenever you see '...' mean to press enter to continue ");
        }
        public void Start()
        {
            //This first question is to detrmained where the play will go first
            string input;
            NamePlayer();
            WriteLine("To start off the game, what path do you want to take?\n*Type the number* \n1)Left \n2)Straight \n3)Right");
            input = ReadLine();
            Clear();
            if (input == "1")
            {

                player.inventory.Add(quarter);
                CT("You chose Left" + "\nWhen walking on this path you found a" + player.inventory[0].itemname + ". Your goal is to bargain your way up from a __ to the must expensive item in the game." +
                    "\n\n\nRules:\n1) You can't go back. When you pick on item it is final,so choose wisely.\n2) Whenever you see '...' mean to press enter to continue. \n3)when you see a list of item type in the number that correlates to the answer you want to choose.\n4)Have FUNNNN!!!\n...");
                ReadKey();
                Clear();
                FQuarter = true;
                Store();


            }
            else if (input.ToLower() == "2")
            {
                player.inventory.Add(Paperclip);
                CT("You chose Straight" + "\nWhen walking on this path you found a" + player.inventory[0].itemname + ". Your goal is to bargain your way up to the must expensive item in the game." +
                    "\n...");
                ReadKey();
                Clear();
                FoundPaperclip = true;
                PaperClip();
            }
            else if (input.ToLower() == "3")
            {
                player.inventory.Add(dice);
                WriteLine("You chose Right" + "\nWhen walking on this path you found a " + player.inventory[0].itemname + " . Your goal is to bargain your way up to the must expensive item in the game." +
                    "\n...");
                FDice = true;
                ReadKey();
                Clear();
                Dice();
            }
            else
            {
                //"That is not an option try again
                WriteLine("That is not an option try again. Press any key to choose again");
                ReadKey();
                Clear();
                Game game = new Game();
            }
            ReadKey();
        }
        //The ask the play what next location do they want to at.
        public void Dice()
        {
            string dice;
            WriteLine("After collecting the dice would you want to go to the \n1)Park \n2)Contuin Straight");
            dice = ReadLine();
            if (dice == ("1"))
            {
                Clear();
                Park();
            }
            else if (dice == ("2"))
            {
                Clear();
                PaperClip();
            }
            else
            {
                WriteLine("That is not an option try again. Press any key to choose again");
                ReadKey();
                Clear();
                Dice();
            }
        }
        public void PaperClip()
        {
            string paperclip;
            WriteLine("After collecting the Paper Clip would you want to go to the \n1)Countinue Right \n2)Go to School");
            paperclip = ReadLine();
            // right the pathways to go to school and dice
            if (paperclip == ("1"))
            {
                Clear();
                Dice();

            }
            else if (paperclip == ("2"))
            {
                Clear();
                School();

            }
            else
            {
                WriteLine("That is not an option try again. Press any key to choose again");
                ReadKey();
                Clear();
                PaperClip();
            }

        }
        public void Store()
        {
            if (FColorPaper == true)
            {
                WriteLine("You dont have the right items to go to");
                ReadKey();
                Clear();
                Park();
            }
            else if (FQuarter == true)
            {
                Clear();
                InOut();
            }
            else
            {
                WrongAnswer();
                Store();
            }
            void InOut()
            {
                string inout;
                WriteLine("Walking down this you found a store. Do you want to go \n1)In-side the store \n2)Out-side the store");
                inout = ReadLine();

                Clear();
                if (inout == "1")
                {
                    WriteLine("You choose to go in-side. Lets see who or what you can bargain or trade with.\n...");
                    ReadKey();
                    Clear();
                }
                else if (inout == "2")
                {

                    WriteLine("You choose to stay out-side. Lets see who or what you can bargain or trade with.\n...");
                    ReadKey();
                    Clear();
                    Pen();
                }
                else
                {
                    //WriteLine("That is not an option try again. Press any key to choose again");
                    WrongAnswer();
                    InOut();
                }

                void Pen()
                {

                    string pen;
                    WriteLine("When out-side you see a women, mechanical horse, and her child crying because they can't ride the horse. You go over there. \nYou can either..."
                        + "\n1)Give them your Quarter\n2)Bargain/Trade the quarter for something random they have.");

                    pen = ReadLine();
                    if (pen == ("1"))
                    {// becuase the players doesnt have an item to bagain with they have to start over.
                        WriteLine("AWW that was super nice. But becuase you dont hany more any items to trade with you cant continue.\nHowever you where kind so Ill let you play again.\n...");
                        Clear();
                        Start();
                    }
                    else if (pen == ("2"))
                    {

                        FPen = true;
                        string fancy;
                        Clear();
                        WriteLine("They gave you a Fancy Pen!\n ...");
                        ReadKey();
                        Clear();
                        WriteLine("Would You like to keep the fancy pen or continue" + "\n1)Keep Fancy Pen \n2)Continue");
                        ReadLine();

                        fancy = ReadLine();
                        if (fancy == ("1"))
                        {
                            Clear();
                            WriteLine("You choose to keep the FANNCCCYYY PENNN. Good Choice!" + "\n...");
                            ReadKey();
                            Clear();
                            End();
                        }
                        else if (fancy == ("2"))
                        {
                            Clear();
                            WriteLine("You choose to continue\nLets go to the park near the store to see if their other people to trade with.\n...");
                            ReadKey();
                            Park();
                        }
                        else
                        {
                            Clear();
                            Park();
                        }
                    }
                    else
                    {
                        WrongAnswer();
                        Pen();

                    }
                }
            }
        }
        public void Park()
        {
            string park;
            WriteLine("In the park you see one group of people and the other side one person that it painting."
         + "\nWould you like to\n1)Go to the group of people.\n2)Go to the painter.");
         
            park = ReadLine();
            Clear();
            if (park == ("1"))
            {
                WriteLine("You choose to go to the group of people\n...");
                ReadKey();
                Clear();
                BoredGame();

            }
            else if (park == ("2"))
            {
                WriteLine("You choose to go to the group of people\n...");
                ReadKey();
                Clear();
                Painter();
            }
            else
            {
                WrongAnswer();
                Park();
            }
            void BoredGame()
            {
                string boredgame;
               
                WriteLine($"When walking  towards them you see that their playing a bored game.\n Do you want ask to them to\n1)Trade the " + player.inventory[0].itemname+ " for the bored game.\n2)Playgame with them.");
               
                boredgame = ReadLine();
                Clear();
                if (boredgame == ("2"))
                {
                    WriteLine("One of the Guys in the group:Yeah Sure!\nLet see if you Win.\n...");
                    ReadKey();
                    if (FDice == true || FPen == true)
                    {
                        WriteLine("Few minuites go by\n...");
                        ReadKey();
                        WriteLine(" WOOOWWW you actually won!!!!\nAnother suprise!\nYou just found out that this wasn't just a ragular game, this was a Competition that had PRIZEE MONEYYY.\n...");
                        ReadKey();
                        WriteLine("YOU JUST WOONNNN\n....");
                        ReadKey();
                        WriteLine("$10,000\n...");
                        ReadKey();
                    }
                    else
                    {

                        WriteLine("Hello");
                    }

                }
                else if (boredgame == ("1"))
                {
                    WriteLine("One of the Guys in the group: 'Bro why would we give you our bored game for a " + player.inventory[0].itemname + "\n...");
                    ReadKey();
                    Clear();
                    WriteLine("Out of shame you stoped the game and went home.\n...");
                    ReadKey();
                    Clear();
                    End();
                }
                else
                {

                }
            }
            void Painter()
            {
                Painter();
            }
        }
        public void School()
        {


            string school;
            CT("When going to class you see a a women that needs help. You go up to her and ask are you ok. She states that she lost her paperclip right before she had to turn in a assgigment.\n1)Give Her the Paperclip with out trading \n2)Trade for a random item ");
            school = ReadLine();
            if (school == ("1"))
            {
                Clear();
                WriteLine("AWWW that was nice, you did lose you item but I'll give you a other try!!\n...");
                ReadKey();
                Clear();
                Start();

            }
            else if (school == ("2") && FoundPaperclip == true)
            {
                Clear();
                ColorPaper();
            }
            else
            {
                WriteLine("That is not an option try again. Press any key to choose again");
                ReadKey();
                Clear();
                School();
            }
            void ColorPaper()
            {
               
                if (player.inventory.Contains(Paperclip))
                {
                 player.inventory.Remove(Paperclip);
                    player.inventory.Add(colorpaper);
                }
                else
                {
                    WriteLine("OPPPSSS error");
                }
                FColorPaper = true;
                WriteLine("wow she gave you color paper as a trade off.\n...");
                ReadKey();
                WriteLine("Let's go to the park near your school to see if anybody wants to trade\n...");
                ReadKey();

            }
        }
        public void WrongAnswer()
        {
            WriteLine("That is not an option try again. Press any key to choose again");
            ReadKey();
            Clear();
        }
        public void End()
        {

        }
    }
}