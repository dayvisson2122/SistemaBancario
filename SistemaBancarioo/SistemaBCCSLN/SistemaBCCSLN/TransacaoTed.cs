using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBCCSLN
{
    internal class TransacaoTed : Transacao
    {
        public override bool Validar()
        {
            return _valor > 5000;
        }
    }
  
}
