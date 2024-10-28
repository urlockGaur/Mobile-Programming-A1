using System;
using System.Collections.Generic;

namespace Assignment_1
{
    public class Program
    {
        private static readonly FileOutput OutFile = new("animals.txt");
        private static readonly FileInput InFile = new("animals.txt");

        public static void Main(string[] args)
        {
            var zoo = new List<ITalkable>();
            var animalCreator = new AnimalCreator();

            // Use the AnimalCreator to add an animal to the list
            animalCreator.CreateAndAddAnimal(zoo);

            foreach (var talkable in zoo)
            {
                PrintOut(talkable);
            }

            // Removed OutFile.Close();
            InFile.ReadFile();
        }

        private static void PrintOut(ITalkable talkable)
        {
            Console.WriteLine($"{talkable.Name} says: {talkable.Talk()}");
            OutFile.WriteFile($"{talkable.Name} | {talkable.Talk()}");
        }
    }
}
