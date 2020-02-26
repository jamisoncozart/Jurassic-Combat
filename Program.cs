using System;
using System.Collections.Generic;
using Models;

class Program
{
  public static Park newPark = new Park();
  
  public static void Main()
  {
    Console.WriteLine("Welcome to Jurassic Combat!");
    Console.WriteLine("---------------------------");
    GameMenu();
  }

  public static void GameMenu()
  {
    Console.WriteLine("\nWould you like to: ");
    Console.WriteLine("[Add] [View] [Fight] [Exit]");
    string menuChoice = Console.ReadLine();
    if (menuChoice.ToLower() == "exit")
    {
      Console.WriteLine("Thank you for playing!");
    }
    else if (menuChoice.ToLower() == "add")
    {
      CreateDino();
    }
    else if (menuChoice.ToLower() == "view")
    {
      viewDinos();
    }
  }

  public static void CreateDino()
  {
    Console.Write("\nPlease enter a dino name: ");
    string inputName = Console.ReadLine();
    Console.Write("Please enter a dino species: ");
    string inputSpecies = Console.ReadLine();
    newPark.addDino(inputName, inputSpecies);
    Console.WriteLine(newPark.displayDino(inputName));
    GameMenu();
  }

  public static void viewDinos()
  {
    Console.WriteLine("\n" + newPark.listDinos());
    Console.WriteLine("Would you like to view a specific Dino? (y/n)");
    string userAnswer = Console.ReadLine();
    if(userAnswer.ToLower() == "n")
    {
      GameMenu();
    }
    else if(userAnswer.ToLower() == "y")
    {
      Console.Write("Please enter the name of your Dino: ");
      string dinoName = Console.ReadLine();
      Console.WriteLine(newPark.displayDino(dinoName));
      viewDinos();
    }
  }
}