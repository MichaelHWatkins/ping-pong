using System;
using ChristopherWalkin;

class Program
{
  public static void Main()
  {
    Player tron = new Player();

    Console.WriteLine("Please enter a number");
    string yourNumber = Console.ReadLine();
    Console.WriteLine("==============");
    int newNumber = int.Parse(yourNumber);

    tron.pingPong(newNumber);
  }
}