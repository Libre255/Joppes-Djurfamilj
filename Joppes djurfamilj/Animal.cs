using static System.Console;

namespace JoppesDjurFamilj
{
    public abstract class Animal
	{
        protected int _id;
		protected int _age;
		protected string _name = "";
		protected string _fav_food = "";
		protected string _breed = "";
		protected bool _hungry = new Random().Next(0, 2) == 1 ? true : false;
        protected int Energy = 3;
        public int ID { get { return _id; } set { _id = value; } }
		public abstract int Age { get; set; }
		public virtual int Months { get; set; }
        
		public string Name
        {
			set { _name = value; }	
			get { return _name; }
        }
		public bool Hungry
        {
            set { _hungry = value; }
            get { return _hungry; }
        }

		public string Fav_Food
        {
            set { _fav_food = value; }
            get { return _fav_food;}
        } 

		public string Breed
        {
			set { _breed = value; }
            get { return _breed;}
        }
		public virtual void Interact(Laser playLaser)
        {
            if (Hungry)
            {
                WriteLine($"{Name} is hungry and dont want to play!*");
            }
            else
            {
                if (playLaser.Battery == 0)
                {
                    WriteLine("The laser doesnt have battery please recharge");
                }
                else
                {
                    playLaser.lower_battery();
                    WriteLine($"The Cat {Name} is playing laser chasing with Joppe");
                    Energy--;
                    if (Energy == 0)
                    {
                        Hungry = true;
                    }
                }
            }
        }
		public virtual void Interact(Ball playBall)
        {
            if (Hungry)
            {
                WriteLine($"*{Name} is hungry and dont want to play!*");
            }
            else
            {
                if (playBall.Quality == 0)
                {
                    WriteLine("*The ball is broken, need a new ball*");
                }
                else
                {
                    playBall.lower_quality(2);
                    WriteLine($"*{Name} is playing fetch ball with Joppe*");
                    Energy--;
                    if(Energy == 0)
                    {
                        Hungry = true;
                    }
                }
            }
        }

		public void eat(string food){
            if (Hungry)
            {
                if(food.ToLower() != Fav_Food.ToLower())
                {
				    hungry_animal();
                }
                else
                {
				    Hungry = false;
				    WriteLine("*eated food* and is now full");
                }
            }
            else
            {
                WriteLine($"{Name} is full and dont want more food right now");
            }

        }
		public virtual void hungry_animal()
        {
			WriteLine("*The pet didnt like the food and is whimpering*");
        }
		public abstract override string ToString();
	}
}
