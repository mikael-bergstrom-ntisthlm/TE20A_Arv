using System;

public class Item
{
  public string Name { get; set; }
  public int Rarity { get; set; }

  public static void Hey()
  {
    Console.WriteLine("hej");
  }

  protected static Random generator = new Random();
}
