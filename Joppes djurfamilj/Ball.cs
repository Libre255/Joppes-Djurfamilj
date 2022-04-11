namespace JoppesDjurFamilj
{
    public class Ball
    {
        private string colour;
        private int quality = 5;

        public int Quality{
            get{ return quality;}
        }

        public Ball(string _colour = "red")
        {
            colour = _colour;
        }

        public void lower_quality(int tal = 1)
        {
            quality -= tal;
        }
        public override string ToString()
        {
            return $"The ball colour is {colour} and the quality is {quality}/5";
        }
    }
}
