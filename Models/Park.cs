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
    public void fightDinos(string dino1, string dino2)
    {
      Random rnd = new Random();
      int d1Att = rnd.Next(1, dinoPark[dino1].getAtt());
      int d1Def = rnd.Next(1, dinoPark[dino1].getDef());
      int d2Att = rnd.Next(1, dinoPark[dino2].getAtt());
      int d2Def = rnd.Next(1, dinoPark[dino2].getDef());
      if(d2Def < d1Att)
      {
        int dmg = d1Att - d2Def;
        dinoPark[dino2].setHealth(dinoPark[dino2].getHealth() - dmg);
      }
      if(d1Def < d2Att)
      {
        int dmg = d2Att - d1Def;
        dinoPark[dino1].setHealth(dinoPark[dino1].getHealth() - dmg);
      }
    }
    public Dictionary<string,Dino> getDinoDictionary()
    {
      return dinoPark;
    }
  }
}