﻿// See https://aka.ms/new-console-template for more information


    Console.WriteLine("Welcome to Song Tracker!");
    Console.WriteLine("What would you like to do today?");
    Console.WriteLine("Enter 1. To add a new song");
    Console.WriteLine("Enter 2. To Review Current Song");
    Console.WriteLine("enter 3. To Exit the Program and get some practice!");

    string menu = Console.ReadLine();

    bool go = true;
    string NewSong;
//Master Loop Menu
    while (go)
    {
        switch (menu)
        {
            case "1":

                Console.WriteLine("Please enter the song name, press 1 to return to main menu");
                NewSong = Console.ReadLine();
            if (NewSong == "1")
            {
                return;
            }
            Console.WriteLine($"{NewSong}, Has been entered, thank you!");
        
            goto case "3";

            break;
                

            case "3":
            
            default:
                go = false;
                break;
        };



    };
