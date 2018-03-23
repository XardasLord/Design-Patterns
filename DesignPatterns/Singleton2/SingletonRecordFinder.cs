using System.Collections.Generic;

namespace Singleton_With_Tests_And_DI
{
    public class SingletonRecordFinder
    {
        public int GetTotalPopulation(IEnumerable<string> names)
        {
            int result = 0;
            foreach (var name in names)
                result += SingletonDatabase.Instance.GetPopulation(name);

            return result;
        }
    }
}
