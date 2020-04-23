using System;
using IronPython.Hosting;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = Python.CreateEngine();
            var source = engine.CreateScriptSourceFromFile(@"C: \Users\ASP_Reza\source\repos\ConsoleApp1\PythonApplication1 - 27\PythonApplication1_27.py");
        }
    }
}
