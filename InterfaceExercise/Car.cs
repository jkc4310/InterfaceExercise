using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public double EngineSize { get; set; } = 4.6;
        public string Model { get; set; } = "Ford";
        public string Make { get; set; } = "focus";
        public int NumberofWheels { get; set; } = 4;
        public string Motto { get; set; } = "Built Ford Tough";
        public string CompanyName { get; set; } = "Ford";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} is now driving forward!");
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {GetType().Name} is now in park!");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears!");
            }
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {GetType().Name} is now reversing!");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears!");
            }
            
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged; 
        }

        
    }
}

