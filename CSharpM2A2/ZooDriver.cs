using System;
using System.Collections.Generic;

namespace CSharpM2A2
{
    class ZooDriver
    {
        public static List<IAnimal> Animals = new List<IAnimal>();

        static void Main(string[] args)
        {
            int NumberOfAnimals;
            String AnimalSpeciesName;
            //Aks user for number of animals to input
            Console.Write("How many animals would you like to add? ");
            NumberOfAnimals = Convert.ToInt32(Console.ReadLine());
            bool isValid;
            //for loop to handle the input
            for (int i = 0; i < NumberOfAnimals; i++)
            {
                //do while condition to sort which animal object to create
                do
                {
                    Console.WriteLine($"\nCage {i+1}");
                    Console.Write("What is the animal species? (Lion/Bear/Wolf) ");
                    AnimalSpeciesName = Console.ReadLine();
                    if (AnimalSpeciesName.Equals("lion", StringComparison.CurrentCultureIgnoreCase))
                    {
                        isValid = true;
                        Lion objLion = new Lion();
                        Animals.Add(objLion);
                    }
                    else if (AnimalSpeciesName.Equals("bear", StringComparison.CurrentCultureIgnoreCase))
                    {
                        isValid = true;
                        Bear objBear = new Bear();
                        Animals.Add(objBear);

                    }
                    else if (AnimalSpeciesName.Equals("wolf", StringComparison.CurrentCultureIgnoreCase))
                    {
                        isValid = true;
                        Wolf objWolf = new Wolf();
                        Animals.Add(objWolf);
                    }
                    else
                    {
                        isValid = false;
                        Console.WriteLine("Sorry that species is invalid!.");
                    }
                } while (!isValid);
                //add the string to object string
                Animals[i].Species =AnimalSpeciesName;
                //ask for age
                Console.Write("How old is it? ");
                Animals[i].age = Convert.ToInt32(Console.ReadLine());
                //check if animal list is an IAnimal
                if (Animals[i] is IAnimal)
                {
                    //Ask user for the unique Charasteristics then save to string
                    Animals[i].UniqueCharacteristic = Animals[i].RequestUniqueCharacteristic();
                }
            }
            Console.WriteLine("=====");

            //To output all the animals with cage # and description
            for (int j=0; j<NumberOfAnimals; j++) {
                Console.WriteLine($"Cage {j+1} {Animals[j].getDescription()}");
            }
        }
    }
}
