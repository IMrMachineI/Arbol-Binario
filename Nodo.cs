using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario
{
    class Nodo
    {
        private int _dato { get; }
        public Nodo hijoIzquierdo;
        public Nodo hijoDerecho;
        public Nodo(int dato)
        {
            _dato = dato;
        }
        public int dato
        {
            get { return _dato; }
        }
        public override string ToString()
        {
            
        }
    }
}
