
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
    string ToStringEx() => Dimensions.ToString() + _register.ToString() + _route.ToString();
}

public class RouteInformation
{
    public List<string> Ports = new List<string>();   
    public override string ToString() => "Number of ports: " + Ports.Count;
}

public class ShipRegister
{
    public string Country, Name, Owner, Flag; // ....
    private string _secretOwner;
    public override string ToString() => "Name: " + Name + " Owner: " + _secretOwner;
}

public class ShipDimensions
{
    public float LBP; // length between perpendiculars
    public float Beam, Draft;
    public float Depth { get; set; }
    public override string ToString() => "Length between perpendiculars: " + LBP;
}