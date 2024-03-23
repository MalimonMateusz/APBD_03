namespace Containers;

public class containerShip
{
    
    private String name;
     private List<Container> containers = new List<Container>();
     private double maxSpeed;
     private int maxNumOfContainers;
     private int maxContainersWeight;

     public containerShip(String name, double maxSpeed, int maxNumOfContainers, int maxContainersWeight )
     {
         this.name = name;
         this.maxSpeed = maxSpeed;
         this.maxNumOfContainers = maxNumOfContainers;
         this.maxContainersWeight = maxContainersWeight;
     }






     public void info()
     {
         Console.WriteLine("Name: " + name);
         Console.WriteLine("MaxSpeed: " + maxSpeed);
         Console.WriteLine("Maximum Number Of Containers: " + maxNumOfContainers);
         Console.WriteLine("Maximum Containers' Weight: " + maxContainersWeight);
         Console.WriteLine("Containers on board: ");
         Console.WriteLine();
         foreach (var container in containers)
         {
             Console.WriteLine(container.SerialNumber);
         }
     }
     
     
     
     public string Name1
     {
         get => name;
         set => name = value ?? throw new ArgumentNullException(nameof(value));
     }


     public List<Container> Containers
     {
         get => containers;
         set => containers = value ?? throw new ArgumentNullException(nameof(value));
     }

     
     
     
     public double MaxSpeed
     {
         get => maxSpeed;
         set => maxSpeed = value;
     }

     public int MaxNumOfContainers
     {
         get => maxNumOfContainers;
         set => maxNumOfContainers = value;
     }

     public int MaxContainersWeight
     {
         get => maxContainersWeight;
         set => maxContainersWeight = value;
     }

     public string Name
     {
         get => name;
         set => name = value ?? throw new ArgumentNullException(nameof(value));
     }
}