using System;

namespace Application
{
  class Program
  {
    static void Main(string[] args)
    {
        Oppgave1(args);
        Oppgave2(args);
    }
    static void Oppgave1(string[] args)
    {
        foreach (string item in args)
        {
          Console.WriteLine("arg: " + item);
        }
    }
    static void Oppgave2(string[] args)
    {
        Console.WriteLine($"The amount of arguments is {args.Length}");
    }
  }
}