namespace Builder2
{
    class Car
    {
        public Tire Tires { get; set; }
        public Engine Engine { get; set; }

        public Car()
        {
        }

        public new string ToString()
        {
            return $"Car. Engine model: {Engine.Model}, Tires: {Tires.Type}, durability: {Tires.Durability}.";
        }
    }
}
