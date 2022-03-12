using System;
namespace CSharpM2A2
{
    public class Lion : IAnimal
    {
        public String Species { get; set; }
        public int age { get; set; }
        public String UniqueCharacteristic { get; set; }
        public String ManeColour;


        public String RequestUniqueCharacteristic() {

            Console.Write("What colour is it's mane: ");
            ManeColour = Console.ReadLine();
            UniqueCharacteristic = $" with a {ManeColour} mane";

            return UniqueCharacteristic;
        }
        public String getDescription() {

            String description = $"contains a {age} year-old {Species} {UniqueCharacteristic}";
            return description;
        }
    }
}
