using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Bank
    {
        public string Nome { get; private set; }

        public List<Cliente> clienti;
        public List<Prestito> prestiti;


    }
}
