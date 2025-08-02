using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : IEquatable<Employee>, IComparable<Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Employee() { }
        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        #region Object Methods
        public override string ToString()
        {
            return $"Id = {this.Id},Name = {this.Name}, Salary = {this.Salary:C}";
        }
        ///public override bool Equals(object? obj)
        ///{
        ///    Employee? other = (Employee?)obj; // Unsafe Casting: Compiler Can't Enforce Type Safety [My Throw Execption "InvalidCastException"]
        ///    if (other == null) return false;
        ///
        ///    //return base.Equals(obj); // if using hashtable > should override
        ///    return (this.Id == other.Id) && (this.Name == other.Name) && (this.Salary == other.Salary);
        ///    ///----------------------------------------------------------
        ///
        ///    //Employee? other;
        ///
        ///
        ///    // 1. is Operator
        ///    /// if (obj is Employee other)
        ///    /// {
        ///    ///     return (this.Id == other.Id) && (this.Name == other.Name) && (this.Salary == other.Salary);
        ///    /// }
        ///    /// return false;
        ///
        ///
        ///    // 2. as Operator
        ///    /// Employee? other = obj as Employee; // return null if casting is fail
        ///    /// if (other == null) return false;
        ///    /// return (this.Id == other.Id) && (this.Name == other.Name) && (this.Salary == other.Salary);
        ///
        ///}
        public bool Equals(Employee? other)
        {
            if (other == null) return false;
            return (this.Id == other.Id) && (this.Name == other.Name) && (this.Salary == other.Salary);
        }
        public override int GetHashCode()
        {
            //return base.GetHashCode(); // Should Implement it to Generate Hash Code Based in State like Equal()

            //return HashCode.Combine(this.Id,this.Name, this.Salary); // Now Generate based Based in State

            /// // not the best it make conflit if i h
            /// Employee emp01 = new Employee(10, "Mena", 1000);
            /// Employee emp02 = new Employee(1000, "Mena", 10);
            /// // those it will return the same Value so it not valid for me
            /// //return this.Id.GetHashCode() + this.Name?.GetHashCode() ?? default(int) + this.Salary.GetHashCode();
            /// //return this.Id.GetHashCode() ^ this.Name?.GetHashCode() ?? default(int) ^ this.Salary.GetHashCode();

            /// int hashValue = 11;
            /// hashValue = (hashValue * 7) ^ /*+*/ Id.GetHashCode(); // 87
            /// hashValue = (hashValue * 7) ^ /*+*/ Name?.GetHashCode() ?? default(int); // 609 + 41 = 650
            /// hashValue = (hashValue * 7) ^ /*+*/ Salary.GetHashCode(); // 4550 + 1000 = 5550 
            /// return hashValue;

            //return base.GetHashCode(); // if using hashtable > should override
            return HashCode.Combine(this.Id, this.Name, this.Salary); // Now Generate based Based in State

        }
        #endregion

        public int CompareTo(Employee? other)
        {
            if (other == null) return 1;
            return this.Salary.CompareTo(other.Salary);
        }

        /// public static bool operator ==(Employee left, Employee right)
        /// {
        ///     /// Struct is Value Type and they inheret from object, 
        ///     ///                  So Value Type it make override for to methods in Object
        ///     ///                  GetHashCode & (Equals => To Make it Compare based on State not Ref)
        ///     return left.Equals(right); 
        ///    //return (left.Id == right.Id) && (left.Name == right.Name) && (left.Salary == right.Salary);
        /// }
        /// public static bool operator !=(Employee left, Employee right)
        /// {
        ///     return !left.Equals(right);
        ///     //return (left.Id != right.Id) && (left.Name != right.Name) && (left.Salary != right.Salary);
        /// }
    }

    class EmployeeEqualityComparerByName : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Name == y?.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }
    class EmployeeEqualityComparerById : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Id == y?.Id;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Id);
        }
    }
    class EmployeeComparerBySalary : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            //if (x == null) return 1;
            //return x.Salary.CompareTo(y.Salary);
            return x?.Salary.CompareTo(y?.Salary ?? 0) ?? (y is null ? 0 : -1);
        }
    }
    class EmployeeComparerByName : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {

            return x?.Name?.CompareTo(y?.Name) ?? (y is null ? 0 : -1);
        }
    }

}
