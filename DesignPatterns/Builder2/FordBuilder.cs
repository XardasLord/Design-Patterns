namespace Builder2
{
    class FordBuilder : ICarBuilder
    {
        private Car _car;

        public FordBuilder()
        {
            _car = new Car();
        }

        public void BuildEngine()
        {
            _car.Engine = new Engine();
            _car.Engine.Model = "Ford Engine";
        }

        public void BuildTires()
        {
            _car.Tires = new Tire();
            _car.Tires.Type = "Ford Tires";
            _car.Tires.Durability = 75;
        }

        public Car GetCar()
        {
            return _car;
        }
    }
}
