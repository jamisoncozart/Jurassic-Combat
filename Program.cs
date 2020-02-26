using System;
using System.Collections.Generic;
using System.Threading;
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
    else if (menuChoice.ToLower() == "fight")
    {
      fightDinos();
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
      foreach(Dino name in newPark)
      {
        
      }
      Console.WriteLine(newPark.displayDino(dinoName));
      viewDinos();
    }
  }
  public static void fightDinos()
  {
    Console.Write("Enter name of first dino: ");
    string dino1 = Console.ReadLine();
    Console.Write("Enter name of second dino: ");
    string dino2 = Console.ReadLine();
    while(newPark.getDinoDictionary()[dino1].getHealth() > 0 && newPark.getDinoDictionary()[dino2].getHealth() > 0)
    {
      newPark.fightDinos(dino1, dino2);
      Console.Write($"{dino1}: {newPark.getDinoDictionary()[dino1].getHealth()}, {dino2}: {newPark.getDinoDictionary()[dino2].getHealth()}\n");
      Thread.Sleep(500);
    }
    GameMenu();
  }
}