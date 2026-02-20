using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBCCSLN
{

        public class Banco
        {
            private string nome;
            private string codigoBACEN;

            public string Nome
            {
                get { return nome.ToUpper(); }
                set { nome = value; }
            }

            public string CodigoBACEN
            {
                get { return codigoBACEN; }
                set
                {
                    if (value == null || value == "")
                    {
                        throw new ArgumentException("O Código BACEN não pode ser nulo ou vazio.");
                    }
                    codigoBACEN = value;
                }
            }
        }
    }