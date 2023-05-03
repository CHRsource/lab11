#pragma warning disable
public class Person : IComparable<Person>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDay { get; set; }
    private char gender;
    public char Gender { get { return gender; } set { if (value == 'ж') gender = value; else gender = 'м'; } }
    public Person() : this("noname", "", new DateTime(), 'м') { }
    public Person(string fn, string sn, DateTime d, char s)
    {
        FirstName = fn;
        LastName = sn;
        BirthDay = d;
        Gender = s;
    }
    public void Print()
    {
        Console.WriteLine("Имя: " + FirstName);
        Console.WriteLine("Фамилия: " + LastName);
        Console.WriteLine("Дата рождения: " + BirthDay);
        Console.WriteLine("Пол: " + Gender);
        Console.WriteLine("Возраст: " + Age());
    }
    public int Age()        // расчет возраста
    {
        int a = DateTime.Today.Year - BirthDay.Year;
        if (BirthDay.Month > DateTime.Today.Month ||
            (BirthDay.Month == DateTime.Today.Month && BirthDay.Day > DateTime.Today.Day))
            a--;
        return a;
    }
    public int CompareTo(Person other)
    {
        return FirstName.CompareTo(other.FirstName);
    }
}
