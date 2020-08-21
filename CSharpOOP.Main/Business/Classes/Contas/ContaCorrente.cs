using CSharpOOP.Main.Interfaces;

namespace CSharpOOP.Main.Business.Classes.Contas
{
    public class ContaCorrente : ContaBase
    {
        public override void FazerDeposito(IConta contaRecebimento)
        {
            throw new System.NotImplementedException();
        }

        public override void FazerSaque(decimal valorSaque)
        {
            throw new System.NotImplementedException();
        }
        public virtual void FazerTransferencia(IConta contaRecebimento, decimal valorTransferencia)
        {

        }
    }
}