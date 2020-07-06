using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitBanBengGuanLiLianXi.Controllers
{
    public class test
    {
        private string _jd = string.Empty;
        public test() {
            _jd = DateTime.Now.ToString("yyyy-MM-dd HH:ss");
        }
        public string GetTime() {

            return $"当前时间{_jd}";
        }
    }
}