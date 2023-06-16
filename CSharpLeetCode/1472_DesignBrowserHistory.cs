using System.Collections;

namespace CSharpLeetCode;

public class BrowserHistory 
{
    private string _page;

    private readonly Stack<string> _backHistory = new();

    private readonly Stack<string> _forwardHistory = new();

    public BrowserHistory(string homepage)
    {
        _page = homepage;
    }
    
    public void Visit(string url) 
    {
        _backHistory.Push(_page);
        _page = url;
        _forwardHistory.Clear();
    }
    
    public string Back(int steps)
    {
        var min = GetMaximumPossibleOfSteps<int>(_backHistory, steps);
        
        for (int i = 0; i < min; i++)
        {
            _forwardHistory.Push(_page);
            _page = _backHistory.Pop();
        }

        return _page;
    }
    
    public string Forward(int steps)
    {
        var min = GetMaximumPossibleOfSteps<int>(_forwardHistory, steps);
        
        for (int i = 0; i < min; i++)
        {
            _backHistory.Push(_page);
            _page = _forwardHistory.Pop();
        }

        return _page;
    }

    private static int GetMaximumPossibleOfSteps<T>(ICollection stack, int steps)
    {
        return steps > stack.Count ? stack.Count : steps;
    }
}