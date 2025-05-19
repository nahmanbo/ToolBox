namespace ToolBox;

public class NailGun : Tool
{
    //====================================
    //           Constructor
    //====================================
    public NailGun() : base("NailGun", "5.5kg")
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
        Console.WriteLine("NailGun is shooting nails with precision!");
    }
}