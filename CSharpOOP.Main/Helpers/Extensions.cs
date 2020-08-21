using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Main.Helpers
{
    public static class Extensions
    {
        public static void AddRequestHeaders(this RestRequest request, List<KeyValuePair<string, string>> headers = null)
        {
            if (headers == null)
                throw new ArgumentNullException();
        }
    }
}
