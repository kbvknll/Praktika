

public abstract class Transport
{
    public abstract string _type { get; set; }
    public abstract int _speed { get; set; }
    public abstract string _color { get; set; }
    public abstract string _model { get; set; }
    public abstract string _rightscategory { get; set; }
    public abstract bool _rent { get; set; }
    public abstract int _wheels { get; set; }
    public abstract string _motor { get; set; }
    public abstract void Move();
    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }
    public int Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }
    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }
    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }
    public string Rightscategory
    {
        get { return _rightscategory; }
        set { _rightscategory = value; }
    }
    public bool Rent
    {
        get { return _rent; }
        set { _rent = value; }
    }
    public int Wheels
    {
        get { return _wheels; }
        set { _wheels = value; }
    }
    public string Motor
    {
        get { return _motor; }
        set { _motor = value; }
    }
    public Transport(string type, int speed, string color, string model, string rightscategory, bool rent, int wheels, string motor)
    {
        Type = type;
        Speed = speed;
        Color = color;
        Model = model;
        Rightscategory = rightscategory;
        Rent = rent;
        Wheels = wheels;
        Motor = motor;
    }
}

public partial class Program
{
    private List<Transport> transports = new List<Transport>();

    public Program()
    {
        transports = new List<Transport>();
    }

    public void AddAnimal(Transport transport)
    {
        transports.Add(transport);
    }

    public void RemoveAnimal(Transport transport)
    {
        transports.Remove(transport);
    }

    public void PrintAnimalNames()
    {
        foreach (Transport animal in transports)
        {
            Console.WriteLine(animal.Type);
        }
        Console.WriteLine(transports.Count());
    }

    public void Print(List<Transport> _list)
    {
        for (int i = 0; i < _list.Count; i++)
        {
            Console.WriteLine(_list[i].Type);
        }
    }
}
