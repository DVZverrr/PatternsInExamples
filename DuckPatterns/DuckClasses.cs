using System;

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
}

