using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blog.Core.IService;
using Blog.Core.Service;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Core.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        ITestService testService = new TestService();

        // GET: api/<controller>
        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="i">参数1</param>
        /// <param name="j">参数2</param>
        /// <returns>返回i+j</returns>
        [HttpGet]
        public int Get(int i,int j)
        {
            return testService.Sum(i, j);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
