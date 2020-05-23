using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAWSServerless.Services
{
    public class TestService : ITestService
    {
        private  readonly Dictionary<string, string> _result = new Dictionary<string, string>
        {
            { "Test Health", "OK" },
            { "is api working", "True" }
        };
        public Dictionary<string, string> GetTestResponse()
        {
            return _result;
        }
    }
}
