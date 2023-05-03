internal class Program
{
    string ProgramName = "OOPExample";
    
    // Special because of Main
    private static void Main(string[] args)
    {
    //  class  object
    //  type   object
    //  type   variable    the object 
        Person paavo     = new Person();
        paavo.FirstName = "Paavo";
        paavo.LastName = "Penttiö";
        paavo.Birthday = new DateTime(1960, 12, 9);

        // rogue... villi tapa...
        Person roman     = new Person();
        roman.FirstName = "Roman";
        roman.LastName = "Klemiato";
        roman.Birthday = new DateTime(1980, 12, 9);

        // Kun VAADITAAN nimi, sukunimi ja syntymäpäivä konstruktorissa..
        // EI OLE MAHDOLLISTA ETTÄ NE JÄISI TYHJÄKSI....
        Person marcus     = new Person(firstName: "Marcus", lastName: "Hasselgren", birthday: new DateTime(1998, 12, 31));

        // useamman rivin version
        Animal  dog      = new Animal();
        dog.Species = "Dog";
        dog.Era = DateTime.Now;

        // one-liner version
        Animal  cat      = new Animal()
        { 
            Species = "Cat",
            Era = DateTime.Now
        };


        System.Console.WriteLine(paavo);
        System.Console.WriteLine(roman);
        System.Console.WriteLine(dog);
        System.Console.WriteLine(cat);




    }
}