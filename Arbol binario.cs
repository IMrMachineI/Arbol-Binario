using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario
{
    class Arbol_binario
    {
        private Nodo raiz;
        public void agregarNodo(Nodo nuevoNodo)
        {
            if(raiz == null)
            {
                raiz = nuevoNodo;
            }
            else
            {
                agregar(nuevoNodo, raiz);
            }
        }
        private void agregar(Nodo nodo,Nodo padre)
        {
            if(nodo.dato < padre.dato)
            {
                if(padre.hijoIzquierdo == null)
                {
                    padre.hijoIzquierdo = nodo;
                }
                else
                {
                    agregar(nodo, padre.hijoIzquierdo);
                }
            }
            else
            {
                if(padre.hijoDerecho == null)
                {
                    padre.hijoDerecho = nodo;
                }
                else
                {
                    agregar(nodo, padre.hijoDerecho);
                }
            }
        }
        public string PreOrden()
        {
            if(raiz == null)
            {
                return "";
            }
            else
            {
                return PreOrden(raiz);
            }
        }
        private string PreOrden(Nodo raiz)
        {
            string resultado = "";
            resultado += raiz.ToString();
            if(raiz.hijoIzquierdo != null)
            {
                resultado += PreOrden(raiz.hijoIzquierdo);
                if(raiz.hijoDerecho != null)
                {
                    resultado += PreOrden(raiz.hijoDerecho);
                }
            }
            return resultado;
        }
        public string InOrden()
        {
            if (raiz == null)
            {
                return "";
            }
            else
            {
                return InOrden(raiz);
            }
        }
        private string InOrden(Nodo raiz)
        {
            string resultado = "";
            resultado += raiz.ToString();
            if (raiz.hijoIzquierdo != null)
            {
                resultado += PreOrden(raiz.hijoIzquierdo);
                if (raiz.hijoDerecho != null)
                {
                    resultado += PreOrden(raiz.hijoDerecho);
                }
            }
            return resultado;
        }
    }
}
