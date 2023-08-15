namespace Delegate
{
    public class PersonFullNameReverse
    {
        public static string GetPersonFullName(Person person)
        {
            return $"{person.LastName} {person.FirstName}";
        }
    }
}
