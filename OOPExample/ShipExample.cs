class ShipExample {

    // virtual: tämän metodin SAA yliajaa
    // virtual: tämä on se oletus implementaatio..

    // Object luokalla on: GetType(), ToString(), 
    // MemberwiseClone(), GetHashCode(), Equals(), ReferenceEquals()

    public static void TestShipClass() {
        var boatyMcBoatface = new Ship("Boaty McBoatface");

        Console.WriteLine("Ship details: " + boatyMcBoatface);
    }
}