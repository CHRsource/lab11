#pragma warning disable
// 1 задание

//a
//void Swap<T>(T[] array, int i1, int i2)
//{
//    T temp = array[i1];
//    array[i1] = array[i2];
//    array[i2] = temp;
//}

//int[] intarr = { 1, 2, 3 };
//Swap(intarr, 0, 2);
//for (int i = 0; i < intarr.Length; i++)
//    Console.Write(intarr[i] + " ");
//Console.WriteLine();

//double[] doublearr = { 1.0, 2.0, 3.0 };
//Swap(doublearr, 1, 2);
//for (int i = 0; i < doublearr.Length; i++)
//    Console.Write(doublearr[i] + " ");
//Console.WriteLine();

//string[] stringarr = { "hello", "world", "C#" };
//Swap(stringarr, 0, 1);
//for (int i = 0; i < stringarr.Length; i++)
//    Console.Write(stringarr[i] + " ");
//Console.WriteLine();

//Person[] personarr = { new Person("Иван", "Иванов", new DateTime(2000, 1, 1), 'М'),
//        new Person("Петр", "Сидоров", new DateTime(2010, 5, 30), 'М'),
//        new Person("Абдуллина", "Карина", new DateTime(2002, 6, 13), 'Ж') };
//Swap(personarr, 0, 2);
//for (int i = 0; i < personarr.Length; i++)
//    personarr[i].Print();


// b)
//T[] Remove<T>(T[] a, int i)
//{
//    T[] array = new T[a.Length - 1];
//    Array.Copy(a, array, i);
//    Array.Copy(a, i + 1, array, i, a.Length - i - 1);
//    return array;
//}

//int[] intarr = { 1, 2, 3, 4, 5, 6 };
//int[] int_new = Remove(intarr, 3);
//for (int i = 0; i < int_new.Length; i++)
//    Console.Write(int_new[i] + " ");
//Console.WriteLine();

//double[] doublearr = { 1.0, 2.0, 3.0 };
//double[] double_new = Remove(doublearr, 1);
//for (int i = 0; i < double_new.Length; i++)
//    Console.Write(double_new[i] + " ");
//Console.WriteLine();

//string[] stringarr = { "hello", "world", "C#" };
//string[] string_new = Remove(stringarr, 0);
//for (int i = 0; i < string_new.Length; i++)
//    Console.Write(string_new[i] + " ");
//Console.WriteLine();

//Person[] personarr = { new Person("Иван", "Иванов", new DateTime(2000, 1, 1), 'М'),
//        new Person("Петр", "Сидоров", new DateTime(2010, 5, 30), 'М'),
//        new Person("Абдуллина", "Карина", new DateTime(2002, 6, 13), 'Ж') };
//Person[] person_new = Remove(personarr, 2);
//for (int i = 0; i < person_new.Length; i++)
//    person_new[i].Print();


// задание 2

// a)
//Person p1 = new("Кристина", "Иванова", new DateTime(2003, 12, 11), 'ж');
//Person p2 = new("Азат", "Абзалов", new DateTime(2005, 2, 2), 'м');
//Console.WriteLine(p1.CompareTo(p2));
//Console.WriteLine(p2.CompareTo(p1));
//Console.WriteLine(p1.CompareTo(p1));

//Person[] people = { new Person(p1.FirstName, p1.LastName, p1.BirthDay, p1.Gender),
//    new Person(p2.FirstName, p2.LastName, p2.BirthDay, p2.Gender),
//    new Person("Яна", "Павловская", new DateTime(1983, 2, 9), 'ж') };
//Array.Sort(people);
//foreach (Person p in people)
//{
//    p.Print();
//    Console.WriteLine();
//}
//Console.WriteLine("Максимальный элемент массива");
//FindMax(people).Print();
//static Person FindMax(Person[] people)
//{
//    Person max = people[0];
//    for (int i = 1; i < people.Length; i++)
//    {
//        if (people[i].CompareTo(max) > 0)
//            max = people[i];
//    }
//    return max;
//}


// b)
//Person[] people = { new Person("Кристина", "Иванова", new DateTime(2003, 12, 11), 'ж'),
//    new Person("Азат", "Абзалов", new DateTime(2005, 2, 2), 'м'),
//    new Person("Яна", "Павловская", new DateTime(1983, 2, 9), 'ж'),
//    new Person("Валентин", "Суханов", new DateTime(1941, 5, 25), 'м') };
//Array.Sort(people, new AgeComparer());
//Console.WriteLine("Сортировка по возрасту");
//foreach (Person p in people)
//    p.Print();
//Array.Sort(people, new GenderComparer());
//Console.WriteLine("\nСортировка по полу");
//foreach (Person p in people)
//    p.Print();

//Person maxperson = GetMax<Person>(people, new AgeComparer());
//Console.WriteLine("\nМаксимальное значение по возрасту");
//maxperson.Print();
//maxperson = GetMax<Person>(people, new GenderComparer());
//Console.WriteLine("\nМаксимальное значение по полу");
//maxperson.Print();
//static T GetMax<T>(T[] array, IComparer<T> comparer)
//{
//    T max = array[0];
//    for (int i = 1; i < array.Length; i++)
//    {
//        if (comparer.Compare(array[i], max) > 0)
//            max = array[i];
//    }
//    return max;
//}


// задание 3

//MyPair<string, int> pair1 = new("привет", 5);
//Console.WriteLine(pair1[0] + " " + pair1[0].GetType());
//Console.WriteLine(pair1[1] + " " + pair1[1].GetType());
//MyTriple<string, double, char> triple1 = new("пока", 13.156, 'Ж');
//Console.WriteLine(triple1[0] + " " + triple1[0].GetType());
//Console.WriteLine(triple1[1] + " " + triple1[1].GetType());
//Console.WriteLine(triple1[2] + " " + triple1[2].GetType());


// задание 4

DoublyLinkedList linkedlist = new();
Console.WriteLine("Вводите целые числа:");
while (true)
{
    string s = Console.ReadLine();
    if (s == "") break;
    if (linkedlist.Count < 2)
        linkedlist.Add(int.Parse(s));
    else if (Math.Abs(int.Parse(s) - linkedlist.HeadData) < Math.Abs(int.Parse(s) - linkedlist.TailData))
        linkedlist.AddFirst(int.Parse(s));
    else linkedlist.Add(int.Parse(s));
}
Console.WriteLine("Размер: " + linkedlist.Count);
Console.WriteLine("Список: " + linkedlist.ToString());

DoublyLinkedListG<string> list2 = new();
Console.WriteLine("Вводите строчки:");
while (true)
{
    string s = Console.ReadLine();
    if (s == "") break;
    list2.Add(s);
}
Console.WriteLine("Размер: " + list2.Count);
Console.WriteLine("Список: " + list2.ToString());
