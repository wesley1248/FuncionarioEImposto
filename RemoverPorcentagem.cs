using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioEImposto {
    internal class RemoverPorcentagem {
        public static decimal RemoveraPorcentagem(string valor)
        {
            valor = valor.Replace("%", "");
            if (decimal.TryParse(valor, out decimal result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException("Entrada invalida, reinicie o programa e digite um valor");
            }
        }
    }
}


