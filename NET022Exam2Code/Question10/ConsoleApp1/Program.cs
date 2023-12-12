namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Dictionary<string, string> d;

        }


        public class GenericClass<T> where T:struct
        {

            private List<T> collection;

            public GenericClass()
            {
                collection = new List<T>();
            }
            public void AddItem(T item)
            {
                collection.Add(item);

            }
            public T GetItem(int index)
            {
                try
                {
                    return collection[index];
                }
                catch
                {
                    throw new IndexOutOfRangeException();
                }
            }

            public IList<T> GetSorted()
            {
                var sortedC = new List<T>();
                collection.AddRange ( sortedC);
                sortedC.Sort();
                return sortedC;
            }
        }



    }
}