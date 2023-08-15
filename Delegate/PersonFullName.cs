namespace Delegate
{
    public class PersonFullName
    {
        public static string GetPersonFullName(Person person)
        {
            return $"{person.FirstName} {person.LastName}";
        }
    }
}
