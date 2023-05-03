using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioEImposto {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola, bem vindo ao calculo de salario com calculo de imposto.");
            Console.WriteLine("Digite abaixo seus dados na ordem Nome, Salario!.");
            InfoFuncionario infoFuncionario = new InfoFuncionario();
            string[] dados = Console.ReadLine().Split(',');
            infoFuncionario.nome = dados[0];
            infoFuncionario.salario = decimal.Parse(dados[1]);
            Console.WriteLine();

            Console.WriteLine("Funcionario: " + infoFuncionario.nome);
            Console.WriteLine("Salario: " + infoFuncionario.salario.ToString("F2"));
            Console.WriteLine("Imposto: 1000");
            Console.WriteLine();

            Console.WriteLine("Agora faremos o calculo do seu Salario com o desconto do imposto e a % de aumento");

            Console.Write("Digite o valor da porcentagem que deseja adicionar ao salario: ");
            decimal porcentagem = RemoverPorcentagem.RemoveraPorcentagem(Console.ReadLine());
            decimal valorCalculado = porcentagem * infoFuncionario.salario / 100;
            infoFuncionario.salario = (infoFuncionario.salario + valorCalculado) - 1000;
            Console.WriteLine();

            Console.WriteLine("Dados atualizados");
            Console.WriteLine("Nome: " + infoFuncionario.nome);
            Console.WriteLine("Salario: $" + infoFuncionario.salario.ToString("F2"));
            
            Console.ReadKey();

        }
    }
}
