using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Core.AuthHelper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Core.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {

        [HttpGet]
        [Route("Token")]
        public JsonResult GetJWTStr(long id = 1, string sub = "Admin", int expiresSliding = 30, int expiresAbsoulute = 30)
        {
            TokenModel tokenModel = new TokenModel();

            tokenModel.Uid = id;

            tokenModel.Sub = sub;

            DateTime d1 = DateTime.Now;

            DateTime d2 = d1.AddMinutes(expiresSliding);

            DateTime d3 = d1.AddDays(expiresAbsoulute);

            TimeSpan sliding = d2 - d1;

            TimeSpan absoulute = d3 - d1;

            string jwtStr = BlogCoreToken.IssueJWT(tokenModel, sliding, absoulute);

            return Json(jwtStr);

        }
    }
}
