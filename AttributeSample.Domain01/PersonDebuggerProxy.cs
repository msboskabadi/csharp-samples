namespace AttributeSample.Domain01;

public class PersonDebuggerProxy
{
    private readonly Person _person;
    public PersonDebuggerProxy(Person person)
    {
        _person = person;
    }

    public string FullName => $"{_person.FirstName} {_person.LastName}";
    public int Age => _person.Age;  
}
