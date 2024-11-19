using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetp___Agenda.VariablesPublicas
{
    internal class UserSession
    {
        static private string nome = null;
        static private string usuario = null;
        static private string senha = null;

        public static string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                value = value.ToUpper();
                nome = value;
            }
        }
        public static string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }
        public static string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }
    }
}
