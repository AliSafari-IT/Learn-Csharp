# Understanding Stacks

* **LIFO Principle:** Stacks work on the "Last In, First Out" (LIFO) principle. Think of a stack of plates– the last plate you put on top is the first one you take off.
* **Key Operations:**
  * **Push:** Add an element to the top of the stack.
  * **Pop:** Remove and return the top element of the stack.
  * **Peek:** View the top element without removing it.

## Project: Implementing a C# Stack

### Option 1: Using a Basic Array

This is good for understanding the underlying concept:

```csharp
namespace StackExample
{
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
}
```

### Option 2: Using the built-in `List<T>`

This utilizes C#'s existing dynamic list-like data structure:

```csharp
namespace StackExample
{
    class ListStack<T>  // Using generics for flexibility
    {
        private List<T> data; 

        public ListStack() 
        {
            data = new List<T>(); 
        }

        public void Push(T item) 
        {
            data.Add(item); 
        }

        // ... Implement Pop() and Peek() using List's methods ...
    }
}
```

## Using Your Stack (in Program.cs)

```csharp
// ... (rest of your Program.cs)

static void Main(string[] args)
{
    MyStack stack = new MyStack(10);  // Using the array-based option
    stack.Push(5);
    stack.Push(10); 
    // ...  
}
```

## Next Steps

1. **Complete the Stack:** Implement the `Pop()` and `Peek()` methods as well as potential error handling (e.g., trying to Pop from an empty stack).
2. **Test:** Create a `Main` function and thoroughly test your stack by adding and removing elements.
3. **Consider Linked List Implementation:** Once comfortable, learn about linked lists and try implementing a stack using a linked list for a different way to tackle the problem.
