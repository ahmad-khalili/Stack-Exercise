using System.Drawing;

namespace StackExercise;

public class MyStack<T>
{
    private List<T> _myStack;

    public MyStack()
    {
        _myStack = new List<T>();
    }
}