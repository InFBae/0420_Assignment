namespace _0420_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            DataStructure.List<int> list1 = new DataStructure.List<int>();
            DataStructure.LinkedList<int> list2 = new DataStructure.LinkedList<int>();
            for(int i = 0; i < 3; i++)
            {
                list1.Add(i);
                list2.AddLast(i);
            }
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }
            foreach(int i in list2)
            {
                Console.WriteLine(i);
            }
            */

            int[] list1 = { 3, 2, 1 };
            List<int> list2 = new List<int>() { 3, 2, 1 };

            Sort(list1);
            Sort(list2, (a, b) =>  a - b);
            foreach (int i in list1) Console.WriteLine(i);
            foreach (int i in list2) Console.WriteLine(i);

            Console.WriteLine(Average(list1));
        }
        
        public static IEnumerable<T> Sort<T>(IEnumerable<T> source) where T: IComparable<T>
        {
            var list = source.ToList();
            list.Sort();
            return list;
        }

        public static void Sort<T>(IList<T> list, Comparison<T> comparer)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));
            for(int i = 0; i < list.Count; i++)
            {
                for(int j = 0; j < list.Count-1; j++)
                {
                    if (comparer(list[j], list[j+1]) > 0)
                    {
                        T temp = list[j];
                        list[j] = list[j+1];
                        list[j+1] = temp;
                    }
                }
            }
        }

        public static double Average(IEnumerable<int> ints)
        {
            double sum = 0;
            foreach(int i in ints)
            {
                sum += i;
            }
            return sum/ints.Count();
        }

    }
}