using CSharpOOP.Main.Business.Classes.Clientes;
using CSharpOOP.Main.Enums;
using CSharpOOP.Main.Interfaces;

namespace CSharpOOP.Main.Business.Classes.Contas
{
    public abstract class ContaBase : IConta
    {

        private decimal Saldo { get; set; }

        public TipoConta Tipo { get; set; }
        public ClienteBase Cliente { get; set; }

        public abstract void FazerDeposito(IConta contaRecebimento);
        public abstract void FazerSaque(decimal valorSaque);

        public decimal RetornaSaldo()
        {
            return this.Saldo;
        }
    }
}