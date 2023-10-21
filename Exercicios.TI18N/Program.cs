using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTI18N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conectar a control com a program
            controlFormulario control = new controlFormulario();//Instanciando 
            control.operacao();

            //Manter aberto
            Console.ReadLine();
        }//fim do método main
    }//fim da classe 
}//fim do projeto  