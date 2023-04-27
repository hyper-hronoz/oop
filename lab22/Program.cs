interface IIterator
{
    public int getByIndex(int index);
}

abstract class AHolder<T>
{
    protected int _from;
    protected int _to;

    protected T[] items = { };

    protected AHolder(int _from, int _to)
    {
        this._from = _from;
        this._to = _to;
    }

    abstract public IEnumerator<T> GetEnumerator();
}

class Test : AHolder<int>, IIterator
{
    public Test(int _from, int _to, int[] arr) : base(_from, _to) {
      this.items = arr;
    }

    public int getByIndex(int index)
    {
      try {
        return this.items[index];
      } catch (IndexOutOfRangeException e) {
        Console.WriteLine(e.Message);
        return -1;
      }
    }

    public override IEnumerator<int> GetEnumerator()
    {
       for (int i = _from; i < (_to >= this.items.Length ? this.items.Length : _to); i++)
        {
            yield return items[i];
        }
    }
}

public class Program
{
    public static void Main() { 
      Test test = new Test(1, 10, new int[]{1, 2, 3, 4});
      foreach (int i in test) {
        Console.WriteLine(i);
      }
      IIterator test2 = test; 
      Console.WriteLine(test2.getByIndex(10));
    }
}
