using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    class Produtos
    {

        private static int Id;
        public static int _Id
        {
            get { return Id; }
            set { Id = value; }
        }

        private static string Descricao;
        public static string _Descricao
        {
            get { return Descricao; }
            set { Descricao = value; }
        }

        private static double Preco;
        public static double _Preco
        {
            get { return Preco; }
            set { Preco = value; }
        }

    }
}
