namespace ToolBox;

public class Hammer : Tool
{
    //====================================
    //           Constructor
    //====================================
    public Hammer() : base("Hammer", "1.5kg")
    {
    }
    
    //====================================
    //           Methods
    //====================================
    public override void Describe()
    {
        Console.WriteLine($"{_name} has {_weight} kg.");
    }

    public override void Use()
    {
        Console.WriteLine("Hammer is hitting a nail!");
    }
}
