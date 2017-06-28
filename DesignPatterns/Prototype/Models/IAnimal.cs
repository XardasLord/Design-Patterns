using System;

namespace Prototype.Models
{
    public interface IAnimal : ICloneable
    {
        IAnimal MakeCopy();
    }
}
