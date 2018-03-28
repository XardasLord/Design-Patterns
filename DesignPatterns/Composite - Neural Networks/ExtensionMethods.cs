﻿using System.Collections.Generic;

namespace Composite___Neural_Networks
{
    public static class ExtensionMethods
    {
        public static void ConnectTo(this IEnumerable<Neuron> self, IEnumerable<Neuron> other)
        {
            if (ReferenceEquals(self, other)) return;

            foreach(var from in self)
                foreach(var to in other)
                {
                    from.Out.Add(to);
                    to.In.Add(from);
                }
        }
    }
}
