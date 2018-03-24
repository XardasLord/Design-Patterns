namespace Singleton___Monostate
{
    public class CEO
    {
        // These fields are static, and the properties bellow are non-static,
        // so they point always to the same fields, no mather from which CEO object it is called,
        // so all CEO object treat like a Singleton

        private static string name;
        private static int age;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
        }
    }
}
