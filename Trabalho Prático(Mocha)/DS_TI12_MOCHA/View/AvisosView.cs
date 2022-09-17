using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_TI12_MOCHA.View
{
    class AvisosView
    {
        private string avi_texto;
        private string avi_recebeu;
        private string avi_mando;

        public string Avi_texto
        {
            get
            {
                return avi_texto;
            }

            set
            {
                avi_texto = value;
            }
        }

        public string Avi_recebeu
        {
            get
            {
                return avi_recebeu;
            }

            set
            {
                avi_recebeu = value;
            }
        }

        public string Avi_mando
        {
            get
            {
                return avi_mando;
            }

            set
            {
                avi_mando = value;
            }
        }
    }
}
