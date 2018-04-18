namespace Factory___Factory_Method___Animals
{
    public class FishFactory : IAnimalFactory
    {
        public Animal GetAnimal()
        {
            return new Fish();
        }
    }
}
