namespace binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**||Binary Tree||**");

            bool b = true;
            BinaryTree test = new BinaryTree();

            while (b == true)
            {

                Console.WriteLine("Wollen Sie einen Wert hinzufügen[true] oder die liste ausgeben[false] aka programm beenden?");
                b = Convert.ToBoolean(Console.ReadLine());

                if (b == true)
                {
                    Console.Write("Fügen Sie einen Wert hinzu:");
                    int input = Convert.ToInt32(Console.ReadLine());
                    
                    test.ADD(new Node(input));
                }
                else
                {
                    Console.WriteLine(test.ToString());
                    b = false;
                }
            }
        }
    }
}
