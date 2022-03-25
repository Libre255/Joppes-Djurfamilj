using static System.Console;

namespace JoppesDjurFamilj
{
    public class PetOwner
    {
        private int _age;
        private List<Animal> Pets = new List<Animal>()
        {
            new Puppy("Lopu", 10),
            new Dog("Kappa", 2),
            new Cat("Oly", 5)
        };
        private string[] petsNames;

        public PetOwner(int age)
        {
            petsNames = Pets.Select(pet => pet.Name).ToArray();
            Age = age;
        }
        public int Age{
            get { return _age; }
            set { _age = value; }
        }
        
        public void List_animals()
        {
            WriteLine("List of Joppes pets");
            WriteLine(" ");
            foreach (Animal pet in Pets)
            {
                WriteLine($"******* Name: {pet.Name} ***********");
                if (pet.Age == 0)
                {
                    WriteLine($"        Months: {pet.Months}");
                }
                WriteLine($"        Age: {pet.Age}");
                WriteLine($"        Favorite Food: {pet.Fav_Food}");
                WriteLine($"        Breed: {pet.Breed}");
                WriteLine(" ");
            }
            ReturnToMenu();
        }
		public void Play()
        {
            Menu playWithPetMenu = new Menu("Which pet would you like to play with?", petsNames);
            int SelectedPet = playWithPetMenu.Run();
            Pets[SelectedPet].Interact();
            ReturnToMenu();
        }
        public void Feed()
        {
            Menu feedPetMenu = new Menu("Select pet to feed", petsNames);
            int selectedPet = feedPetMenu.Run();
            WriteLine("Write the animal food name");
            Pets[selectedPet].eat(ReadLine() ?? "");
            ReturnToMenu();
        }
        public void menu()
        {
            string[] Options = { "Play fetch", "Feed Animal", "List Animals" };
            Menu mainMenu = new Menu("What would you like to do?", Options);
            int SelectedOption = mainMenu.Run();

            switch (SelectedOption)
            {
                case 0:Play();
                    break;
                case 1:Feed();
                    break;
                case 2:List_animals();
                    break;
            }
        }
        private void ReturnToMenu()
        {
            WriteLine("Press any key to go back to the menu");
            ReadKey(true);
            menu();
        }
        
        public override string ToString()
        {
            return $"Joppe Class, age {Age} with {Pets.Count} animals";
        }
    }
}