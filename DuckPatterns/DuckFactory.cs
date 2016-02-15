using System;

namespace DuckPatterns
{
  public abstract class AbstractDuckFactory
  {
    public abstract IQuackable createMallardDuck();
    public abstract IQuackable createRedheadDuck();
    public abstract IQuackable createDuckCall();
    public abstract IQuackable createRubberDuck();
  }

  public class CountingDuckFactory : AbstractDuckFactory
  {
    public CountingDuckFactory()
    {
      
    }

    #region implemented abstract members of AbstractDuckFactory

    public override IQuackable createMallardDuck()
    {
      return new QuakCounter(new MallardDuck());
    }

    public override IQuackable createRedheadDuck()
    {
      return new QuakCounter(new RedheadDuck());
    }

    public override IQuackable createDuckCall()
    {
      return new QuakCounter(new DuckCall());
    }

    public override IQuackable createRubberDuck()
    {
      return new QuakCounter(new RubberDuck());
    }

    #endregion
  }
}

