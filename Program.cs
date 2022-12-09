namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            linkedList l_Object = new linkedList();

            
            l_Object.add(56);
            l_Object.add(30);
            l_Object.add(70);
            l_Object.SearchNode(70);
            l_Object.display();
        }
    }
}