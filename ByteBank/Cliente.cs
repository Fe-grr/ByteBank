using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace ByteBank
{
    public class Cliente
    {
        public string nome { get; set; }
        public int cpf { get; set; }

        public virtual ICollection<Cliente> CLIENTES1 { get; set; }
    }
}
