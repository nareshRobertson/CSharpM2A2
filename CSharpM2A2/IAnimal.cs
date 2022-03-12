using System;
namespace CSharpM2A2
{
    public interface IAnimal
    {
        public String Species { get; set; }
        public int age { get; set; }
        public String UniqueCharacteristic { get; set; }

        public String RequestUniqueCharacteristic();
        public String getDescription();

    }
}
