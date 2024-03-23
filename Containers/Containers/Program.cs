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
                //container Ship Add
                containerShipAdd();
                return false;
            case 2:
                //Container add
                containerAdd();
                return false;
            case 3:
                //Remove Container From a Ship
                removeContainerFromShip();
                return false;
            case 4:
                SwapContainersOnTheShip();
                return false;
            case 5:
                //Move Container From Ship To Another One
                MoveContainerFromShipToAnotherOne();
                return false;
            case 6:
                //Show Info About The Ship
                shipInfo();
                return false;
            case 7:
                //Load Container With A Product
                loadContainer();
                return false;
            case 8:
                //Show Info About The Container
                containerInfo();
                return false;
            case 9:
                //Unload the Container
                unloadContainer();
                return false;
            case 10:
                //Load Container On a Ship
                loadContainerOnShip();
                return false;
            case 11:
                //Load List of Containers On a Ship
                LoadListofContainersOnShip();  //NOT IMPLEMENTED YET
                return false;
            case 0:
                return true;
            default:
                return true;
        }
    }


//ACTIONS

    public static void MoveContainerFromShipToAnotherOne()
    {
        int temp = 1;
        foreach (var ship in containerShipsList)
        {
            Console.WriteLine(temp + ". " + ship.Name);
            temp++;
        }
        Console.Write("Insert the number of a Ship (from): ");
        int choosenShip1 = Convert.ToInt32(Console.ReadLine()) - 1;
        
        temp = 1;
        foreach (var container in containerShipsList[choosenShip1].Containers)   
        {
            Console.WriteLine(temp + ". " + container.SerialNumber);
            temp++;
        }
        Console.WriteLine();
        Console.Write("Insert the number of a container: ");
        Console.WriteLine();
        int choosenContainer = Convert.ToInt32(Console.ReadLine()) - 1;
        
        temp = 1;
        foreach (var ship in containerShipsList)
        {
            Console.WriteLine(temp + ". " + ship.Name);
            temp++;
        }
        Console.Write("Insert the number of a Ship (to): ");
        int choosenShip2 = Convert.ToInt32(Console.ReadLine()) - 1;

        if (containerShipsList[choosenShip1].Containers.Count == 0)
        {
            Console.WriteLine("NO CONTAINERS");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        else
        {
            containerShipsList[choosenShip2].Containers.Add(containerShipsList[choosenShip1].Containers[choosenContainer]);
            containerShipsList[choosenShip1].Containers.RemoveAt(choosenContainer);  
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
      
    }

    public static void SwapContainersOnTheShip()
    {
        int temp = 1;
        foreach (var container in containerList)
        {
            Console.WriteLine(temp + ". " + container.SerialNumber);
            temp++;
        }
        Console.WriteLine();
        Console.Write("Insert the number of a container: ");
        int choosenContainer1 = Convert.ToInt32(Console.ReadLine()) - 1;
        
        temp = 1;
        foreach (var ship in containerShipsList)
        {
            Console.WriteLine(temp + ". " + ship.Name);
            temp++;
        }
        Console.Write("Insert the number of a ship: ");
        int choosenShip = Convert.ToInt32(Console.ReadLine()) - 1;
        
         temp = 1;
        foreach (var container in containerShipsList[choosenShip].Containers)   
        {
            Console.WriteLine(temp + ". " + container.SerialNumber);
            temp++;
        }
        Console.WriteLine();
        Console.Write("Insert the number of a container: ");
        int choosenContainer2 = Convert.ToInt32(Console.ReadLine()) - 1;
        
        
        containerShipsList[choosenShip].Containers.Add(containerList[choosenContainer1]);
        containerList.RemoveAt(choosenContainer1);
        containerList.Add( containerShipsList[choosenShip].Containers[choosenContainer2]);
        containerShipsList[choosenShip].Containers.RemoveAt(choosenContainer2);
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
    }

    public static void LoadListofContainersOnShip()
    {
        List<Container> containers = new List<Container>();
        
    }


    public static void loadContainer()
    {
        int temp = 1;
        foreach (var container in containerList)
        {
            Console.WriteLine(temp + ". " + container.SerialNumber);
            temp++;
        }
        Console.WriteLine();
        Console.Write("Insert the number of a container: ");
        int choosenContainer = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.Write("Insert weight of the product: ");
        containerList[choosenContainer].load(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
    }

    public static void  unloadContainer()
    {
        int temp = 1;
        foreach (var container in containerList)
        {
            Console.WriteLine(temp + ". " + container.SerialNumber);
            temp++;
        }
        Console.WriteLine();
        Console.Write("Insert the number of a container: ");
        int choosenContainer = Convert.ToInt32(Console.ReadLine()) - 1;
        containerList[choosenContainer].dropLoad();
        Console.WriteLine( containerList[choosenContainer].SerialNumber + "has been unloaded!");
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
    }

    public static void loadContainerOnShip()
    {
        int temp = 1;
        foreach (var container in containerList)
        {
            Console.WriteLine(temp + ". " + container.SerialNumber);
            temp++;
        }
        Console.WriteLine();
        Console.Write("Insert the number of a container: ");
        int choosenContainer = Convert.ToInt32(Console.ReadLine()) - 1;
        
        temp = 1;
        foreach (var ship in containerShipsList)
        {
            Console.WriteLine(temp + ". " + ship.Name);
            temp++;
        }
        Console.Write("Insert the number of a container: ");
        int choosenShip = Convert.ToInt32(Console.ReadLine()) - 1;
        containerShipsList[choosenShip].Containers.Add(containerList[choosenContainer]);
        containerList.RemoveAt(choosenContainer);
        
    }

    public static void shipInfo()
    {
        int temp = 1;
        foreach (var ship in containerShipsList)
        {
            Console.WriteLine(temp + ". " + ship.Name);
            temp++;
        }

        Console.Write("Insert the number of a ship: ");
        int choosen = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.WriteLine();
        containerShipsList[choosen].info();
        Console.WriteLine();
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
    }


    public static void containerInfo()
    {
        int temp = 1;
        foreach (var container in containerList)
        {
            Console.WriteLine(temp + ". " + container.SerialNumber);
            temp++;
        }

        Console.Write("Insert the number of a container: ");
        int choosen = Convert.ToInt32(Console.ReadLine()) - 1;
        containerList[choosen].info();
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
    }


    public static void removeContainerFromShip()
    {
        int numberOfShips = 1;
        int numberOfContainers = 1;
        foreach (var ship in containerShipsList)
        {
            Console.WriteLine(numberOfShips + ". " + containerShipsList[numberOfShips - 1].Name1);
            numberOfShips++;
        }


        Console.Write("Type numer of the ship: ");
        int chosenOne = Convert.ToInt32(Console.ReadLine());
        if (containerShipsList[chosenOne].Containers.Count == 0)
        {
            Console.WriteLine("This ship does not have any containers on board!");
        }
        else
        {
            foreach (var container in containerShipsList[chosenOne].Containers)
            {
                Console.WriteLine(numberOfContainers + ". " + container.SerialNumber);
                numberOfContainers++;
            }

            Console.WriteLine();
            Console.Write("Type number of the container: ");
            int choosenContainer = Convert.ToInt32(Console.ReadLine());
            
            containerList.Add(containerShipsList[chosenOne].Containers[choosenContainer]);
            containerShipsList[chosenOne].Containers.RemoveAt(choosenContainer);
        }
    }


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
                containerList.Add(new LiquidContainer(heightL, containerMassL, depthL, maxContainersWeightL));
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
                containerList.Add(
                    new GasContainer(heightG, containerMassG, depthG, maxContainersWeightG, pressureG));
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
                Console.Write("Type the temperature of the container: ");
                Double temperatureC = Convert.ToDouble(Console.ReadLine());
                containerList.Add(new CoolingContainer(heightC, containerMassC, depthC, maxContainersWeightC,
                    temperatureC));
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }


    //MENU AND STUFF

    public static int possibleActions()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Possible Actions:");
        Console.ResetColor();
        int optionsNum = 1;
        int skip = 0;

        Console.WriteLine(optionsNum + ". " + options[0]);
        optionsNum++;
        Console.WriteLine(optionsNum + ". " + options[1]);
        optionsNum++;
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
        }
        else skip = 4;


        if (containerList.Count != 0)
        {
            Console.WriteLine(optionsNum + ". " + options[6]);
            optionsNum++;
            Console.WriteLine(optionsNum + ". " + options[7]);
            optionsNum++;
            Console.WriteLine(optionsNum + ". " + options[8]);
            optionsNum++;
        }
        else skip = 0;

        if (containerShipsList.Count != 0 && containerList.Count != 0)
        {
            Console.WriteLine(optionsNum + ". " + options[9]);
            optionsNum++;
            Console.WriteLine(optionsNum + ". " + options[10]);
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Type 0 to exit");
        Console.ResetColor();
        Console.WriteLine();
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1 || choice == 2)
        {
            return choice;
        }
        else
        {
            return choice  + skip;
        }
        
        
        
    }


    public static void Menu()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("List of Container Ships:");
        Console.ResetColor();
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
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("List of Containers:");
        Console.ResetColor();
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
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Port of Rotterdam");
        Console.ResetColor();
        //Thread.Sleep(3000);
        Console.WriteLine();
    }
    
    
   
}