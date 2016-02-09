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
      var mallard = new MallardDuck();
      var red = new RedheadDuck();
      var call = new DuckCall();
      var rubber = new RubberDuck();
      Console.WriteLine("Duck Simulator");

      simulate(mallard);
      simulate(red);
      simulate(call);
      simulate(rubber);
    }

    public void simulate(IQuackable duck)
    {
      duck.quack();
    }
  }
}
