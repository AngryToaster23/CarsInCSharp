//show main menue

using carsVroom;
//variables
int intUserInput = 0;
string strUserInput = "";
List<vroomCat> cars = new List<vroomCat>();

while (intUserInput != 4)
{
    Console.WriteLine("Welcome to THE DeAlErShIp\n");
    Console.WriteLine("--------------------");
    Console.WriteLine("1. Add a new car\n2. List all cars\n3. Remove a Car\n4. Remove Car");

    try
    {
        strUserInput = Console.ReadLine();
        intUserInput = int.Parse(strUserInput);
    }    catch (Exception ex)
    {
        switch (intUserInput)
        {
            case 0:
                break;
            case 1:
                Console.WriteLine("Add a new car");
                string make, model, color;
                int year;
                Console.WriteLine("Enter the make");
                make=Console.ReadLine();
                Console.WriteLine("Enter the model");
                model = Console.ReadLine();
                Console.WriteLine("Enter the color");
                color = Console.ReadLine();
                Console.WriteLine("Enter the year");
                year = int.Parse(Console.ReadLine());
                vroomCat newCar = new vroomCat(make, model, year, color);
                cars.Add(newCar);
                break;
            case 2:
                Console.WriteLine("List all cars");
                foreach (var vroomCat in cars)
                {

                }
                break;
            case 3:
                Console.WriteLine("Remove Car");
                break;
            case 4:
                Console.WriteLine("Exit");
                break;
        }
    }

}

