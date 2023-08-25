using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
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
        public bool HasALargeTrunk { get; set; } = true;
        public bool ALargeTrunk { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Drive()
        {
            if (HasALargeTrunk == true)
            {
                Console.WriteLine($"{GetType().Name} is now driving forward with a trunk full!");

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

     //he said to just do the two in the video, but I tried to add trunk size to this but couldn't get it to work with IVehicle. I added 

       
    }
}

