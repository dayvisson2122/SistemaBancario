using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBCCSLN
{
    internal class TransacaoPix : Transacao
    {
        public string ChavePix { get; set; }

        public override bool Validar()
        {
            return _valor > 0 && _valor <= 10000;
        }
    }
}
