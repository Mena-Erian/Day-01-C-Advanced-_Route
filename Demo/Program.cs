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

            #region Generic Search - Example 02
            /// int[] Numbers = { 54654665, 52, 656, 156,8, 4981, 3498, 3289, 238, 6298, 2, 3, 65, 8654 };
            /// 
            /// int result = Helper<int>.LinarSearch(Numbers, 8);
            /// Console.WriteLine(result);

            /// Employee E01 = new Employee(1, "Mena", 5000);
            /// Employee E02 = new Employee(1, "Mena", 5000);
            /// //Employee E02 = new Employee(2, "any", 1000);
            /// 
            /// 
            /// // E01.GetHashCode() by Default(With Class) Based on ref(there Place in Heap)
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

            #region Generic Search
            /// Employee[] employees = {
            ///     new Employee(10,"Mena",8_000),
            ///     new Employee(20,"Hamada",8_000),
            ///     new Employee(30,"Omnia",5_000),
            ///     new Employee(40,"Shref",2_000),
            ///     new Employee(50,"Adel",9_000),
            /// };
            /// 
            /// //int index = Helper<Employee>.LinarSearch(employees, new Employee(20, "Hamada", 8_000));
            /// //int index = Helper<Employee>.LinarSearch(employees, new Employee() { Name = "Hamda" });
            /// 
            /// //int index = Helper<Employee>.LinarSearch(employees,
            /// //                                     new Employee() { Name = "Hamada" },
            /// //                                  new EmployeeEqualityComparerByName());
            /// 
            /// //int index = Helper<Employee>.LinarSearch(employees,
            /// //                                     new Employee() { Id = 40 },
            /// //                                  new EmployeeEqualityComparerById());
            /// 
            /// Func<Employee, Employee, bool> equals = delegate (Employee x, Employee y)
            /// {
            /// 
            ///     return x == y;
            /// };
            /// 
            /// //int index = Helper<Employee>.LinarSearch(employees,
            /// //new Employee() { Salary = 2000 },
            /// //delegate (Employee x, Employee y)
            /// //{
            /// //    return x.Salary == y.Salary;
            /// //}
            /// //);
            /// 
            /// int index = Helper<Employee>.LinarSearch(employees,
            ///  new Employee() { Salary = 2000 },
            ///  (Employee x, Employee y) => x.Salary == y.Salary
            /// );
            /// 
            /// 
            /// Console.WriteLine($"index = {index}"); 
            #endregion
            #endregion

            #region Equality (==, Equals) && GetHashCode
            /// // Why Value Types (struct, enum,int, ...)  inheret from valuetype not from object direct?
            /// // becouse value type override 2 methods in Object => Equals(), GetHashCode() to be based on State(value)
            /// 
            /// // Enum it inheret from Enum Class and Enum Class inheret from ValueType Class
            /// 
            /// Employee employee01 = new Employee(10, "Mena", 6_000);
            /// Employee employee02 = new Employee(10, "Mena", 6_000);
            /// 
            /// //if (E01 == E02) // Ref By Defult (Class (ref Type))
            /// if (employee01.Equals(employee02)) // State
            ///     Console.WriteLine("EQUAL");
            /// else
            ///     Console.WriteLine("NOT EQUAL");
            /// 
            /// //int x = 10;
            /// //Console.WriteLine(x.GetHashCode()); // 10 => valuetype so it will generated based on value
            /// 
            /// HashSet<Employee> employees = new HashSet<Employee>();
            /// 
            /// employees.Add(employee01);
            /// employees.Add(employee02);
            /// 
            /// foreach (Employee employee in employees)
            ///     Console.WriteLine(employee);  // if you don't override (Equals(),GetHashCode()) it will output the two event those have the same state    
            /// /// Make Override, Output:                                  
            /// // Id = 10,Name = Mena, Salary = 6000
            /// 
            /// /// don't Override, Output:
            /// // Id = 10,Name = Mena, Salary = 6000
            /// // Id = 10,Name = Mena, Salary = 6000
            #endregion

            #region Sort
            /// double[] Numbers = [9, 4, 10, 6, 2, 8, 5, 1, 3, 7];
            /// 
            /// Helper<double>.BubbleSort(Numbers);
            /// foreach (int i in Numbers)
            /// {
            ///     Console.WriteLine(i);
            /// }
            #endregion

            #region Genaric Sort - Example03
            /// Employee[] employees = {
            ///     new Employee(10, "Mena", 8_000),
            ///     new Employee(20, "Hamada", 8_000),
            ///     new Employee(30, "Omnia", 5_000),
            ///     new Employee(40, "Shref", 2_000),
            ///     new Employee(50, "Adel", 9_000),
            /// };
            /// 
            /// //Helper<Employee>.BubbleSort(employees);
            /// //Helper<Employee>.BubbleSort(employees, new EmployeeComparerBySalary());
            /// //Helper<Employee>.BubbleSort(employees, new EmployeeComparerByName());
            /// Helper<Employee>.BubbleSort(employees, delegate (Employee x, Employee y)
            /// {
            ///     return x.Id.CompareTo(y.Id) == 1;
            /// });
            /// Helper<Employee>.BubbleSort(employees, (Employee x, Employee y) => x.Salary.CompareTo(y.Salary) == -1);
            /// foreach (Employee employee in employees)
            ///     Console.WriteLine(employee); 
            #endregion
        }
    }
}