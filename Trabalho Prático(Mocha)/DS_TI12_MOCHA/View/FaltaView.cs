using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_TI12_MOCHA.View
{
    class FaltaView
    {
        private string fal_id;
        private string fal_data;
        private string fal_faltou;

        public string Fal_id
        {
            get
            {
                return fal_id;
            }

            set
            {
                fal_id = value;
            }
        }

        public string Fal_data
        {
            get
            {
                return fal_data;
            }

            set
            {
                fal_data = value;
            }
        }

        public string Fal_faltou
        {
            get
            {
                return fal_faltou;
            }

            set
            {
                fal_faltou = value;
            }
        }
    }
}
