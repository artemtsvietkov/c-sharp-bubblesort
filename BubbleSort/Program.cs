public class Program
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList
    {
        public Node Head;

        public LinkedList()
        {
            Head = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = Head;
            Head = newNode;
        }

        public void PrintList()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void BubbleSort()
        {
            if (Head == null) return;

            bool swapped;
            do
            {
                swapped = false;
                Node current = Head;
                Node prev = null;

                while (current != null && current.Next != null)
                {
                    if (current.Data > current.Next.Data)
                    {
                        if (prev == null)
                        {
                            Node temp = current.Next;
                            current.Next = temp.Next;
                            temp.Next = current;
                            Head = temp;
                        }
                        else
                        {
                            Node temp = current.Next;
                            prev.Next = temp;
                            current.Next = temp.Next;
                            temp.Next = current;
                        }

                        swapped = true;
                    }

                    prev = current;
                    current = current.Next;
                }
            } while (swapped);
        }
    }

    public static void Main()
    {
        Random random = new Random();
        LinkedList list = new LinkedList();


        // automatisk generering av tal som ska sorteras 

        for (int i = 0; i < 5; i++)
        {
            int randomNumber = random.Next(1, 101); 
            list.Add(randomNumber);
        }

        Console.WriteLine("Before sorting:");
        list.PrintList();

        list.BubbleSort();

        Console.WriteLine("After sorting:");
        list.PrintList();
    }
}
