namespace Delegate
{
    public class ForAction<TInput>
    {
        public static void NumericToString(TInput a, TInput b, TInput c)
        {
            Console.WriteLine($"this number : {a}-{b}-{c}"); 
        }
    }
}
