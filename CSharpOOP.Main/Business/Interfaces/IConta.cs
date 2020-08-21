using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpOOP.Main.Interfaces
{
    public interface IConta
    {
        void FazerDeposito(IConta contaRecebimento);
        decimal RetornaSaldo();
        void FazerSaque(decimal valorSaque);
    }
}