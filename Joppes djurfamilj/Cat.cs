using static System.Console;

namespace JoppesDjurFamilj
{
    internal class Cat : Animal
    {
        string[] CatFavFoods = {
                "Tuna", "Salmon", "Chicken"
            };
        string[] CatBreeds = { 
            "Perser", "Maine Coon", "British short hair"
        };
        public Cat(string name, int age) {
            Name = name;
            Age = age;
            Hungry = new Random().Next(0, 2) == 1 ? true : false;
            Fav_Food = CatFavFoods[new Random().Next(0, 3)];
            Breed = CatBreeds[new Random().Next(0, 3)];
        }

        public override int Age
        {
            get { return _age; }
            set { 
                if(value < 0)
                {
                    _age = 0;
                }else if(value > 18)
                {
                    _age = 18;
                }
                else
                {
                    _age = value;
                }
             }
        }
        public override void hungry_animal()
        {
            WriteLine($"*{Name} didn't like the food and is now chasing a mouse*");
            bool FoundMouse = new Random().Next(0,2) == 1 ? true : false;

            if(FoundMouse)
            {
                Hungry = false;
                WriteLine($"The cat {Name} found a mouse and now is full!");
            }
            else
            {
                Hungry = true;
                WriteLine($"The cat {Name} couldnt find a mouse and is still hungry!");
            }
        }
        public override void Interact()
        {
            if (Hungry)
            {
                WriteLine($"The Cat {Name} is hungry and dont want to play!");
            }
            else
            {
                WriteLine($"The Cat {Name} is playing laser chasing with Joppe");
            }
        }
        public override string ToString()
        {
            return $"Cat Class, {Name}, {Age}, {Breed}, {Fav_Food}, {Hungry}";
        }
    }
}
