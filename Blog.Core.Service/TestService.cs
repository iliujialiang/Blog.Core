using System;
using System.Collections.Generic;
using System.Text;
using Blog.Core.IService;
using Blog.Core.IRepository;
using Blog.Core.Repository;
//这里没有用到依赖注入，所以创建仓储示例需要new，因此需要引用Repository层。
//将来使用依赖注入，就不需要引用Repository了，实现Service层和Repository层解耦。

namespace Blog.Core.Service
{
    public class TestService:ITestService
    {
        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="i">参数1</param>
        /// <param name="j">参数2</param>
        /// <returns>返回i+j</returns>
        public int Sum(int i, int j)
        {
            ITestRepository testRepository = new TestRepository();

            return testRepository.Sum(i, j);
        }
    }
}
