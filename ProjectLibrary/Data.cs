using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{
    public class Data
    {
        public double BS { get; set; } //BS- basic salary
        public double CS { get; set; } //CS - Current salary 

        public Data(double a, double b)
        {
            BS = a;
            CS = b;
        }
    }
}
