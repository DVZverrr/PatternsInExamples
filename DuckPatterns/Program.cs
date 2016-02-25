using System;

namespace DuckPatterns
{
  public class DuckSimulator
  {
    public static void Main (string[] args)
    {
      var duckFactory = new CountingDuckFactory();
      var ds = new DuckSimulator();
      ds.simulate(duckFactory);
    }

    public void simulate(AbstractDuckFactory duckFactory)
    {
      var red = duckFactory.createRedheadDuck();
      var call = duckFactory.createDuckCall();
      var rubber = duckFactory.createRubberDuck();
      var gooseDuck = new GooseAdapter(new Goose());

      var flock = new Flock();
      flock.Add(red);
      flock.Add(call);
      flock.Add(rubber);
      flock.Add(gooseDuck);


      var mallardFlock = new Flock();
      var mallardOne = duckFactory.createMallardDuck();
      var mallardTwo = duckFactory.createMallardDuck();
      var mallardThree = duckFactory.createMallardDuck();
      var mallardFour = duckFactory.createMallardDuck();
      mallardFlock.Add(mallardOne);
      mallardFlock.Add(mallardTwo);
      mallardFlock.Add(mallardThree);
      mallardFlock.Add(mallardFour);

      flock.Add(mallardFlock);

      Console.WriteLine("Duck Simulator: Whole ducks");
      simulate(flock);
      Console.WriteLine("Duck Simulator: Mallard only ducks");
      simulate(mallardFlock);
      Console.WriteLine(string.Format("The ducks quaked {0} times.",QuakCounter.QuackCount));
    }

    public void simulate(IQuackable duck)
    {
      duck.quack();
    }
  }
}
