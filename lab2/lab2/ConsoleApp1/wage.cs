using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class wage : employee
    {
        double rate;
        double hours;
        double weeklyPay;
        public wage(String id, String name, String address, String phone, long sin, double rate)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.SIN = sin;
            this.rate = rate;
        }
        public void setHours(double hours)
        {
            this.hours = hours;
        }
        public override double calculatePay()
        {
            if (this.hours > 40)
            {
                this.weeklyPay = 40 * this.rate;
                double hours = this.hours - 40;
                this.weeklyPay = this.weeklyPay + 1.5 * hours * this.rate;
                return this.weeklyPay;
            }
            else
            {
                this.weeklyPay = this.hours * this.rate;
                return this.weeklyPay;
            }
        }
    }
}
