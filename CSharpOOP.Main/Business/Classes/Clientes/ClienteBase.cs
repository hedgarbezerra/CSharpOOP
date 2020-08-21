using CSharpOOP.Main.Business.Classes.Contas;
using CSharpOOP.Main.Enums;
using CSharpOOP.Main.Interfaces;

namespace CSharpOOP.Main.Business.Classes.Clientes
{
    public class ClienteBase : ICliente
    {
        public TipoConta Tipo { get; set; }
        public ContaBase Conta { get; set; }
    }
}