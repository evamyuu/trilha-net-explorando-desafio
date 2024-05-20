using System;
using System.Collections.Generic;
using System.Text;
using DesafioProjetoHospedagem.Models;
using DesafioProjetoHospedagem.Manager;

Console.OutputEncoding = Encoding.UTF8;

/// <summary>
/// This program is a lodging management system for managing hotel suites and reservations.
/// Users can register new suites, make reservations, remove reservations, and list existing reservations and guests.
/// </summary>

// List to store suites and reservations
List < Suite > suites = new List < Suite > ();
List < Reservation > reservations = new List < Reservation > ();

// Managers to handle suite and reservation operations
SuiteManager suiteManager = new SuiteManager(suites);
ReservationManager reservationManager = new ReservationManager(suites, reservations);

// Loop through the menu
bool close = false;
do {
  Console.WriteLine("\nWelcome to the lodging management system!\n");
  Console.WriteLine("Please choose one of the options below:\n");
  Console.WriteLine("1. Register a new suite");
  Console.WriteLine("2. Make a reservation");
  Console.WriteLine("3. Cancel a reservation");
  Console.WriteLine("4. View all reservations and guests");
  Console.WriteLine("5. Exit the program\n");
  Console.Write("Enter the number corresponding to the desired option: ");

  int option = Convert.ToInt32(Console.ReadLine());

  switch (option) {
  case 1:
    suiteManager.RegisterSuite();
    break;
  case 2:
    reservationManager.RegisterReservation();
    break;
  case 3:
    reservationManager.RemoveReservation();
    break;
  case 4:
    reservationManager.ListReservationsAndGuests();
    break;
  case 5:
    close = true;
    Console.WriteLine("\nThe program has ended.\n");
    break;
  default:
    Console.WriteLine("\nInvalid option, try again.");
    break;
  }

} while (!close);



     

     


