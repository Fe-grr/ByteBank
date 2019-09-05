using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;
using ByteBank.Sistemas;
namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            UsarSistema();

        }
            public static void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();
            Diretor stefany = new Diretor("23434");
            Designer jesus = new Designer("777");

            stefany.Senha = "12DS";
            jesus.Senha = "777";

            sistema.Logar(stefany, "12DS");
            sistema.Logar(jesus, "777");

            ParceiroComercial carlos = new ParceiroComercial();
            carlos.Senha = "123";
            sistema.Logar(carlos, "123");

            Console.ReadLine();
           

        }
        //Funcionario felipe = new Diretor("123213");
        //    Funcionario Gabriel = new Designer("32143");
        //    Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);
        //    Funcionario stefany = new Diretor("23434");
        //    Funcionario jesus = new Designer("777");

        //    jesus.AumentarSalario();
        //    Console.WriteLine(jesus.Salario);
        //    Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);

        //    Console.WriteLine("Salario Stefany ANTES DO AUMENTO: " + stefany.Salario);
        //    stefany.AumentarSalario();
        //    Console.WriteLine("Salario Stefany ATUAL: " + stefany.Salario);

        //    Console.WriteLine("Salario Felipe antes do aumento: " + felipe.Salario);
        //    felipe.AumentarSalario();

        //    Console.WriteLine("Salario Felipe ATUAL: " + felipe.Salario);
        //    Console.ReadLine();





            //GravarUsandoEntity();

            /*ContaCorrente contafelipe = new ContaCorrente();

            contafelipe.titular = "Felipe";
            contafelipe.agenicia = 133;
            contafelipe.numero = 444;
            contafelipe.saldo = 500;

            Console.WriteLine(contafelipe.titular);
            Console.WriteLine(contafelipe.agenicia);
            Console.WriteLine(contafelipe.saldo);
            Console.WriteLine(contafelipe.numero);

            Console.ReadLine();*/
        }

     // public static void GravarUsandoEntity()
     // {
     //     Cliente c = new Cliente();
     //    
     //     c.nome = "teste";
     //     c.cpf = 123223;
     //    // HasKey(cx => new { c.matricula});
     //
     //     using (var Contexto = new VendasContext())
     //     {
     //         
     //         Contexto.CLIENTES1.Add(c);
     //         Contexto.SaveChanges();
     //     }
     // }
}
