using System.Collections;

namespace CustomICollection;


public class Animal : ICollection<Cat>
{
    private Cat[] _cats;
    private int _position;
    public Animal(Cat[] cats)
    {
        _cats = cats;
        while (_position < _cats.Length && _cats[_position] != null)
            _position++;
    }

    public int Count => _cats.Length;

    public bool IsReadOnly => true;

    public void Add(Cat item)
    {
        _cats[_position++] = item; 
    }

    public void Clear()
    {
        Array.Clear(_cats);
    }

    public bool Contains(Cat item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(Cat[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Cat> GetEnumerator()
    {
        return new AnimalEnumerator(_cats);
    }

    public bool Remove(Cat item)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<Cat> IEnumerable<Cat>.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
