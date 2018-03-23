using System;
using System.Collections.Generic;

namespace Singleton_With_Tests_And_DI
{
    class ConfigurableRecordFinder
    {
        private IDatabase database;

        public ConfigurableRecordFinder(IDatabase database)
        {
            // This is Dependency Injection (DI), 
            // because we can pass to the constructor the real database or the fake database object

            this.database = database ?? throw new ArgumentNullException(paramName: nameof(database));
        }

        public int GetTotalPopulation(IEnumerable<string> names)
        {
            int result = 0;
            foreach (var name in names)
                result += database.GetPopulation(name);

            return result;
        }
    }
}
