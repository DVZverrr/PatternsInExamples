﻿using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace DuckPatterns
{
  /// <summary>
  /// Flock. Compositor
  /// </summary>
  public class Flock : IQuackable
  {
    private IList<IQuackable> _quackers;

    public Flock()
    {
      _quackers = new List<IQuackable>();
    }

    public void Add(IQuackable quacker)
    {
      _quackers.Add(quacker);
    }

    public void quack()
    {
      foreach(var quacker in _quackers)
      {
        quacker.quack();
      }
    }
  }
}

