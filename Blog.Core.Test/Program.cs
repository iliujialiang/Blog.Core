using System;
using Blog.Core.IService;
using Blog.Core.Service;

namespace Blog.Core.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestService testService = new TestService();

            int result = testService.Sum(1, 2);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
