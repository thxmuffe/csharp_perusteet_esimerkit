
// Yksi luokka per tiedosto
// Tiedoston nimi sama kuin luokan nimi
// Iso alkukirjain (aina)
class Person
{
    public string _middleName;
    public string FirstName;
    public string LastName;

    public DateTime Birthday;

    public Person(string firstName, string lastName, DateTime birthday)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Birthday = birthday;
    }

    public Person() {}

    public double Age => (DateTime.Now - Birthday).TotalDays / 365.25;
    // string FullName;

    // classic method body....
    public override string ToString()
    {
        // $ = string interpolation
        return $"FirstName: {FirstName} LastName: {LastName} Age {Age:N1}";
    }

    // new style expression body (=> tarkoittaa lambda  .. anonyymi funktio)
    public string ToString2() => $"FirstName: {FirstName} LastName: {LastName} Age {Age}";

}