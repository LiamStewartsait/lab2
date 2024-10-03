using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class salaried : employee
    {
        double salary;
        public salaried(String id, String name, String address, String phone, long sin, double salary)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.SIN = sin;
            this.salary = salary;
        }

        public override double calculatePay()
        {
            return this.salary;

        }
    }
}
