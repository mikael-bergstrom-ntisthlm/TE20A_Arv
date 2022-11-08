using System;

public class Crystal : Item
{
  public Crystal()
  {
    Name = "Crystal";
    Rarity = generator.Next(10, 20);
  }
}
