namespace CSharpLeetCode
{
    public class Table
    {
        private int _id;
        private readonly Dictionary<int, string[]> _rows = new();

        public void InsertRow(string[] values)
        {
            _rows.Add(++_id, values);
        }

        public void DeleteRow(int rowId)
        {
            _rows.Remove(rowId);
        }
        
        public string SelectCell(int rowId, int columnId)
        {
            return _rows[rowId][columnId - 1];
        }
    }

    public class SQL
    {
        private readonly IDictionary<string, Table> _tables = new Dictionary<string, Table>();
        
        public SQL(IList<string> names, IList<int> columns) 
        {
            foreach (string name in names)
            {
                if (!_tables.ContainsKey(name))
                {
                    _tables.Add(name, new Table());
                }
            }
        }
    
        public void InsertRow(string name, IList<string> row) 
        {
            _tables[name].InsertRow(row.ToArray());
        }
    
        public void DeleteRow(string name, int rowId) 
        {
            _tables[name].DeleteRow(rowId);
        }
    
        public string SelectCell(string name, int rowId, int columnId)
        {
            return _tables[name].SelectCell(rowId, columnId);
        }
    }
}