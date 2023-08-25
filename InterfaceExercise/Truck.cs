using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		public Truck()
		{
		}

        public double EngineSize { get; set; } = 4.6;
        public string Model { get; set; } = "Ford";
        public string Make { get; set; } = "F150";
        public int NumberofWheels { get; set; } = 4;
        public string Motto { get; set; } = "Built Ford Tough";
        public string CompanyName { get; set; } = "Ford";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} is now driving forward!");
                
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is now driving forward!");
            }
            
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

