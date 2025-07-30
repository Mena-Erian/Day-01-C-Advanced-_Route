using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override bool Equals(object? obj)
        {
            Employee? other = (Employee?)obj; // Unsafe Casting: Compiler Can't Enforce Type Safety [My Throw Execption "InvalidCastException"]
            
            if(other == null) return false;
            
            return (this.Id == other.Id) && (this.Name == other.Name) && (this.Salary == other.Salary);
        }

        public override int GetHashCode()
        {
            //return base.GetHashCode(); // Should Implement it to Generate Hash Code Based in State like Equal()
        
            return HashCode.Combine(this.Id,this.Name, this.Salary); // Now Generate based Based in State
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
}
