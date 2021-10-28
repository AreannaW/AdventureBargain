/*
 * Tutoring help gotten from Grace Anders
 * Grace showed me how to center text
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using static System.Console;

namespace GameBargain
{
    class Program
    {
        static void Main(string[] args) {
                
                string logo = @"

                                                                         _____________________________
                            ______                       _               |             _             |
                            | ___ \                     (_)              |  $         | |          $ |
                            | |_/ / __ _ _ __ __ _  __ _ _ _ __          |           / __)           |
                            | ___ \/ _` | '__/ _` |/ _` | | '_ \         |           \__ \           |
                            | |_/ / (_| | | | (_| | (_| | | | | |        |           (   /           |
                            \____/ \__,_|_|  \__, |\__,_|_|_| |_|        |  $         |_|          $ |
                                              __/ |                      |___________________________|                
                                             |___/                             
                        ";

            //Great user

            WriteLine(logo);
            Game game = new Game();
            

        }
    }
}
