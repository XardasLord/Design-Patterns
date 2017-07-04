namespace Builder2
{
    class CarDirector
    {
        private ICarBuilder _builder;

        public CarDirector(ICarBuilder builder)
        {
            _builder = builder;
        }

        public void MakeCar()
        {
            _builder.BuildTires();
            _builder.BuildEngine();
        }

        public Car GetCar()
        {
            return _builder.GetCar();
        }
    }
}
