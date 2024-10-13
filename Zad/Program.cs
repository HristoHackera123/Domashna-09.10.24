namespace Zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 9; i++)
            {
                list.Add(rnd.Next(-30, 30));
            }
            Console.WriteLine("     Original List: ");
            DisplayList(list);
            Console.WriteLine("     Sorted List:");
            SortList(list);
            DisplayList(list);
            Console.WriteLine("     Filtered List:");
            DisplayList(FilterList(list));

        }
        static void DisplayList(List<int> list)
        {
            
            Console.WriteLine(string.Join(", ", list));
        }
        static void SortList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int index = i;
                int key = list[i];
                while (index > 0 && list[index - 1] >= key)
                {
                    list[index] = list[index - 1];
                    index--;
                }
                list[index] = key;
            }
        }
        static List<int> FilterList(List<int> list)
        {
            return list.Where(x => x > 0 || x % 2 == 0).ToList();
            //for (int i = list.Count - 1; i >= 0; i--)
            //{
            //    if (list[i] < 0 && list[i] % 2 != 0)
            //    {
            //        list.Remove(list[i]);
            //    }
            //}
        }
    }
}
