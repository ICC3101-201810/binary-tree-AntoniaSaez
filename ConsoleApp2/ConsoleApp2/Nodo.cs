using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Node<T> where T : new()
    {
        private T value;
        private Node<T> Padre;
        private Node<T> HijoIzquierdo;
        private Node<T> HijoDerecho;
        public Node()
        {
            this.value = new T();
        }
        public Node(T value)
        {
            this.value = value;
        }
        public T Value
        {
            get { return value; }
            set { this.value = value; }
        }
        private Node<T> NodoPadre
        {
            get { return Padre; }
            set { Padre = value; }
        }
        public Node<T> NodoHijoIzquierdo
        {
            get { return HijoIzquierdo; }
            set
            {
                if (this.GetType() == value.GetType())
                {
                    value.NodoPadre = this;
                    HijoIzquierdo = value;
                }
                else
                {
                    Console.WriteLine("El tipo del nodo padre y del nodo hijo es el mismo");
                }
            }
        }
        public Node<T> NodoHijoDerecho
        {
            get { return HijoDerecho; }
            set
            {
                if (this.GetType() == value.GetType())
                {
                    value.NodoPadre = this;
                    HijoDerecho = value;
                }
                else
                {
                    Console.WriteLine("El tipo de nodo padre y de nodo hijo es el mismo");
                }
            }
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }
}
