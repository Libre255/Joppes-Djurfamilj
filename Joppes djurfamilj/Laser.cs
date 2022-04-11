namespace JoppesDjurFamilj
{
    public class Laser
    {
        private int battery = 100;
        private string colour;

        public int Battery
        {
            get { return battery; }
        }

        public Laser(string color_ = "Green")
        {
            colour = color_;
        }

        public void lower_battery()
        {
            battery -= 10;
        }
        public override string ToString()
        {
            return $"The ball colour is {colour} and the Battery is {battery}%";
        }
    }
}
