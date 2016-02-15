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
      var mallard = duckFactory.createMallardDuck();
      var red = duckFactory.createRedheadDuck();
      var call = duckFactory.createDuckCall();
      var rubber = duckFactory.createRubberDuck();
      var gooseDuck = new GooseAdapter(new Goose());
      Console.WriteLine("Duck Simulator");

      simulate(mallard);
      simulate(red);
      simulate(call);
      simulate(rubber);
      simulate(gooseDuck);
      Console.WriteLine(string.Format("The ducks quaked {0} times.",QuakCounter.QuackCount));
    }

    public void simulate(IQuackable duck)
    {
      duck.quack();
    }
  }
}
