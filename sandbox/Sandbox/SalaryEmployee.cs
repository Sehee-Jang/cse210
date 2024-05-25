using System;
using System.Runtime.CompilerServices;

namespace employee_demo
{
    public class SalaryEmployee : Employee
    {
        // Attribute
        private float _salary = 0;

        // Getter & Setter
        public float GetSalary()
        {
            return _salary;
        }

        public void SetSalary(float salary)
        {
            _salary = salary;
        }

        // If it's virtual, you have the option to override it, but if it's abstract, you must override it.
        public override float GetPay()
        {
            return _salary / 12;
        }

    }
}