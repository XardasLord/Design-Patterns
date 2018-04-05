using JetBrains.dotMemoryUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Flyweight___Repeating_User_Names
{
    [TestFixture]
    public class Demo
    {
        // Need ReSharper to run this test
        // Run this test with "Run under dotMemory Unit" option
        [Test]
        public void TestUser() // 1655033 bytes
        {
            var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString());
            var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());

            var users = new List<User>();
            foreach (var firstName in firstNames)
                foreach (var lastName in lastNames)
                    users.Add(new User($"{firstName} {lastName}"));

            ForceGC();

            dotMemory.Check(memory =>
            {
                Console.WriteLine(memory.SizeInBytes);
            });
        }

        // This approach saves over 300kB of memory, because we actually storing a lot less deversity in string
        [Test]
        public void TestUser2() // 1296991 bytes
        {
            var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString());
            var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());

            var users = new List<User2>();
            foreach (var firstName in firstNames)
                foreach (var lastName in lastNames)
                    users.Add(new User2($"{firstName} {lastName}"));

            ForceGC();

            dotMemory.Check(memory =>
            {
                Console.WriteLine(memory.SizeInBytes);
            });
        }

        private void ForceGC()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private string RandomString()
        {
            var rand = new Random();
            return new string(
                Enumerable.Range(0, 10)
                .Select(i => (char)('a' + rand.Next(26)))
                .ToArray());
        }
    }
}
