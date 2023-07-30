namespace AccessModifier
{
    public class PublicSample
    {
        public int Id { get; set; }
        public string? Name { get; set; }    
    }

    public class ProtectedClass
    {
        protected void print() => Console.WriteLine("protected sample");
    }
    public class PrivateClass
    {
        private void print() => Console.WriteLine("protected sample");

        public PrivateClass()
        {
            print();    
        }
    }

    internal class InternalClass // by this we can just instanciate in this assembly
    {

    }
}