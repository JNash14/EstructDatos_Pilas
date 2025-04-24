using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas
{
    class Pila
    {
        Nodo pri;

        public Pila()
        {
            pri = null;
        }

        public void Ingresar(int dato)  // {10 }
        {
            
            Nodo nuevo = new Nodo();
            nuevo.Dato = dato; //agregamos el valor de 10 en el nodo nuevo
            /*pri = nuevo;
            pri.Sgte = nuevo; //si haces esto no sale del bucle en el while*/
            nuevo.Sgte = pri;
            pri = nuevo;
        }

        public void Listado(ListBox lista)
        {
            Nodo actual = pri;
            while (actual != null)
            {
                lista.Items.Add(actual.Dato);
                actual = actual.Sgte;
            }
        }

        public void Extraer ()
        {
            if (pri != null) pri = pri.Sgte;
            else MessageBox.Show("La lista esta vacia");
        }
        public bool Buscar(int dato)
        {
            Nodo actual = pri;
            while (actual != null)
            {
                if (actual.Dato == dato) return true;
                actual = actual.Sgte;              
            }
            return false;
        }

        public void Modificar (int dato1, int dato2)
        {
            Nodo actual = pri;
            while (actual != null)
            {
                if (actual.Dato == dato1) actual.Dato = dato2;
                actual = actual.Sgte;
            }        
        }

        public void ExtraerHasta(int valor)
        {
            Nodo actual = pri;
            while (Buscar(valor))
            {
                pri = pri.Sgte;
                actual = actual.Sgte;
            }

            /*//Otro modo
            Nodo actual = pri;
            while (actual.Dato != valor)
            {
                actual = actual.Sgte;
            }
            pri = actual.Sgte;*/
        }

        public void Contar()
        {
            int contador = 0;
            Nodo actual = pri;
            while (actual != null)
            {
                contador++;
                actual = actual.Sgte;
            }
            MessageBox.Show("La pila tiene "+contador+" datos");
        }

        public void limpiar()
        {
            Nodo actual = pri;
            while (actual != null)
            {
                pri = actual.Sgte;
                actual = actual.Sgte;
            }
        }
    }
}
