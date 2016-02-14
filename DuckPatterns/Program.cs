using System;

namespace DuckPatterns
{
  public class DuckSimulator
  {
    public static void Main (string[] args)
    {
      var ds = new DuckSimulator();
      ds.simulate();
    }

    public void simulate()
    {
      var mallard = new QuakCounter(new MallardDuck());
      var red = new QuakCounter(new RedheadDuck());
      var call = new QuakCounter(new DuckCall());
      var rubber = new QuakCounter(new RubberDuck());
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
