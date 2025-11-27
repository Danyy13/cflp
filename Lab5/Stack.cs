class EmptyStackException : ApplicationException
{
    public EmptyStackException(string message) : base(message) { }
}

public class Stack<T>
{
    private List<T> stack = new List<T>();
    private int stackPointer = -1;

    public bool isEmpty()
    {
        return stackPointer == -1;
    }

    public void Push(T item)
    {
        this.stack.Add(item);
        stackPointer++;
    }

    public T Pop()
    {
        T temp = this.stack.Last();
        if(temp == null)
        {
            throw new EmptyStackException("Stack is empty\n");
        }
        this.stack.RemoveAt(this.stackPointer);
        stackPointer--;
        return temp;
    }

    public bool TryPop(out T item)
    {
        item = default(T); // valoarea default de la tipul de date, un fel de null
        if (this.isEmpty()) return false;
        item = this.Pop();
        return true;
    }

    public T Peek()
    {
        return this.stack.Last();
    }

}