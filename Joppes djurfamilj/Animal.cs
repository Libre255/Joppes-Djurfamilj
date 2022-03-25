using static System.Console;

namespace JoppesDjurFamilj
{
	public abstract class Animal
	{
		protected int _age;
		protected string _name = "";
		protected string _fav_food = "";
		protected string _breed = "";
		protected bool _hungry;

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
		public abstract void Interact();
		
		public void eat(string food){
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
		public virtual void hungry_animal()
        {
			WriteLine("*The pet didnt like the food and is whimpering*");
        }
		public abstract override string ToString();
	}
}
