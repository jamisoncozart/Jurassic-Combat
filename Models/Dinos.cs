using System;

namespace Models
{
  public class Dino
  {
    private string _species;
    private int _health = 100;
    private int _def;
    private int _att;

    public Dino(string species)
    {
      _species = species;
    }
    public void setAttDef()
    {
      Random rnd = new Random();
      _att = rnd.Next(10,30);
      _def = 30 - _att;
    }

    public string getSpecies()
    {
      return _species;
    }
    public int getHealth()
    {
      return _health;
    }
    public void setHealth(int newHealth)
    {
      _health = newHealth;
    }
    public int getDef()
    {
      return _def;
    }
    public int getAtt()
    {
      return _att;
    }
  }
}