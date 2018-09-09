using System;
using System.Collections.Generic;
using System.Text;
using Blog.Core.IRepository;

namespace Blog.Core.Repository
{
    public class TestRepository : ITestRepository
    {
        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="i">参数1</param>
        /// <param name="j">参数2</param>
        /// <returns>返回i+j</returns>
        public int Sum(int i, int j)
        {
            return i + j;
        }
    }
}
