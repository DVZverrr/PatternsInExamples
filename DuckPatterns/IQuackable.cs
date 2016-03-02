using System;

namespace DuckPatterns
{
  public delegate void QuackNotify(string duckName);

  public interface IQuackableObservable
  {
    event QuackNotify QuackHappend;
  }

  public interface IQuackable : IQuackableObservable
  {
    string Name { get;}
    void quack();
  }
}

