using System;
using System.Collections.Generic;
using System.Text;
using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem.Manager {
  /// <summary>
  /// Manages reservations.
  /// </summary>
  public class ReservationManager {
    private List < Suite > suites;
    private List < Reservation > reservations;

    /// <summary>
    /// Initializes a new instance of the <see cref="ReservationManager"/> class.
    /// </summary>
    /// <param name="suites">The list of suites.</param>
    /// <param name="reservations">The list of reservations.</param>
    public ReservationManager(List < Suite > suites, List < Reservation > reservations) {
      this.suites = suites;
      this.reservations = reservations;
    }

    /// <summary>
    /// Registers a new reservation.
    /// </summary>
    public void RegisterReservation() {
      if (suites.Count == 0) {
        Console.WriteLine("\nThere are no registered suites. Register a suite before making a reservation.");
        return;
      }

      Console.WriteLine("Choose a suite for the reservation:");
      for (int i = 0; i < suites.Count; i++) {
        Console.WriteLine($"{i + 1}. {suites[i].SuiteType} - Capacity: {suites[i].Capacity} - Daily Rate: {suites[i].DailyRate}");
      }
      int suiteIndex = Convert.ToInt32(Console.ReadLine()) - 1;

      Suite selectedSuite = suites[suiteIndex];

      Console.Write("How many days do you want to reserve: ");
      int reservedDays = Convert.ToInt32(Console.ReadLine());

      Reservation newReservation = new Reservation(reservedDays);
      newReservation.RegisterSuite(selectedSuite);

      List < Person > reservationGuests = new List < Person > ();
      Console.Write("Number of guests: ");
      int guestCount = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i < guestCount; i++) {
        Console.Write($"Guest {i + 1} Name: ");
        string firstName = Console.ReadLine();

        Console.Write($"Guest {i + 1} Last Name: ");
        string lastName = Console.ReadLine();

        reservationGuests.Add(new Person(firstName, lastName));
      }
      try {
        newReservation.RegisterGuests(reservationGuests);
      } catch (Exception ex) {
        Console.WriteLine($"Error registering guests: {ex.Message}");
        return;
      }

      reservations.Add(newReservation);

      Console.WriteLine("\nReservation successfully registered!");
    }

    /// <summary>
    /// Removes a reservation.
    /// </summary>
    public void RemoveReservation() {
      if (reservations.Count == 0) {
        Console.WriteLine("\nThere are no registered reservations.");
        return;
      }

      Console.WriteLine("Registered reservations:");
      for (int i = 0; i < reservations.Count; i++) {
        Console.WriteLine($"{i + 1}. Suite: {reservations[i].Suite.SuiteType}, {reservations[i].GetNumberOfGuests()} guests, Total amount: {reservations[i].CalculateTotalAmount()}");
      }
      Console.Write("Enter the reservation number you want to remove: ");
      int reservationIndex = Convert.ToInt32(Console.ReadLine()) - 1;

      if (reservationIndex >= 0 && reservationIndex < reservations.Count) {
        reservations.RemoveAt(reservationIndex);
        Console.WriteLine("\nReservation removed successfully!");
      } else {
        Console.WriteLine("\nInvalid reservation index.");
      }
    }

    /// <summary>
    /// Lists reservations and guests.
    /// </summary>
    public void ListReservationsAndGuests() {
      if (reservations.Count == 0) {
        Console.WriteLine("\nThere are no registered reservations.");
        return;
      }

      Console.WriteLine("\nRegistered reservations:");
      foreach(var reservation in reservations) {
        Console.WriteLine($"Suite: {reservation.Suite.SuiteType} | Capacity: {reservation.Suite.Capacity} | Daily Rate: {reservation.Suite.DailyRate} | Reserved days: {reservation.ReservedDays}");
        Console.WriteLine("Guests:");
        foreach(var guest in reservation.Guests) {
          Console.WriteLine($"- {guest.FullName}");
        }
        Console.WriteLine($"Total amount: {reservation.CalculateTotalAmount()}\n");
      }
    }
  }
}
