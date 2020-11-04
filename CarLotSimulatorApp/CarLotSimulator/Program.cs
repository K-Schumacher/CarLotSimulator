using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property



            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //Standard member initialization 
            CarLot lot = new CarLot();

            Car truck = new Car();
            lot.CarList.Add(truck);
            

            truck.Year = 2008;
            truck.Make = "Ford";
            truck.Model = "F150";
            truck.EngineNoise = "VROOM";
            truck.HonkNoise = "BERR BERR";
            truck.IsDriveable = true;

            truck.MakeEngineNoise();
            truck.MakeHonkNoise();

            //Objective initializer syntax
            Car sedan = new Car()
            {
                Year = 2015,
                Make = "Mazda",
                Model = "6",
                EngineNoise = "vroom",
                HonkNoise = "meep meep",
                IsDriveable = true
            };
            lot.CarList.Add(sedan);


            sedan.MakeEngineNoise();
            sedan.MakeHonkNoise();

            //Constructor initialization

            Car trackCar = new Car(2021, "Chevy", "Corvette Stingray", "ZOOM ZOOM", "beep beep", true);
            lot.CarList.Add(trackCar);


            trackCar.MakeEngineNoise();
            trackCar.MakeHonkNoise();

            Console.WriteLine("------------");

            //*************BONUS X 2*************//

            foreach (var car in lot.CarList)
            {
                Console.WriteLine();
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");

            }

        
        

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
