using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_TI12_MOCHA.View
{
    class TurmaView
    {
        private string tur_nome;
        private string tur_unidade;

        public string Tur_nome
        {
            get
            {
                return tur_nome;
            }

            set
            {
                tur_nome = value;
            }
        }

        public string Tur_unidade
        {
            get
            {
                return tur_unidade;
            }

            set
            {
                tur_unidade = value;
            }
        }
    }
}
