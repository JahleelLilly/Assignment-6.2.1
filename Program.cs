namespace Assignment_6._2._1
{
    class Stack
    {
        private int[] data;
        private int top = -1;

        public Stack(int capacity)
        {
            data = new int[capacity];
        }

        public void Push(int value)
        {
            if (top < data.Length - 1)
                data[++top] = value;
        }

        public int Pop()
        {
            return top >= 0 ? data[top--] : -1;
        }
    }

    class Program
    {
        static void Main()
        {
            var stack = new Stack(5);
            stack.Push(10);
            stack.Push(20);

            int poppedValue1 = stack.Pop();
            int poppedValue2 = stack.Pop();

            Console.WriteLine($"Popped values: {poppedValue1}, {poppedValue2}");
        }
    }
}