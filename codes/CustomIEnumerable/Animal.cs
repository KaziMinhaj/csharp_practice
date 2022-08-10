using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIEnumerable;

public class Animal : IEnumerable<Cat>
{
    private Cat[] _cats;
    public Animal(Cat[] cats)
    {
        _cats = cats;
    }
    public IEnumerator<Cat> GetEnumerator()
    {
        return new AnimalEnumerator(_cats);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
