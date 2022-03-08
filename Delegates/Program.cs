using Delegates;

List<string> names = new List<string>() { "Luke", "Amy", "Ronan", "Dan", "Joe" };
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

//names.RemoveAll(Filter);

//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}


//bool Filter(string name)
//{
//    return name.Contains("A");
//}



Person p1 = new Person() { Name = "Smith", Age = 34 };
Person p2 = new Person() { Name = "Craven", Age = 22 };
Person p3 = new Person() { Name = "Hooker", Age = 54 };
Person p4 = new Person() { Name = "Alta", Age = 12 };
List<Person> list = new List<Person>() { p1, p2, p3, p4 };



// functions

void DisplayPeople(string title, List<Person> person, FilterDelegate filter)
{
    foreach (Person person2 in person)
    {
        if (filter(person2))
        {
            Console.WriteLine("{0} - {1}",person2.Name, person2.Age);
        }
    }
}

DisplayPeople("Mr", list, Over20);
Console.WriteLine("----------");
DisplayPeople("Mr", list, Contains);

bool Over20(Person person)
{
    return person.Age > 20;
}
bool Over50(Person person)
{
    return person.Age > 50;
}
bool Contains(Person person)
{
    return person.Name.Contains("a");
}

public delegate bool FilterDelegate(Person p);