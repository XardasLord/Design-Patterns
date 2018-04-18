namespace Factory___Factory_Method___Animals
{
    public class CatFactory : IAnimalFactory
    {
        public Animal GetAnimal()
        {
            return new Cat();
        }
    }
}
