using System;
using System.Collections.Generic;

namespace Assignment_1
{
    public class AnimalCreator
    {
        public void CreateAndAddAnimal(List<ITalkable> zoo)
        {
            Console.WriteLine("What type of animal would you like to create? (Dog, Cat, Teacher):");
            string? animalType = Console.ReadLine()?.Trim().ToLower();

            switch (animalType)
            {
                case "dog":
                    CreateDog(zoo);
                    break;
                case "cat":
                    CreateCat(zoo);
                    break;
                case "teacher":
                    CreateTeacher(zoo);
                    break;
                default:
                    Console.WriteLine("Invalid animal type. Please enter Dog, Cat, or Teacher.");
                    break;
            }
        }

        private void CreateDog(List<ITalkable> zoo)
        {
            Console.Write("Enter the dog's name: ");
            string? name = Console.ReadLine();

            Console.Write("Is the dog friendly? (true/false): ");
            bool isFriendly;
            while (!bool.TryParse(Console.ReadLine(), out isFriendly))
            {
                Console.WriteLine("Invalid input. Please enter true or false.");
            }

            zoo.Add(new Dog(isFriendly, name ?? "Unnamed Dog"));
            Console.WriteLine("Dog created and added to the zoo.");
        }

        private void CreateCat(List<ITalkable> zoo)
        {
            Console.Write("Enter the cat's name: ");
            string? name = Console.ReadLine();

            Console.Write("Enter the number of mice killed by the cat: ");
            int mousesKilled;
            while (!int.TryParse(Console.ReadLine(), out mousesKilled) || mousesKilled < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }

            zoo.Add(new Cat(mousesKilled, name ?? "Unnamed Cat"));
            Console.WriteLine("Cat created and added to the zoo.");
        }

        private void CreateTeacher(List<ITalkable> zoo)
        {
            Console.Write("Enter the teacher's name: ");
            string? name = Console.ReadLine();

            Console.Write("Enter the teacher's age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }

            zoo.Add(new Teacher(age, name ?? "Unnamed Teacher"));
            Console.WriteLine("Teacher created and added to the zoo.");
        }
    }
}
