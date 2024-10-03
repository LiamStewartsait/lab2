using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class employee
    {
        protected String id;
        protected String name;
        protected String address;
        protected String phone;
        protected long SIN;

        public employee() 
        {
            id = string.Empty;
            name = string.Empty;
            address = string.Empty;
            phone = string.Empty;
            SIN = 0;
        }
        public employee(String id, String name, String address, String phone, long sin)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.SIN = sin;
        }
        public virtual double calculatePay()
        {
            return 0;
        }
        public string getName() { return this.name; }
        public string getID() { return this.id; }

    }
}
