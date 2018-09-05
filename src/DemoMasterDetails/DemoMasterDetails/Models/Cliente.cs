using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMasterDetails.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public IList<Telefone> Telefones { get; set; } = new List<Telefone>();

    }


    public class Telefone
    {
        public int DDD { get; set; }
        public string Numero { get; set; }
    }
}
