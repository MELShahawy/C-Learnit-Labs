using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_EMP
{
    public class Employees
    {
        #region NOTES
        /// any datat inside class/struct -> member
        /// member can be accessed by object name  
        /// public: member can be accessed inside/outside class or struct
        /// private [default]: member can be accessed inside class/struct only!!!
        #endregion

        #region Data Fields

        // Data fields 
        int id;
        string name;
        int age;
        decimal salary;
        #endregion

        #region Setters & Getters 
        // must be public [GATES]
        public void SetId(int _id)
        {
            id = _id;
        }
        public void SetName(string _name)
        {
            name = _name;
        }
        public void SetAge(int _age)
        {
            age = _age;
        }
        public void SetSalary(decimal _salary)
        {
            salary = _salary;
        }

        public int GetId()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public decimal GetSalary()
        {
            return salary;
        }
        #endregion
        #region Function to print OBJECT
        public void PrintV1()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(salary);
        }
        //recommended
        public string PrintV2()
        {
            return $"{id}: {name}: {age}: {salary}";
        }
        /// The V2 is better because 1, can be passed, 2, doesn't depend on "CONSOLE" orders           
        #endregion
    }
}