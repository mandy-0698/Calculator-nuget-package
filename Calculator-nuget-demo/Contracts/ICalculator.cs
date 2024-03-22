using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_nuget_demo.Contracts
{
    public interface ICalculator
    {
        public int Add(int a, int b);
        public int Subtract(int a, int b);
        public int Multiply(int a, int b);
        public int Divide(int a, int b);
    }
}
