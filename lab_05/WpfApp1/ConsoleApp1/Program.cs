using System;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {

        ObservableList1 list = new();

        list.Added += (object sender, ChangedEventArgs e) =>
        {
            Console.WriteLine("Added event occured: value=" + e.Value);
        };

        Console.WriteLine("Adding");
        list.Add(1);
        list.Add(1);

        Console.WriteLine("Setting");
        List<int> newList = new List<int>() { 1, 2, 3, 4 };
        list.Set(newList);

        Console.WriteLine("\nGetting");
        list.Get();

        Console.WriteLine("Removing '3'");
        list.RemoveAt(2);
        list.Get();
    }
}

public class ObservableList1
{
    private List<int> list = new List<int>();
    public int Length { get => Length; set => Length= value; }

    public event EventHandler<ChangedEventArgs> Added;
    public event EventHandler<ChangedEventArgs> Updated;
    public event EventHandler<ChangedEventArgs> Removed;
    public int this[int index]
    {
        get
        {
            int results;
            if (index >= 0 && index <= this.list.Count)
                results = this.list[index];
            else
                results = 0;

            return results;
        }
        set
        {
            if (index >= 0 && index <= this.list.Count)
                this.list[index] = value;
        }
    }

    protected void OnAdd(ChangedEventArgs e) 
    {
        EventHandler<ChangedEventArgs> handler = this.Added;
        if (handler != null) handler(this, e);

    }
    protected virtual void OnUpdate(ChangedEventArgs e)
    {
        EventHandler<ChangedEventArgs> handler = this.Updated;
        if (handler != null) handler(this, e);

    }
    protected virtual void OnRemoved(ChangedEventArgs e)
    {
        EventHandler<ChangedEventArgs> handler = this.Removed;
        if (handler != null) handler(this, e);

    }
    public void Add(int value)
    {
        this.list.Add(value);

        Get();

    }

    public void Get() {
        foreach (int l in this.list)
        {
            Console.WriteLine(l);
        }
        Console.WriteLine();
    }
    public void Set(List<int> value)
    {
        this.list = value;
    }
    public void RemoveAt(int value) => this.list.RemoveAt(value);
     
}

public class ChangedEventArgs : EventArgs
{
    public int Value { get; set; }

    public ChangedEventArgs(int value)
    {
        this.Value = value;
    }
}