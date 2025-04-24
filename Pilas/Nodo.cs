using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    class Nodo
    {
        private int dato;
        private Nodo sgte; //se crea un nodo que hara de puntero

        public int Dato { get => dato; set => dato = value; }
        internal Nodo Sgte { get => sgte; set => sgte = value; }
        //en pilas no se existe un nodo anterior por que es especial no se requiere
    }
}
