using System;

namespace DuckPatterns
{
  /// <summary>
  /// Decorator.
  /// </summary>
  public class QuakCounter : QuackObservable, IQuackable
  {
    private IQuackable _duck;

    public static int QuackCount {get;private set;}

    public QuakCounter(IQuackable duck)
    {
      _duck = duck;
      QuackCount = 0;
    }
    public string Name { get{ return ""; } }
    public void quack() 
    {
      _duck.quack();
      OnQuackHappend(string.Format("of decorator of {0}", _duck.Name));
      QuackCount++;
    }
      

  }
}

