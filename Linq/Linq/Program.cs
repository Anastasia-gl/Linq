namespace Linq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var class1 = new Services.Delegates.Class1();
            class1.SumEvent += class1.forSum;
            
            class1.Method(class1.forSum);

            var run = new Run();
            run.Start();
        }
    }
}
