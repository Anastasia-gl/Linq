namespace Linq.Services.Delegates
{
    internal class Class1
    {
        public Func<int, int, int> forSum;

        private int _result;

        public event Func<int, int, int> SumEvent;

        private int Sum(int a, int b) => a + b;

        public Class1()
        {
            forSum = Sum;
        }

        public void Method(Func<int, int, int> someEvent)
        {
            try
            {
             _result = SumEvent.Invoke(someEvent(7,7), someEvent(7,8));

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(_result);
            }
        }
    }
}
