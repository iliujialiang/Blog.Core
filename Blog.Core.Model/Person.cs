using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Model
{
    /// <summary>
    /// 人类
    /// </summary>
    public class Person
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
    }
}
