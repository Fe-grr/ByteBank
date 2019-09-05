using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer : FuncionarioAutenticavel
    {
        public Designer(string cpf) : base(cpf, 3500)
        {

        }
        public override void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.1);
        }
    }
}
