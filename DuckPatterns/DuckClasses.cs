using System;
using System.Collections.Generic;

namespace DuckPatterns
{
  public class MallardDuck : IQuackable
  {
    public void quack()
    {
      Console.WriteLine("Quack");
    }
  }

  public class RedheadDuck : IQuackable
  {
    public void quack()
    {
      Console.WriteLine("Quack");
    }
  }

  public class DuckCall : IQuackable
  {
    public void quack()
    {
      Console.WriteLine("Kwack");
    }
  }

  public class RubberDuck : IQuackable
  {
    public void quack()
    {
      Console.WriteLine("Squeak");
    }
  }

  public class Goose 
  {
    public void honk()
    {
      Console.WriteLine("Honk");
    }
  }

  /// <summary>
  /// Goose adapter.
  /// </summary>
  public class GooseAdapter : IQuackable
  {
    private Goose _goose;

    public GooseAdapter (Goose goose)
    {
      _goose = goose;
    }

    public void quack()
    {
      _goose.honk ();
    }
  }

}

