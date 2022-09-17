using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_TI12_MOCHA.View
{
    class LoginView
    {
        private string usu_nick;
        private string usu_senha;
        private int fk_aca_id;

        public string Usu_nick
        {
            get
            {
                return usu_nick;
            }

            set
            {
                usu_nick = value;
            }
        }

        public string Usu_senha
        {
            get
            {
                return usu_senha;
            }

            set
            {
                usu_senha = value;
            }
        }

        public int Fk_aca_id
        {
            get
            {
                return fk_aca_id;
            }

            set
            {
                fk_aca_id = value;
            }
        }
    }
}
