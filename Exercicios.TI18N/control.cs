using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTI18N
{
    class controlFormulario
    {
        modelExercicio exercicio;
        private int opcao;

        public controlFormulario()
        {
            exercicio = new modelExercicio();//Conecta a classe model e a control no exercicio
            ConsultarOpcao = -1;
        }//fim do método construtor 

        //Métodos modificadores 
        public int ConsultarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//fim do método

        public void menu()
        {
            Console.WriteLine("\n\n ---- Menu ---- \n\n" +
                               "0. Sair\n" +
                              "1. Exercicio 01\n" +
                              "2. Exercicio 02\n" +
                              "3. Exercicio 03\n" +
                              "4. Exercicio 04\n" +
                              "5. Exercicio 05\n" +
                              "6. Exercicio 06\n" +
                              "7. Exercicio 07\n" +
                              "8. Exercicio 08\n" +
                              "9. Exercicio 09\n" +
                              "10. Exercicio 10\n" +
                              "11. Exercicio 11\n" +
                              "Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//mostrar menu

        public void operacao()
        {
            do
            {

                menu();
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:

                        double nota1 = 0;//Declarei do lado de fora
                        double nota2 = 0;//Declarei do lado de fora
                        do
                        {
                            Console.WriteLine("Informe a primeira nota: ");
                            nota1 = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarNotas(nota1) == true)
                            {
                                Console.WriteLine("Informe uma nota entre 0 e 10");
                            }//fim da validação
                        } while (exercicio.ValidarNotas(nota1) == true);


                        do
                        {
                            Console.WriteLine("Informe a segunda nota: ");
                            nota2 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota2) == true)
                            {
                                Console.WriteLine("Informe uma nota entre 0 e 10");
                            }
                        } while (exercicio.ValidarNotas(nota2) == true);
                        //Chamar metodo da media que esta na classe model

                        Console.WriteLine("A média das notas digitadas é: " + exercicio.MediaDuasNotas(nota1, nota2));
                        break;

                    case 2:

                        Console.WriteLine("Informe um número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        //Comparação 
                        Console.WriteLine("O maior número é: " + exercicio.Comparar(num1,num2));
                        break;

                    case 3:

                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado 
                        Console.WriteLine("O antecessor é: " + exercicio.Antecessor(num));
                        break;

                    case 4:

                        Console.WriteLine("Informe o valor da base: ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o valor da altura: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("O valor do retângulo é : " + exercicio.MultiplicarArea(num1, num2));
                        break;
                    case 8:

                        double salarioFixo = 0;
                        double numeroCarros = 0;
                        double totalVendas = 0;
                        double valorPorCarro = 0;
                        double comissao = 0;
                        double salarioFinal = 0;
                        double exercicioSalarioFuncionario;

                        do
                    {
                            Console.WriteLine("Informe o salário fixo: ");
                              salarioFixo = Convert.ToInt32(Console.ReadLine());

                            if (exercicio.Validar(salarioFixo) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }

                    }while (exercicio.Validar(salarioFixo) == false);

                        do
                        {
                            Console.WriteLine("Informe o número de carros vendidos: ");
                            numeroCarros = Convert.ToInt32(Console.ReadLine());
                            if (exercicio.Validar(numeroCarros) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }
                        } while (exercicio.Validar(numeroCarros) == false);
                        
                        do
                        {
                            Console.WriteLine("Informe o número de total de vendas: ");
                            totalVendas = Convert.ToInt32(Console.ReadLine());
                            if (exercicio.Validar(totalVendas) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }
                        } while (exercicio.Validar(totalVendas) == false);

                        do
                        {
                            Console.WriteLine("Informe o número de Valor por carro: ");
                            valorPorCarro = Convert.ToInt32(Console.ReadLine());
                            if (exercicio.Validar(valorPorCarro) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }
                        } while (exercicio.Validar(valorPorCarro) == false);

                        do
                        {
                            Console.WriteLine("Informe o número da comissão: ");
                            comissao = Convert.ToInt32(Console.ReadLine());
                            if (exercicio.Validar(comissao) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }
                        } while (exercicio.Validar(comissao) == false);

                        salarioFinal = salarioFixo;

                        Console.WriteLine( " O salário do funcionario é: " + exercicio.SalarioFuncionario( numeroCarros,totalVendas,salarioFixo,valorPorCarro,comissao,salarioFinal));
                        break;
                    case 9:

                        nota1 = 0;
                        nota2 = 0;
                        double nota3 = 0;
                        double media = nota1 + nota2 + nota3;


                        do 
                        {
                            Console.WriteLine(" Informe a primeira nota: ");
                                nota1 = Convert.ToInt32(Console.ReadLine());
                            if (exercicio.Validar(nota1) == false)
                            {
                                Console.WriteLine("Informe um valor positivo: ");
                            }
                          
                        }while(exercicio.Validar(nota1) ==false);

                        do
                        {
                            Console.WriteLine(" Informe a segunda nota: ");
                                nota2 = Convert.ToInt32(Console.ReadLine());
                            if (exercicio.Validar(nota2) == false)
                            {
                                Console.WriteLine("Informe um valor positivo:" );
                            }

                        } while (exercicio.Validar(nota2) == false);

                        do
                        {
                            Console.WriteLine(" Informe a terceira nota: ");
                                nota3 = Convert.ToInt32(Console.ReadLine());
                            if (exercicio.Validar(nota3) == false)
                            {
                                Console.WriteLine("Informe um valor positivo: " );
                            }

                        } while (exercicio.Validar(nota3) == false);
                      

                        Console.WriteLine("Sua média foi: " + exercicio.MediaNotas(nota1,nota2,nota3, media));
                        if (media < 5)
                        {
                            Console.WriteLine(" Você está de recuperação, e precisa de: " + (10 - media) + 2);
                        }
                        else 
                        {
                            Console.WriteLine((media <= 7));
                            Console.WriteLine("Você vai para a prova final e, precisa de: " + (10 - media));
                        }
                        if (media <= 8)
                        {
                            Console.WriteLine(" Você vai para conselho");
                        }
                        else 
                        {
                            Console.WriteLine("Você está aprovado!!");
                        }
                        break;
                    default:

                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//fim do escolha
            } while (ConsultarOpcao != 0);


        }//fim método

     


    }//fim classe
}//fim projeto