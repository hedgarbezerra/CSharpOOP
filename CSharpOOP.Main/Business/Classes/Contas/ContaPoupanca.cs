using CSharpOOP.Main.Interfaces;

namespace CSharpOOP.Main.Business.Classes.Contas
{
    public class ContaPoupanca : ContaBase
    {
        public override void FazerDeposito(IConta contaRecebimento)
        {
            throw new System.NotImplementedException();
        }

        public override void FazerSaque(decimal valorSaque)
        {
            throw new System.NotImplementedException();
        }
    }
}
