﻿#pragma warning disable
public class AgeComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return x.Age().CompareTo(y.Age());
    }
}