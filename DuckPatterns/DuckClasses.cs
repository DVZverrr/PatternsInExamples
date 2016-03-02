using System;
using System.Collections.Generic;

namespace DuckPatterns
{
  public class MallardDuck : QuackObservable, IQuackable
  {
    public string Name { get{return "MallardDuck";} }
    public void quack()
    { 
      Console.WriteLine("Quack");
      OnQuackHappend(Name);
    }
  }

  public class RedheadDuck : QuackObservable, IQuackable
  {
    public string Name { get{return "RedheadDuck";} }
    public void quack()
    {
      Console.WriteLine("Quack");
      OnQuackHappend(Name);
    }
  }

  public class DuckCall : QuackObservable, IQuackable
  {
    public string Name { get{return "DuckCall";} }
    public void quack()
    {
      Console.WriteLine("Kwack");
      OnQuackHappend(Name);
    }
  }

  public class RubberDuck : QuackObservable, IQuackable
  {
    public string Name { get{return "RubberDuck";} }
    public void quack()
    {
      Console.WriteLine("Squeak");
      OnQuackHappend(Name);
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
  public class GooseAdapter : QuackObservable, IQuackable
  {
    private Goose _goose;

    public GooseAdapter (Goose goose)
    {
      _goose = goose;
    }
    public string Name { get{return "GooseAdapter";} }
    public void quack()
    {
      _goose.honk();
      OnQuackHappend(Name);
    }
  }

}

