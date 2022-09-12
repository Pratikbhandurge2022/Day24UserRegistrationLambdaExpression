using System;
using System.Linq.Expressions;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Using Lambda");
            LambdaExpression lambdaExpression = new LambdaExpression();
            lambdaExpression.Validate();
        }
    }
}