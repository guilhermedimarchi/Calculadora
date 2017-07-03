using System;
using System.Collections.Generic;
using System.Text;

namespace EDA
{
    public class Pilha
    {
        // Atributos - onde os dados da pilha ficam
        private int topo, maximo;
        private object [] elementos;

        // Construtor
        public Pilha(int m)
        {
            topo = 0;
            maximo = m;
            elementos = new object[m];
        }

        // Testando se a pilha está cheia
        public bool Cheia()
        {
            return topo == maximo;
        }

        public object Top()
        {
            if (Vazia())
                throw new Exception("Pilha Vazia!");
            return elementos[topo-1];
        }

        // Empilhando elementos
        public void Push(object x)
        {
            if (Cheia())
                throw new Exception("Pilha cheia!");
            elementos[topo++] = x;
        }

        // Verificando se a Pilha está vazia
        public bool Vazia()
        {
            return topo == 0;
        }

        // Desempilhando elementos
        public object Pop()
        {
            if (Vazia())
                throw new Exception("Pilha Vazia!");
            return elementos[--topo];
        }
    }
}
