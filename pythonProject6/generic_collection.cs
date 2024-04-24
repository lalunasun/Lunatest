// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Linq;

public class ValueTypeCollection<T> where T : struct
{
    private List<T> collection;

    public ValueTypeCollection()
    {
        collection = new List<T>();
    }

    public void AddItem(T item)
    {
        collection.Add(item);
    }

    public T GetItem(int index)
    {
        if (index >= 0 && index < collection.Count)
        {
            return collection[index];
        }
        else
        {
            throw new ArgumentOutOfRangeException("Index is out of range.");
        }
    }

    public List<T> GetSortedDescendingCollection()
    {
        List<T> sortedCollection = new List<T>(collection);
        sortedCollection.Sort();
        sortedCollection.Reverse();
        return sortedCollection;
    }
}


class Program
{
    static void Main(string[] args)
    {
        ValueTypeCollection<int> intCollection = new ValueTypeCollection<int>();
        intCollection.AddItem(1);
        intCollection.AddItem(2);
        intCollection.AddItem(3);
        intCollection.AddItem(4);

        Console.WriteLine("Items in the collection:");
        for (int i = 0; i < intCollection.GetSortedDescendingCollection().Count; i++)
        {
            Console.WriteLine(intCollection.GetSortedDescendingCollection()[i]);
        }

        Console.WriteLine("\nItem at index 1: " + intCollection.GetItem(3));
    }
}
