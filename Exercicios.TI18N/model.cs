using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
            }//fim validar
        }

        //Exercicio 2 
        public int Comparar (int num1,int num2)
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
        }//fim método

        //Exercicio 08 - Salario funcionario
        public double SalarioFuncionario(double numeroCarros, double totalVendas, double salarioFixo, double valorPorCarro, double comissao, double salarioFinal)
        {
            return (salarioFixo + (valorPorCarro * numeroCarros) + totalVendas * ( comissao/100));
        }//fim do método
        //Exercicio 09 - Notas 
        public double MediaNotas(double nota1, double nota2, double nota3, double media)
            { 
                return ((media = (nota1 + nota2) /3));
            }// fim método
        
    }//fim da classe
}//fim do projeto 