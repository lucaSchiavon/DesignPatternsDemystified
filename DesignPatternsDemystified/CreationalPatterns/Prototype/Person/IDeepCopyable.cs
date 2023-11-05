using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.CreationalPatterns.Prototype.Person
{
    public interface IDeepCopyable<T>
    {
        T DeepCopy();
    }

}
