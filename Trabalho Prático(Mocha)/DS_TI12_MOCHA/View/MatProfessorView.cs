using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_TI12_MOCHA.View
{
    class MatProfessorView
    {
        private string mat_id;
        private string mat_nome;

        public string Mat_id
        {
            get
            {
                return mat_id;
            }

            set
            {
                mat_id = value;
            }
        }

        public string Mat_nome
        {
            get
            {
                return mat_nome;
            }

            set
            {
                mat_nome = value;
            }
        }
    }
}
