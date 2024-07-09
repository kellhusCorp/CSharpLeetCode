namespace CSharpLeetCode
{
    public class FirstUniqueNumberSolution
    {
        private Dictionary<int, bool> _dict = new Dictionary<int, bool>();
        private LinkedList<int> _unique = new LinkedList<int>();
        private const int UndefinedValue = -1;

        public FirstUniqueNumberSolution(int[] nums) 
        {
            foreach (int num in nums)
            {
                Add(num);
            }
        }
    
        public int ShowFirstUnique()
        {
            while (_unique.Any() && !_dict[_unique.First.Value])
            {
                _unique.RemoveFirst();
            }
            
            return _unique.First?.Value ?? -1;
        }
    
        public void Add(int value)
        {
            if (!_dict.ContainsKey(value))
            {
                if (_unique.First == null)
                {
                    _unique.AddFirst(value);
                }
                else
                {
                    _unique.AddAfter(_unique.Last, value);
                }
                
                _dict[value] = true;
            }
            else
            {
                _dict[value] = false;
            }
        } 
    }
}