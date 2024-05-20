using System;
using System.Collections.Generic;
using System.Text;
using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem.Manager {
  /// <summary>
  /// Manages suites.
  /// </summary>
  public class SuiteManager {
    private List < Suite > suites;

    /// <summary>
    /// Initializes a new instance of the <see cref="SuiteManager"/> class.
    /// </summary>
    /// <param name="suites">The list of suites.</param>
    public SuiteManager(List < Suite > suites) {
      this.suites = suites;
    }

    /// <summary>
    /// Registers a new suite.
    /// </summary>
    public void RegisterSuite() {
      Console.Write("Suite type: ");
      string suiteType = Console.ReadLine();
      Console.Write("Capacity: ");
      int capacity = Convert.ToInt32(Console.ReadLine());
      Console.Write("Daily rate: ");
      decimal dailyRate = Convert.ToDecimal(Console.ReadLine());

      Suite newSuite = new Suite(suiteType, capacity, dailyRate);
      suites.Add(newSuite);

      Console.WriteLine("\nSuite successfully registered!\n");
    }
  }
}
