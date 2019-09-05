using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            { 
                Console.WriteLine("Welcome System Byte Bank\n");
                return true;    
           }
            else
            {
                Console.WriteLine("Password Incorrect\n");
                return false;
            }
                
        }

    }
}
