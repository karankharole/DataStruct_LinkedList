namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            linkedList l_Object = new linkedList();
            l_Object.add(56);
            l_Object.add(70);
            l_Object.display();
            l_Object.InsertAtParticularPosition(2, 30);
            l_Object.display();
            l_Object.RemoveFirstNode();
            l_Object.display();
        }
    }
}