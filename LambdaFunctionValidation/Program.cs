using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctionValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Using Lambda Expression");


            LambdaExpression lambdaExpression = new LambdaExpression();
            lambdaExpression.Validate();
        }
    }
}
