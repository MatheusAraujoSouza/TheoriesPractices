namespace WorkerService.Domain.interfaces
{
    public class Triple<T1, T2, T3> : ITripleOperations<T1, T2, T3>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }
        public T3 Third { get; set; }

        public Triple(T1 first, T2 second, T3 third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public void PrintTriple(Triple<T1, T2, T3> triple)
        {
            Console.WriteLine($"First: {First}, Second: {Second}, Third: {Third}");
        }

        public Triple<T3, T2, T1> Reverse(Triple<T1, T2, T3> triple)
        {
            return new Triple<T3, T2, T1>(Third, Second, First);
        }
    }

}