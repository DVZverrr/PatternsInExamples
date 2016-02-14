using System;

namespace DuckPatterns
{
  /// <summary>
  /// Decorator.
  /// </summary>
  public class QuakCounter : IQuackable
  {
    private IQuackable _duck;

    public static int QuackCount {get;private set;}

    public QuakCounter(IQuackable duck)
    {
      _duck = duck;
      QuackCount = 0;
    }

    public void quack()
    {
      _duck.quack();
      QuackCount++;
    }

  }
}

