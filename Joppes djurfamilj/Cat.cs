using static System.Console;

namespace JoppesDjurFamilj
{
    internal class Cat : Animal
    {
        private string[] CatFavFoods = {
                "Tuna", "Salmon", "Chicken"
            };
        private string[] CatBreeds = { 
            "Perser", "Maine", "British"
        };
        public Cat(string name, int age) {
            Name = name;
            Age = age;
            Fav_Food = CatFavFoods[new Random().Next(0, 3)];
            Breed = CatBreeds[new Random().Next(0, 3)];
            ID = 1;
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
                WriteLine($"*{Name} found a mouse and now is full*");
            }
            else
            {
                Hungry = true;
                WriteLine($"*{Name} couldnt find a mouse and is still hungry*");
            }
        }
        public override string ToString()
        {
           return $"******* Cat Name: {Name} *********** " + "\n" +
                  $"        Age: {Age}" + "\n" +
                $"        Favorite Food: {Fav_Food}" + "\n" +
                $"        Breed: {Breed}" + "\n" +
                $"        Hungry: {Hungry}" + "\n";
        }
    }
}
