using System;
using System.Collections.Generic;

namespace Models
{
  public class Park
  {
    public static Dictionary<string, Dino> dinoPark = new Dictionary<string, Dino>();

    public void addDino(string name, string species)
    {
      dinoPark[name] = new Dino(species);
      dinoPark[name].setAttDef();
    }

    public string displayDino(string name)
    {
      string spec = dinoPark[name].getSpecies();
      int life = dinoPark[name].getHealth();
      int attack = dinoPark[name].getAtt();
      int defense = dinoPark[name].getDef();
      string dinoStats = $"Name: {name}, Species: {spec}, Health: {life}, Attack: {attack}, Defense: {defense}";
      return dinoStats;
    }
    public string listDinos()
    {
      string dinoNames = "";
      foreach (KeyValuePair<string, Dino> entry in dinoPark)
      {
        dinoNames += entry.Key + "\n";
      }
      return dinoNames;
    }
  }
}