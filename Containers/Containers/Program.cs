using Containers;

class Program
{
    private static List<containerShip> containerShipsList = new List<containerShip>();
    private static List<Container> containerList = new List<Container>();
    private static List<String> options = new List<string>();

    static void Main(string[] args)
    {
        options = opt(options);
        
        
        Greetings();
        while (true)
        {
            Menu();
            Boolean exit = action(possibleActions());


            if (exit)
            {
                break;
            }
        }
    }





    public static Boolean action(int choice)
    {
        switch (choice)
        {
            case 1:
                containerShipAdd();
                return false;
            case 2:
                containerAdd();
                return false;
              
            case 10:
                
                
                return false;
            default:
                return true;
            
        }
    }




//ACTIONS

    public static void containerShipAdd()
    {
        Console.Write("Type the name name of a ship: ");
        String name = Console.ReadLine();
        Console.Write("Type the max speed of a ship: ");
        Double maxSpeed = Convert.ToDouble(Console.ReadLine());
        Console.Write("Type the maximum number of containers that can be on the ship: ");
        int numOfContainers = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type the maximum weight of the containers that ship can carry: ");
        int maxContainersWeight = Convert.ToInt32(Console.ReadLine());
        containerShipsList.Add(new containerShip(name, maxSpeed, numOfContainers, maxContainersWeight));
    }



    public static void containerAdd()
    {
        Console.Write("1.Liquid  2.Gas  3.Cooling: ");
        int type = Convert.ToInt32(Console.ReadLine());

        switch (type)
        {
           case 1:
               Console.Write("Type hight of the container: ");
               Double heightL = Convert.ToDouble(Console.ReadLine());
               Console.Write("Type weight of the container: ");
               Double containerMassL = Convert.ToDouble(Console.ReadLine());
               Console.Write("Type the depth of the container: ");
               Double depthL = Convert.ToDouble(Console.ReadLine());
               Console.Write("Type the maximum load of the container: ");
               int maxContainersWeightL = Convert.ToInt32(Console.ReadLine());
               containerList.Add(new LiquidContainer(heightL,containerMassL, depthL,maxContainersWeightL));
               break;
           case 2:
               Console.Write("Type hight of the container: ");
               Double heightG = Convert.ToDouble(Console.ReadLine());
               Console.Write("Type weight of the container: ");
               Double containerMassG = Convert.ToDouble(Console.ReadLine());
               Console.Write("Type the depth of the container: ");
               Double depthG = Convert.ToDouble(Console.ReadLine());
               Console.Write("Type the maximum load of the container: ");
               int maxContainersWeightG = Convert.ToInt32(Console.ReadLine());
               Console.Write("Type the pressure of the container: ");
               Double pressureG = Convert.ToDouble(Console.ReadLine());
               containerList.Add(new GasContainer(heightG,containerMassG, depthG,maxContainersWeightG, pressureG));
               break;
           case 3:
               Console.Write("Type hight of the container: ");
               Double heightC = Convert.ToDouble(Console.ReadLine());
               Console.Write("Type weight of the container: ");
               Double containerMassC = Convert.ToDouble(Console.ReadLine());
               Console.Write("Type the depth of the container: ");
               Double depthC = Convert.ToDouble(Console.ReadLine());
               Console.Write("Type the maximum load of the container: ");
               int maxContainersWeightC = Convert.ToInt32(Console.ReadLine());
               Console.Write("Type the pressure of the container: ");
               Double temperatureC = Convert.ToDouble(Console.ReadLine());
               containerList.Add(new GasContainer(heightC,containerMassC, depthC,maxContainersWeightC, temperatureC));
               break;
           default:
               Console.WriteLine("Invalid Input");
               break;
        }
        
        
       
    }

























































    //MENU AND STUFF
    
    public static int possibleActions()
    {
        Console.WriteLine("Possible Actions:");
        Console.WriteLine();
        int optionsNum = 1;
        int skip = 0;
        
        Console.WriteLine(optionsNum + ". " + options[0]);
        optionsNum++;
        Console.WriteLine(optionsNum + ". " + options[1]);
        if (containerShipsList.Count != 0)
        {
            Console.WriteLine(optionsNum + ". " + options[2]);
            optionsNum++;
            Console.WriteLine(optionsNum + ". " + options[3]);
            optionsNum++;
            Console.WriteLine(optionsNum + ". " + options[4]);
            optionsNum++;
            Console.WriteLine(optionsNum + ". " + options[5]);
            optionsNum++;
        }else skip = 4;
        

        if (containerList.Count != 0)
        {
            Console.WriteLine(optionsNum + ". " + options[6]); 
            optionsNum++;
            Console.WriteLine(optionsNum + ". " + options[7]); 
            optionsNum++;
            Console.WriteLine(optionsNum + ". " + options[8]); 
            optionsNum++;
        } else skip = 0;

        if (containerShipsList.Count != 0 && containerList.Count != 0)
        {
            Console.WriteLine(optionsNum + ". " + options[9]); 
            optionsNum++;
            Console.WriteLine(optionsNum + ". " + options[10]);
        }
        Console.WriteLine("Type 0 to exit");
        Console.WriteLine();
        int choice = Convert.ToInt32(Console.ReadLine()) + skip;
        return choice;
    }


    public static void Menu()
    {
        Console.WriteLine();
        Console.WriteLine("List of Container Ships:");
        if (containerShipsList.Count == 0)
        {
            Console.WriteLine("None");
        }
        else
        {
            foreach (var ship in containerShipsList)
            {
                Console.WriteLine(ship.Name + "( speed=" + ship.MaxSpeed + ", maxContainerNum=" +
                                  ship.MaxNumOfContainers + ", maxWeight=" + ship.MaxContainersWeight + " )");
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("List of Containers:");
        if (containerList.Count == 0)
        {
            Console.WriteLine("None");
        }
        else
        {
            foreach (var container in containerList)
            {
                Console.WriteLine("( Serial Number=" + container.serialNumber + " )");
            }
        }

        Console.WriteLine();
        Console.WriteLine();
    }

    public static List<String> opt(List<String> a)
    {
        a.Add("Add Container Ship");
        a.Add("Add Container");
        
        a.Add("Remove Container From a Ship");
        a.Add("Swap Containers On The Ship");
        a.Add("Move Container From Ship To Another One");
        a.Add("Show Info About The Ship");


        a.Add("Load Container With A Product");
        a.Add("Show Info About The Container");
        a.Add("Unload the Container");
        
        a.Add("Load Container On a Ship");
        a.Add("Load List of Containers On a Ship");
        // 2 4 3 2
        return a;
    }


    public static void Greetings()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The official program for the Port of Rotterdam");
        //Thread.Sleep(3000);
        Console.WriteLine();
    }
}