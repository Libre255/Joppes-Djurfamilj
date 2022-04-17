using static System.Console;
namespace JoppesDjurFamilj
{
    public class Puppy : Dog
    {
        private int _months;
        public Puppy(string name, int months) : base(name, months)
        {
            Name = name;
            Age = 0;
            Months = months;
        }

        public override int Months
        {
            get { return _months; }
            set
            {
                if (value < 0)
                {
                    _months = 0;
                }
                else if (value > 12)
                {
                    _months = 12;
                }
                else
                {
                    _months = value;
                }
            }
        }

        public override void Interact(Ball playBall)
        {
            if (Hungry || Energy == 0)
            {
                WriteLine($"*{Name} is hungry and/or with no energy to play*");
            }
            else
            {
                if(playBall.Quality == 0)
                {
                    WriteLine("*The ball is broken, need to buy a new ball*");
                }
                else
                {
                    playBall.lower_quality();
                    WriteLine($"* {Name} is playing with Joppes ball and got a bit broken *");
                    Energy--;
                    if (Energy == 0)
                    {
                        Hungry = true;
                    }
                }
            }
        }

        public override string ToString()
        {
            return $"******* Puppy Name: {Name} *********** " + "\n" +
                   $"        Months: {Months}" + "\n" +
                $"        Favorite Food: {Fav_Food}" + "\n" +
                $"        Breed: {Breed}" + "\n" +
                $"        Hungry: {Hungry}" + "\n";
        }
    }
}
