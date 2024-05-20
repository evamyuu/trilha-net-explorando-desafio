namespace DesafioProjetoHospedagem.Models {
  /// <summary>
  /// Represents a suite in a hotel.
  /// </summary>
  public class Suite {
    /// <summary>
    /// Initializes a new instance of the <see cref="Suite"/> class.
    /// </summary>
    public Suite() {}

    /// <summary>
    /// Initializes a new instance of the <see cref="Suite"/> class with the specified type, capacity, and daily rate.
    /// </summary>
    /// <param name="suiteType">The type of suite.</param>
    /// <param name="capacity">The capacity of the suite.</param>
    /// <param name="dailyRate">The daily rate of the suite.</param>
    public Suite(string suiteType, int capacity, decimal dailyRate) {
      SuiteType = suiteType;
      Capacity = capacity;
      DailyRate = dailyRate;
    }

    /// <summary>
    /// Gets or sets the type of suite.
    /// </summary>
    public string SuiteType {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets the capacity of the suite.
    /// </summary>
    public int Capacity {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets the daily rate of the suite.
    /// </summary>
    public decimal DailyRate {
      get;
      set;
    }
  }
}
