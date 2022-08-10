using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomICollection;

public class AnimalEnumerator : IEnumerator<Cat>
{
    private Cat[] _cats;
    private int _currentIndex;

    public AnimalEnumerator(Cat[] cats)
    {
        _cats = cats;
        _currentIndex = -1;
    }

    public Cat Current => _cats[_currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        _currentIndex = -1;
        Array.Clear(_cats);
    }

    public bool MoveNext()
    {
        _currentIndex++;
        return _currentIndex >= _cats.Length ? false : true;
    }

    public void Reset()
    {
        _currentIndex = -1;
    }
}
