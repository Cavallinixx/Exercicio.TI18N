using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTI18N

{
    class modelExercicio
    {
        public modelExercicio()
        {

        }//fim do construtor  

        //Exercicio 01 - A média de duas notas
        public double MediaDuasNotas(double nota1, double nota2)
        {
            return (nota1 + nota2) / 2;
        }//fim do método média

        //metodo validadação 
        public Boolean ValidarNotas(Double nota)
        {
            if ((nota < 0) || (nota > 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//fim método
        public Boolean Validar(double num)
        {
            if (num < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }//fim da validação

        public Boolean ValidarImpar(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//fim da validação
        //Exercicio 2 
        public int Comparar(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }//fim comparar 

        //Exercicio 03 - Mostrar o antecessor 
        public int Antecessor(int num)
        {
            return num - 1;
        }//fim método

        //Exercicio 04 - Calcular e escrever a área do retângulo
        public double MultiplicarArea(int num1, int num2)
        {
            return (num1 * num2);

        }
        //Exercicio 05 - Porcentagem de votos
        public double PorcentagemVotos(double votos, double total)
        {
            return (votos * 100) / total;
        }//fim do método de porcentagem

        //Exercicio 06 - Calcular o salario mais reajuste
        public double SomarReajuste(double salario, double reajuste)
        {
            return salario * (reajuste / 100) + salario;
        }//fim método

        //Exercicio 07 - Calcular o custo final 
        public double CustoFinal(double porc, double custoInicial)
        {
            return custoInicial * (porc / 100);
        }//fim do método 

        //Exercicio 08 - Salario funcionario
        public double SalarioFuncionario(double numeroCarros, double totalVendas, double salarioFixo, double valorPorCarro, double comissao, double salarioFinal)
        {
            return (salarioFixo + (valorPorCarro * numeroCarros) + totalVendas * (comissao / 100));
        }//fim do método

        //Exercício 09
        public double MediaNotas(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }//Fim Media

        public double NotaNecessaria(double media)
        {
            if (media >= 0 && media < 5)
            {
                return 10 - media + 2;
            }
            else
            {
                return 10 - media;
            }
        }//Fim Nota

        // Exercicio 10 
        public void MenuCd()
        {

        }
        
        //Exercicio 11 
         public int ParOuImpar(int num)
        {
           return num;
        }



    }//fim da classe
}//fim do projeto 
