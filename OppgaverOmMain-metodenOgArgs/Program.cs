using System;

namespace Application
{
  class Program
  {
    static void Main(string[] args)
    {
        Oppgave1(args);
    }
    static void Oppgave1(string[] args)
    {
        foreach (string item in args)
        {
          Console.WriteLine("arg: " + item);
        }
    }
  }
}