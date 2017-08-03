using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBrowser2.TestingTools
{
    public class RandomString
    {
        public static string GenerateRandomString()
        {
            return GenerateRandomString(8);
        }

        public static string GenerateRandomString(int length)
        {
            StringBuilder randomString = new StringBuilder();

            while (randomString.Length < length)
            {
                randomString.Append(Convert.ToBase64String(Guid.NewGuid().ToByteArray()));
            }
            return randomString.ToString().Substring(0, length)
                .Replace("/", String.Empty)
                .Replace("+", String.Empty)
                .Replace("^", String.Empty)
                .Replace("=", String.Empty)
                .Replace("-", String.Empty);
        }
    }
}