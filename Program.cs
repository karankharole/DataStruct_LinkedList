namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            linkedList l_Object = new linkedList();
            l_Object.Add(56);
            l_Object.Add(36);
            l_Object.Add(70);
            l_Object.Display();
            l_Object.sortList();
            l_Object.Display();
            Console.ReadLine();
        }
    }
}