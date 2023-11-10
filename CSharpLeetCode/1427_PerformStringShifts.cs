namespace CSharpLeetCode
{
    public class PerformStringShiftsSolution 
    {
        public string StringShift(string s, int[][] shift)
        {
            var array = s.ToCharArray();

            return new string(shift.Aggregate(array, (current, subArray) => subArray[0] == 0
                ? LeftShift(current, subArray[1])
                : RightShift(current, subArray[1])));
        }

        // this is non-optimal way
        public static char[] LeftShift(char[] array, int amount)
        {
            var result = new List<char>();
            result.AddRange(array.TakeLast(array.Length - amount % array.Length));
            result.AddRange(array.Take(amount % array.Length));
            return result.ToArray();
        }

        public static char[] RightShift(char[] array, int amount)
        {
            var result = new List<char>();
            result.InsertRange(0, array.TakeLast(amount % array.Length));
            result.AddRange(array.Take(array.Length - amount % array.Length));
            return result.ToArray();
        }
    }
}