namespace _0420_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStructure.List<int> list1 = new DataStructure.List<int>();
            DataStructure.LinkedList<int> list2 = new DataStructure.LinkedList<int>();
            for(int i = 0; i < 3; i++)
            {
                list1.Add(i);
                list2.AddLast(i);
            }

            foreach(int i in list1)
            {
                Console.WriteLine(i);
            }
            foreach(int i in list2)
            {
                Console.WriteLine(i);
            }

        }
    }
}