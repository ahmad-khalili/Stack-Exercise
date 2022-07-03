using System.Drawing;

namespace StackExercise;

public class MyStack<T>
{
    private List<T> _myStack;

    public MyStack()
    {
        _myStack = new List<T>();
    }
    
    public void Push(T item)
    {
        _myStack.Add(item);
    }
    
    public T? Pop()
    {
        if (_myStack.Count > 0)
        {
            var lastItemIndex = _myStack.Count - 1;
            var lastItem = _myStack.ElementAt(lastItemIndex);
            _myStack.RemoveAt(lastItemIndex);
            return lastItem;
        }
        else
        {
            Console.WriteLine("Stack is empty!");
            return default;
        }
    }
}