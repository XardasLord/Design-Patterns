namespace Composite___Neural_Networks
{
    class Program
    {
        static void Main(string[] args)
        {
            var neuron1 = new Neuron();
            var neuron2 = new Neuron();

            neuron1.ConnectTo(neuron2); // 1

            var layer1 = new NeuronLayer();
            var layer2 = new NeuronLayer();

            neuron1.ConnectTo(layer1); // This is possible, because both neuron1 and layer1 are IEnumerable<Neuron>
            layer1.ConnectTo(layer2);
        }
    }
}
