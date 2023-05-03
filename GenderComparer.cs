#pragma warning disable
public class GenderComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return x.Gender.CompareTo(y.Gender);
    }
}