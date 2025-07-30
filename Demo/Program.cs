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

            /// int[] Numbers = { 54654665, 52, 656, 156,8, 4981, 3498, 3289, 238, 6298, 2, 3, 65, 8654 };
            /// 
            /// int result = Helper<int>.LinarSearch(Numbers, 8);
            /// Console.WriteLine(result);

            /// Employee E01 = new Employee(1, "Mena", 5000);
            /// Employee E02 = new Employee(1, "Mena", 5000);
            /// //Employee E02 = new Employee(2, "any", 1000);
            /// 
            /// 
            /// // E01.GetHashCode() by Default(With Class) Based on ref(ther Place in Heap)
            /// Console.WriteLine($"E01.GetHashCode() => {E01.GetHashCode()}");
            /// Console.WriteLine($"E02.GetHashCode() => {E02.GetHashCode()}");
            /// 
            /// 
            /// /// == and Equals() in Class by Default reference Based Equalte
            /// 
            /// //if (E01 == E02) // Ref By Defult (Class (ref Type))
            /// if (E01.Equals(E02)) // State
            ///     Console.WriteLine("EQUAL");
            /// else
            ///     Console.WriteLine("NOT EQUAL");

            /// Employee[] employees = {
            ///     new Employee(10,"Mena",8_000),
            ///     new Employee(20,"Hamada",8_000),
            ///     new Employee(30,"Omnia",5_000),
            ///     new Employee(40,"Shref",2_000),
            ///     new Employee(50,"Adel",9_000),
            /// };
            /// 
            /// int index = Helper<Employee>.LinarSearch(employees, new Employee(20, "Hamada", 8_000));
            /// Console.WriteLine($"index = {index}");
        }
    }
}
