namespace DesafioProjetoHospedagem.Models {
  /// <summary>
  /// Represents a person.
  /// </summary>
  public class Person {
    /// <summary>
    /// Initializes a new instance of the <see cref="Person"/> class.
    /// </summary>
    public Person() {}

    /// <summary>
    /// Initializes a new instance of the <see cref="Person"/> class with the specified name and last name.
    /// </summary>
    /// <param name="name">The person's name.</param>
    /// <param name="lastName">The person's last name.</param>
    public Person(string name, string lastName) {
      Name = name;
      LastName = lastName;
    }

    /// <summary>
    /// Gets or sets the person's name.
    /// </summary>
    public string Name {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets the person's last name.
    /// </summary>
    public string LastName {
      get;
      set;
    }

    /// <summary>
    /// Gets the full name of the person.
    /// </summary>
    public string FullName => $"{Name} {LastName}".ToUpper();
  }
}
