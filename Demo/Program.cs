namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic SWAP - Example 01
            /// int A = 3, B = 5;
            /// Console.WriteLine($"A = {A}");
            /// Console.WriteLine($"B = {B}");
            /// Helper.Swap/*<int>*/(ref A, ref B);
            /// Console.WriteLine($"A = {A}");
            /// Console.WriteLine($"B = {B}");
            /// 
            /// Point P01 = new Point(10, 20);
            /// Point P02 = new Point(50, 60);
            /// Console.WriteLine($"P01 = {P01}");
            /// Console.WriteLine($"P02 = {P02}");
            /// Helper.Swap<Point>(ref P01, ref P02);
            /// Console.WriteLine($"P01 = {P01}");
            /// Console.WriteLine($"P02 = {P02}");

            /// object A = 3, B = 5; // Boxing
            /// Console.WriteLine($"A = {A}");
            /// Console.WriteLine($"B = {B}");
            /// Helper.Swap(ref A, ref B);
            /// Console.WriteLine($"A = {A}");
            /// Console.WriteLine($"B = {B}");

            /// Point P01 = new Point(10, 20);
            /// Point P02 = new Point(50, 60);
            /// Console.WriteLine($"P01 = {P01}");
            /// Console.WriteLine($"P02 = {P02}");
            /// Helper.Swap(ref P01, ref P02);
            /// Console.WriteLine($"P01 = {P01}");
            /// Console.WriteLine($"P02 = {P02}"); 
            #endregion
        
            
        }
    }
}
