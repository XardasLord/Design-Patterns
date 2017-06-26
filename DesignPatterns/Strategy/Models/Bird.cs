namespace Strategy.Models
{
    public class Bird : Animal
    {
        public Bird()
            : base()
        {
            Sound = "Tweet";
            FlyingType = new ItFlys();
        }
    }
}
