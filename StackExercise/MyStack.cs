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
}