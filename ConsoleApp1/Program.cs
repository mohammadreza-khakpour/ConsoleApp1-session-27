using System;
using IronPython.Hosting;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = Python.CreateEngine();
            var source = engine.CreateScriptSourceFromFile(@"C:\Users\ASP_Reza\source\repos\ConsoleApp1\PythonApplication1-27\PythonApplication1_27.py");
            var scope = engine.CreateScope();
            source.Execute(scope);
            // loads the class definition to the memory:
            dynamic class1 = scope.GetVariable("MohammadpourPython");
            // making an object of my class:
            dynamic obj = engine.Operations.CreateInstance(class1);

            Console.WriteLine(obj.Sum(10,20));
            Console.WriteLine(obj.Mult(10,20));

        }
    }
}
