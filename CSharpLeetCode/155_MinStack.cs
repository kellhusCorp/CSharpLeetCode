namespace CSharpLeetCode
{
    public class MinStack
    {
        private readonly LinkedList<int> _items = new();
        private readonly LinkedList<int> _mins = new();
    
        public void Push(int val)
        {
            if (!_mins.Any() || val <= _mins.Last.Value) 
            {
                _mins.AddLast(val);
            }
            _items.AddLast(val);
        }
    
        public void Pop()
        {
            if (!_items.Any())
                throw new InvalidOperationException();
            if (_items.Last.Value == _mins.Last.Value)
            {
                _mins.RemoveLast();
            }
            
            _items.RemoveLast();
        }
    
        public int Top()
        {
            if (!_items.Any())
                throw new InvalidOperationException();
            return _items.Last.Value;
        }
    
        public int GetMin()
        {
            return _mins.Any() ? _mins.Last.Value : int.MaxValue;
        }
    }
}