using System;

namespace DuckPatterns
{
  public class QuackObservable : IQuackableObservable
  {
    public event QuackNotify QuackHappend;

    protected void OnQuackHappend(string duckName)
    {
      var handler = QuackHappend;
      if(handler != null)
        handler(duckName);
    }

    public QuackObservable()
    {
    }
  }
}

