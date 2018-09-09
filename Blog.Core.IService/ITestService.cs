using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.IService
{
    public interface ITestService
    {
        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="i">参数1</param>
        /// <param name="j">参数2</param>
        /// <returns>返回i+j</returns>
        int Sum(int i, int j);
    }
}
