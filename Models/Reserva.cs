namespace DesafioProjetoHospedagem.Models {
  /// <summary>
  /// Represents a reservation.
  /// </summary>
  public class Reservation {
    /// <summary>
    /// Gets or sets the guests associated with the reservation.
    /// </summary>
    public List < Person > Guests {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets the suite associated with the reservation.
    /// </summary>
    public Suite Suite {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets the number of days reserved.
    /// </summary>
    public int ReservedDays {
      get;
      set;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Reservation"/> class.
    /// </summary>
    public Reservation() {}

    /// <summary>
    /// Initializes a new instance of the <see cref="Reservation"/> class with the specified number of reserved days.
    /// </summary>
    /// <param name="reservedDays">The number of days reserved.</param>
    public Reservation(int reservedDays) {
      ReservedDays = reservedDays;
    }

    /// <summary>
    /// Registers guests for the reservation.
    /// </summary>
    /// <param name="guests">The guests to register.</param>
    public void RegisterGuests(List < Person > guests) {
      if (Suite.Capacity >= guests.Count) {
        Guests = guests;
      } else {
        throw new Exception("\nThe suite's capacity is less than the number of guests received.");
      }
    }

    /// <summary>
    /// Registers a suite for the reservation.
    /// </summary>
    /// <param name="suite">The suite to register.</param>
    public void RegisterSuite(Suite suite) {
      Suite = suite;
    }

    /// <summary>
    /// Gets the number of guests associated with the reservation.
    /// </summary>
    /// <returns>The number of guests.</returns>
    public int GetNumberOfGuests() {
      return Guests.Count;
    }

    /// <summary>
    /// Calculates the total amount for the reservation.
    /// </summary>
    /// <returns>The total amount.</returns>
    public decimal CalculateTotalAmount() {
      decimal amount = ReservedDays * Suite.DailyRate;

      if (ReservedDays >= 10) {
        amount *= 0.9M; // Apply 10% discount for reservations of 10 or more days
      }

      return amount;
    }
  }
}
