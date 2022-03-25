using static System.Console;

namespace JoppesDjurFamilj
{
    public class Dog : Animal
    {
        protected string[] DogBreeds = {
            "Bichon frise", "Grand Danois", "Golden retriever"
        };
        protected string[] DogFavFoods = { 
            "Mean", "Chicken", "Peanut butter"
        };
        public Dog(string name, int age){
            Name = name;
            Age = age;
            Hungry = new Random().Next(0, 2) == 1 ? true : false;
            Fav_Food = DogFavFoods[new Random().Next(0, 3)];
            Breed = DogBreeds[new Random().Next(0, 3)];
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

        public override void Interact()
        {
            if (Hungry)
            {
                WriteLine($"The dog {Name} is hungry and dont want to play!");
            }
            else
            {
                WriteLine($"The dog {Name} is playing fetch ball with Joppe");
            }
        }

        public override string ToString()
        {
            return $"Dog Class, {Name}, {Age}, {Breed}, {Fav_Food}, {Hungry}";
        }
    }

    public class Puppy:Dog
    {
        protected int _months;
        public Puppy( string name, int months) : base(name, months)
        {
            Name = name;
            Age = 0;
            Months = months;
            Hungry = new Random().Next(0, 2) == 1 ? true : false;
            Fav_Food = DogFavFoods[new Random().Next(0, 3)];
            Breed = DogBreeds[new Random().Next(0, 3)];
        }

        public override int Months
        {
            get { return _months; }
            set { 
                if(value < 0)
                {
                    _months = 0;
                }else if(value > 12)
                {
                    _months = 12;
                }else
                {
                    _months = value;
                }
            }
        }

        public override void Interact()
        {
            if (Hungry)
            {
                WriteLine($"The puppy {Name} is hungry and dont want to play!");
            }
            else
            {
                WriteLine($"The puppy {Name} is playing with Joppes Hand");
            }
        }

        public override string ToString()
        {
            return $"Puppy Class, {Name}, {Months}, {Breed}, {Fav_Food}, {Hungry}";
        }
    }
}
