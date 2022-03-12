using System;
namespace CSharpM2A2
{
    public class Bear : IAnimal
    {
            
        public String Species { get; set; }
        public int age { get; set; }
        public String UniqueCharacteristic { get; set; }
        public bool IsGrizzly;
        public string BearBool;

        //request user to input a unique characteristic

        public String RequestUniqueCharacteristic()
        {
            
            Console.Write("Is it a grizzly bear (true/false)?");
            BearBool = Console.ReadLine();
            //if else statement to decide what kind of bear
            if (BearBool.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || BearBool.Equals("true", StringComparison.CurrentCultureIgnoreCase))
            {
                IsGrizzly = true;
                UniqueCharacteristic = " , grizzly bear";
            }
            else if (BearBool.Equals("no", StringComparison.CurrentCultureIgnoreCase) || BearBool.Equals("false", StringComparison.CurrentCultureIgnoreCase))
            {
                IsGrizzly = false;
                UniqueCharacteristic = " , non-grizzly bear";
            }
            else
            {
                Console.WriteLine("Invalid input");
                BearBool = null;
            }

            return UniqueCharacteristic;
        }
        public String getDescription()
        {

            String description = $"contains a {age} year-old {Species} {UniqueCharacteristic}";
            return description;
        }

    }
}
