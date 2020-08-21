using CSharpOOP.Main.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Main.Helpers
{
    public static class BasicMethods
    {
        public static DTORequestEndereco GetEndereco(string cep)
        {
            var client = new RequestClient();

            return client.Get<DTORequestEndereco>($"https://viacep.com.br/ws/{cep}/json/");
        }
    }
}
