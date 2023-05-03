
// Abstraction....
public class Ship : Object
{
    public ShipDimensions Dimensions = new ShipDimensions();
    ShipRegister _register = new ShipRegister();// new ShipRegister();
    RouteInformation _route = new RouteInformation();

    public Ship(string shipName)
    {
        _register.Name = shipName;
    }

    public override string ToString() => ToStringEx();
    public string ToStringEx() => "Name: " + _register.Name;
}

public class RouteInformation
{
    public List<string> Ports;   
}

public class ShipRegister
{
    public string Country, Name, Owner, Flag; // ....
}

public class ShipDimensions
{
    public float LBP; // length between perpendiculars
    public float Beam, Draft;
    public float Depth { get; set; }
}