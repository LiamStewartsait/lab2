using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
           //I suppose i could have actually read from the file to do this
           //but it doesn't say we need to and im lazy

            salaried Sam = new salaried("1234987", "Sam Packitaway", "345 Stash Road, Piles, Alot", "(660) 546 - 9867", 999888777, 25675);
            salaried Drevil = new salaried("0999999", "Dr.Evil", "Some Where in the Caribean", "(999) 999 - 9999", 98989898,1000000);
            salaried Samuel = new salaried("217546", "Samuel Ludlow III", "2345 The Rich Man Way, RichVille, RC", "(567) 324-9812", 768956453, 20500);

            wage Fred = new wage("634567", "Fred Flintstone", "34 Flintrock Way, Bedrock, BC", "(345) 295-9076", 678453234, 27.85);
            wage Bob = new wage("54153", "BobBob Never", "22 NeverReally Lane, Neverland", "(234) 674-7865", 98765678, 30.60);
            wage Winnie = new wage("775342", "Winnie Van Winnipeg", "100 Aker Wood West, Winnipeg", "(999) 555-8888", 234777444, 28.45);
            wage Elle = new wage("5489867", "Elle Driver", "32 Mountain Drive, Los Angeles", "(765) 456-7766", 765098345, 40.25);

            part_time Bill = new part_time("86595", "Bill Partley", "11 Partway Road, Almost, NW", "(111) 232-9876", 876345987, 20.55);
            part_time Perky = new part_time("9536476", "Perky Volunteer", "343 Volly Road, Volunteersalot", "(212) 345-9876", 867643782, 16.80);


            Fred.setHours(44);
            Bob.setHours(48);
            Winnie.setHours(38);
            Elle.setHours(52);

            Bill.setHours(18);
            Perky.setHours(22);


            List<employee> list = new List<employee>();

            list.Add(Sam);
            list.Add(Drevil);
            list.Add(Samuel);
            list.Add(Fred); 
            list.Add(Bob);
            list.Add(Winnie);
            list.Add(Elle);
            list.Add(Bill);
            list.Add(Perky);


            double sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum = sum + list[i].calculatePay();
            }

            decimal ave = decimal.Divide((decimal)sum, list.Count);
            string formatedAve = ave.ToString("0.00");
            Console.WriteLine("Average earnings is: $" + formatedAve);

            List<double> pay = new List<double>();

            
            foreach(employee n in list) 
            {

                int tempid = Int32.Parse(n.getID().Substring(0,1));
                if ( tempid > 4 && tempid < 8)
                {
                    pay.Add(n.calculatePay());
                }
               
            }
            double highestWage = pay.Max();

            foreach (employee n in list)
            {
                int tempid = Int32.Parse(n.getID().Substring(0, 1));
                if (tempid > 4 && tempid < 8)
                {


                    if (n.calculatePay() == highestWage)
                    {

                        Console.WriteLine(n.getName() + " makes the most in wages at a total of $" + highestWage);
                        break;
                    }
                }

            }

            pay.Clear();

            foreach (employee n in list)
            {

                int tempid = Int32.Parse(n.getID().Substring(0, 1));
                if (tempid < 5)
                {
                    pay.Add(n.calculatePay());
                }

            }
            double lowestWage = pay.Min();

            foreach (employee n in list)
            {
                int tempid = Int32.Parse(n.getID().Substring(0, 1));
                if (tempid < 5)
                {


                    if (n.calculatePay() == lowestWage)
                    {

                        Console.WriteLine(n.getName() + " makes the least in salary at a total of $" + lowestWage);
                        break;
                    }
                }

            }
            int numofEmploy;

            int loopThrough(int high, int low)
            {
                numofEmploy = 0;
                //hate how foreach is done here compared to have
                //much perfer the collon instead of the in
                foreach (employee n in list)
                {

                    int tempid = Int32.Parse(n.getID().Substring(0, 1));
                    if (tempid > low && tempid < high)
                    {
                        
                        numofEmploy++;

                    }

                }
                return numofEmploy;
            }

            decimal percent = 100*decimal.Divide(loopThrough(5, -1), list.Count);

            string formatedPer = percent.ToString("0.00");

            Console.WriteLine("The Percentage of salaried employees is " + formatedPer + " percent");

            percent = 100 * decimal.Divide(loopThrough(8, 4), list.Count);

            formatedPer = percent.ToString("0.00");

            Console.WriteLine("The Percentage of wage employees is " + formatedPer + " percent");

            percent = 100 * decimal.Divide(loopThrough(10, 7), list.Count);

            formatedPer = percent.ToString("0.00");

            Console.WriteLine("The Percentage of part time employees is " + formatedPer + " percent");


        }

    }





}