using System;

namespace Builder2
{
    class FerrariBuilder : ICarBuilder
    {
        private Car _car;

        public FerrariBuilder()
        {
            _car = new Car();
        }

        public void BuildEngine()
        {
            _car.Tires = new Tire();
            _car.Tires.Type = "Ferrari Tires";
            _car.Tires.Durability = 100;
        }

        public void BuildTires()
        {
            _car.Engine = new Engine();
            _car.Engine.Model = "Ferrari Engine";
        }

        public Car GetCar()
        {
            return _car;
        }
    }
}
