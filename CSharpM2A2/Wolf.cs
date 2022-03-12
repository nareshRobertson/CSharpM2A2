using System;
namespace CSharpM2A2
{
    public class Wolf : IAnimal
    {
        public String Species { get; set; }
        public int age { get; set; }
        public String UniqueCharacteristic { get; set; }
        public int speed;


        public String RequestUniqueCharacteristic()
        {

            Console.Write("How fast can it run (in km/hr)? ");
            speed = Convert.ToInt32(Console.ReadLine());
            UniqueCharacteristic = $" that runs {speed} km/hr";

            return UniqueCharacteristic;
        }
        public String getDescription()
        {

            String description = $"contains a {age} year-old {Species} {UniqueCharacteristic}";
            return description;
        }
    }
}
