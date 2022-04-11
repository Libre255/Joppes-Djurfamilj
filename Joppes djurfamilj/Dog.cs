using static System.Console;

namespace JoppesDjurFamilj
{
    public class Dog : Animal
    {
        protected string[] DogBreeds = {
            "Bichon frise", "Grand Danois", "Golden retriever"
        };
        protected string[] DogFavFoods = { 
            "Meat", "Chicken", "Peanut butter"
        };
        public Dog(string name, int age){
            Name = name;
            Age = age;
            Fav_Food = DogFavFoods[new Random().Next(0, 3)];
            Breed = DogBreeds[new Random().Next(0, 3)];
            ID = 0;
        }
        public override int Age
        {
            get { return _age; }
            set { 
                if(value < 0)
                {
                    _age = 0;
                }else if(value > 13)
                {
                    _age = 13;
                }else
                {
                    _age = value;
                }
            }
        }

        public override string ToString()
        {
            return $"******* Dog Name: {Name} *********** " + "\n" +
                   $"        Age: {Age}" + "\n" +
                $"        Favorite Food: {Fav_Food}" + "\n" +
                $"        Breed: {Breed}" + "\n" +
                $"        Hungry: {Hungry}" + "\n";
        }
    }

}
