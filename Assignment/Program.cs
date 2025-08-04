
namespace Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Range
            Range<int> range = new Range<int>(minimum: 5, maximum: 10);

            //Console.WriteLine(range.IsInRange(9));
            Console.WriteLine(range.Length());

            #endregion
        }

    }
}
