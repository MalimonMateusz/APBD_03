namespace Containers;

public class Container : IHazardNotifier
{
    public double loadWeight = 0;
    public double hight;
    public double containerMass;
    public double depth;
    public String serialNumber = "KON-";
    public double maximumLoad;


    protected Container(double hight, double containerMass, double depth, double maximumLoad)
    {
        this.hight = hight;
        this.containerMass = containerMass;
        this.depth = depth;
        this.maximumLoad = maximumLoad;
    }

     protected virtual void dropLoad()
    {
        loadWeight = 0;
    }

    protected virtual void load(int load)
    {
        if (maximumLoad*0.9 < this.loadWeight + load){
            hazard();
}
        else
        {
            this.loadWeight += load;
        }
       
        
    }
    
    
    
    
    
    
    
    
    
    
    

    public void hazard()
    {
        Console.WriteLine("Hazard! " + this.serialNumber);
    }

    public double LoadWeight
    {
        get => loadWeight;
        set => loadWeight = value;
    }

    public double Hight
    {
        get => hight;
        set => hight = value;
    }

    public double ContainerMass
    {
        get => containerMass;
        set => containerMass = value;
    }

    public double Depth
    {
        get => depth;
        set => depth = value;
    }

    public string SerialNumber
    {
        get => serialNumber;
        set => serialNumber = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double MaximumLoad
    {
        get => maximumLoad;
        set => maximumLoad = value;
    }
}