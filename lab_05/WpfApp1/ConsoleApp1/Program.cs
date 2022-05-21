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

        list.Add(1);
        list.Add(1);
        list.Add(1);
        //list.Add(+1);
    }
}

public class ObservableList1
{
    private List<int> list = new List<int>();

    public event EventHandler<ChangedEventArgs> Added;
    public event EventHandler<ChangedEventArgs> Updated;
    public event EventHandler<ChangedEventArgs> Removed;

    protected virtual void OnChanged(ChangedEventArgs e) 
    {
        EventHandler<ChangedEventArgs> Adder = this.Added;
        if (Adder != null) Adder(this, e);

        EventHandler<ChangedEventArgs> Updater = this.Updated;
        if (Updater != null) Updater(this, e);

        EventHandler<ChangedEventArgs> Remover = this.Removed;
        if (Remover != null) Remover(this, e);

    }

    public void Add(int value)
    {
        this.list.Add(value);

        Get();

    }

    public void Get() {
        //foreach (int l in this.list)
        //{
        //    Console.WriteLine(l);
        //}
        for(int i = 0; i < this.list.Count; i++)
        {
            Console.WriteLine(this.list[i]);
        }
    }
    public void Set() { }
    public void RemoveAt(int value) { }
     public int this[int index] {
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
}

public class ChangedEventArgs : EventArgs
{
    public int Value { get; set; }

    public ChangedEventArgs(int value)
    {
        this.Value = value;
    }
}