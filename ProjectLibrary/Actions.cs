using System;

namespace ProjectLibrary
{
    public class Actions
    {
        Data data;

        public Actions(Data data)
        {
            this.data = data;
        }

        /// <summary>
        /// method to get current salary (difference od CS and taxes)
        /// </summary>
        /// <returns></returns>
        private double GetCurrentSalary()
        {
            return data.CS - Calculation();
        }

        private double Difference()
        {
            return data.CS - 5 * data.BS;
        }

        /// <summary>
        /// method to choose the right action which depends on the amount of the salary
        /// </summary>
        /// <returns>returns the amount of tax or an Exception</returns>
        public double Calculation()
        {
            if (data.CS >= 0 && data.CS <= data.BS) // added condition >=0
                return data.CS * 0;
            if (data.CS > data.BS && data.CS <= 5 * data.BS)
                return data.CS * 0.15;
            if (data.CS > 5 * data.BS && data.CS <= 10 * data.BS)
                return Difference() * 0.17 + 5 * data.BS * 0.15;
            if (data.CS > 10 * data.BS)
                return Difference() * 0.20 + 5 * data.BS * 0.15;
            return -1;
        }

        /// <summary>
        /// method to show information needed
        /// </summary>
        public void Show()
        {
            if (Calculation() == -1)
            {
                throw new MyException(-1);
            }
            else
            {
                Console.WriteLine("Basic Salary: "+ data.BS);
                Console.WriteLine("Current Salary (Bruto): " + data.CS);
                Console.WriteLine("Taxes to pay: " + Calculation());
                Console.WriteLine("Current Salary​ (Netto): " + GetCurrentSalary());
            }
        }
    }
}
