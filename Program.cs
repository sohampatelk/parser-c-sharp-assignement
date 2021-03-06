﻿/* C# Assignment
You are to write a C#  parser program which will have numbered options and a recurring menu 
(this means the menu will continuously run until we give the command, it saves us time from 
having to relaunch the program every time a task is done). 

Option 1 will allow the user to enter a filename, this will indicate which file we wish to parse. 
Option 2 will parse the data in the file specified by option 1, if no valid file is indicated, 
then the program should return an error message and then return the user to the menu. 
Option 3 will end the program.

Option 1 will prompt the user to enter a filename.The filename will be stored in a local variable.
Option 2 will prompt the user to enter a string. It will then go through the file 
specified by option 1 and replace any sequences of the user entered string with a blank space.
A while-loop menu: the menu will continue to display until, 
option 3 is entered as input, at that point the program will terminate.
*/
using System;
using System.Linq;
using System.IO;
namespace parser_c__assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the file name for, press key number 1");
            System.Console.WriteLine("Enter the string which you want to remove, press key number 2");
            System.Console.WriteLine("Exit from the loop , press key number 3");

            bool endLoop = false;
            string fileName = "";
            string fileString = "";


            while (!endLoop)
            {
                Console.WriteLine("Enter an option:");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Prompt: Enter a file name:");
                        fileName = Console.ReadLine();
                        if (!File.Exists(fileName))
                        {
                            System.Console.WriteLine("Same File name does not exist..");
                        }
                        break;
                    case "2":

                        Console.WriteLine("Prompt: Enter a string which you want to remove:");
                        fileString = Console.ReadLine();
                        if (File.Exists(fileName))
                        {
                            string readText = File.ReadAllText(fileName);
                            string[] split = readText.Split(fileString);
                            string updatedString = "";
                            System.Console.WriteLine("in case 2 in if loop");
                            foreach (string e in split)
                            {
                                updatedString = updatedString + e + " ";  //update string with blank space
                            }
                            File.WriteAllText(fileName, updatedString);
                            //System.Console.WriteLine("text removed..");
                        }
                        //System.Console.WriteLine("in case 2 and file edited..loop finished.");
                        break;

                    case "3":
                        endLoop = true;
                        Console.WriteLine("Exiting the loop");
                        break;
                    default:
                        Console.WriteLine("Enter invalid entry");
                        System.Console.WriteLine("Enter the Option: ");
                        System.Console.WriteLine("Enter the file name for, press key number 1");
                        System.Console.WriteLine("Enter the string which you want to add, press key number 2");
                        System.Console.WriteLine("Exit from the loop , press key number 3");
                        break;

                }

            }

        }
    }
}
