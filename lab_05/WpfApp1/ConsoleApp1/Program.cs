﻿//https://dirask.com/snippets/cs/C%23+multiple+events+example
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {

        ObservableList1 list = new ObservableList1();

        list.Added += (object sender, ChangedEventArgs e) =>
        {
            Console.WriteLine("Added event occured: value=" + e.Value);
        };

        list.Add(+1);
        list.Add(+1);
        list.Add(+1);
        list.Add(+1);
    }
}

public class ObservableList1
{
    private List<int> list = new List<int>();
    private int value;

    public event EventHandler<ChangedEventArgs> Added;

    protected virtual void OnChanged(ChangedEventArgs e) // <------------------- wraps event (allows to raise the event)
    {
        EventHandler<ChangedEventArgs> handler = this.Added;

        if (handler != null)
            handler(this, e);
    }

    public void Add(int value)
    {
        this.list.Add(value);

        foreach(int l in list)
        {
            Console.WriteLine(l);
        }

        //this.OnChanged(new ChangedEventArgs(this.value));

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