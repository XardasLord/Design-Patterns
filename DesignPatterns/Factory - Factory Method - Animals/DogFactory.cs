namespace Factory___Factory_Method___Animals
{
    public class DogFactory : IAnimalFactory
    {
        public Animal GetAnimal()
        {
            return new Dog();
        }
    }
}
