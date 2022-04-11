using static System.Console;

namespace JoppesDjurFamilj
{
    public class PetOwner:Ball
    {
        private int AgeOwner = 35;
        private List<Animal> Pets = new List<Animal>()
        {
            new Puppy("Lopu", 10),
            new Dog("Kappa", 2),
            new Cat("Oly", 5)
        };
        private Ball Ball = new Ball();
        private Laser Laser = new Laser();
        private string[] petsNames;

        public PetOwner()
        {
            petsNames = Pets.Select(pet => pet.Name).ToArray();
        }
        
        public void Check_Ball()
        {
            WriteLine(Ball.ToString());
            if(Ball.Quality <= 1)
            {
                WriteLine("Time to buy a new boll");
            }
        }
        public void Check_Laser()
        {
            WriteLine(Laser.ToString());
            if (Laser.Battery <= 1)
            {
                WriteLine("Time to recharge Battery");
            }
        }
        public void List_animals()
        {
            WriteLine("List of Joppes pets" + "\n");
            foreach (Animal pet in Pets)
            {
                WriteLine(pet.ToString());
            }
        }
		public void Fetch()
        {
            Menu playWithPetMenu = new Menu("Which pet would you like to play with?", petsNames);
            int SelectedPet = playWithPetMenu.Run();
            if(Pets[SelectedPet].ID == 0)
            {
                Pets[SelectedPet].Interact(Ball);
            }else if(Pets[SelectedPet].ID == 1)
            {
                Pets[SelectedPet].Interact(Laser);
            }
            
        }
        public void Feed()
        {
            Menu feedPetMenu = new Menu("Select pet to feed", petsNames);
            int selectedPet = feedPetMenu.Run();
            string userInput;
            do
            {
                Clear();
                WriteLine("Please write the animal food name");

                userInput = ReadLine();
                
            } while (userInput == "" || userInput.Any(c => !char.IsLetter(c)) );
            Pets[selectedPet].eat(userInput);
        }
        public void menu()
        {
            string[] Options = { "Play fetch", "Feed Animal", "List Animals", "Check ball status", "Check laser status" };
            Menu mainMenu = new Menu("What would you like to do?", Options);
            int SelectedOption = mainMenu.Run();

            switch (SelectedOption)
            {
                case 0:Fetch();
                    break;
                case 1:Feed();
                    break;
                case 2:List_animals();
                    break;
                case 3:Check_Ball();
                    break;
                case 4:Check_Laser();
                    break;
            }
            ReturnToMenu();
        }
        private void ReturnToMenu()
        {
            WriteLine("Press any key to go back to the menu");
            ReadKey(true);
            menu();
        }
        
        public override string ToString()
        {
            return $"Joppe Class, age {AgeOwner} with {Pets.Count} animals";
        }
    }
}