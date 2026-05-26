public class MyStack {
    private Queue<int> curStack;

    public MyStack() {
        curStack = new Queue<int>();
        curStack.Enqueue(11);
    }
    
    public void Push(int x) {
        while (curStack.Peek() != 11) {
            curStack.Enqueue(curStack.Dequeue());
        }
        curStack.Enqueue(x);
        curStack.Enqueue(curStack.Dequeue());
    }
    
    public int Pop() {
        int temp = curStack.Peek();
        while (curStack.Peek() != 11) {
            temp = curStack.Dequeue();
            if (curStack.Peek() != 11) {
                curStack.Enqueue(temp);
            }
        }
        curStack.Enqueue(curStack.Dequeue());
        return temp;
    }
    
    public int Top() {
        int temp = curStack.Peek();
        while (curStack.Peek() != 11) {
            temp = curStack.Dequeue();
            curStack.Enqueue(temp);
        }
        curStack.Enqueue(curStack.Dequeue());
        return temp;
    }
    
    public bool Empty() {
        return (curStack.Peek() == 11);
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */