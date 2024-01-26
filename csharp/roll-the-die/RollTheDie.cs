using System;

public class Player
{
   private static readonly Random _r = new Random();
    
   public int RollDie() => _r.Next(1, 18)+1;

    public double GenerateSpellStrength() => _r.NextDouble()*100.0;
}
