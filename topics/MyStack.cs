class MyStack
    {
        private int[] data;  // Array to store stack elements
        private int top;     // Index of the top element

        public MyStack(int size) 
        {
            data = new int[size];
            top = -1;  // Initially the stack is empty
        }

        public void Push(int item) 
        {
            if (top == data.Length - 1) // Check for overflow
            {
                throw new Exception("Stack overflow"); 
            }
            top++;
            data[top] = item;
        }

        // ... Implement Pop() and Peek() similarly ...
        
    }

     class ListStack<T>  // Using generics for flexibility
    {
        private List<T> data; 

        public ListStack() 
        {
            data = new List<T>(); 
            Console.WriteLine("Using List<T>");
        }

        public void Push(T item) 
        {
            data.Add(item); 
            Console.WriteLine("Pushed " + item);
            Console.WriteLine("Count " + data.Count);
        }

        // ... Implement Pop() and Peek() using List's methods ...
    }