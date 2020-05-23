using System.Collections.Generic;

namespace MyFirstAWSServerless.Services
{
    public interface ITestService
    {
        public Dictionary<string, string> GetTestResponse();
    }
}