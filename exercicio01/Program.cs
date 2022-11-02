using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    public class Elemento
    {
        public char valor;
        public Elemento proximo;

        public Elemento()
        {
            proximo = null;
        }
    }

    public class Lista
    {
        public Elemento inicio;
        public Elemento fim;
        public Elemento aux;
        public Elemento ant;

        public Lista()
        {
            inicio = null;
            fim = null;
        }

        public void InserirInicio(char x)
        {
            Elemento novo = new Elemento();
            novo.valor = x;

            if (inicio == null)
            {
                inicio = novo;
                fim = novo;
                novo.proximo = null;
            } else
            {
                novo.proximo = inicio;
                inicio = novo;
            }
        }

        public void InserirFinal(char x)
        {
            Elemento novo = new Elemento();
            novo.valor = x;

            if (inicio == null)
            {
                inicio = novo;
                fim = novo;
                fim.proximo = null;
            } else
            {
                fim.proximo = novo;
                fim = novo;
                fim.proximo = null;
            }
        }

        public void MostrarLista()
        {
            if (inicio == null)
            {
                Console.WriteLine("A lista esta vazia!");
                return;
            }

            aux = inicio;

            while(aux != null)
            {
                Console.WriteLine($"{aux.valor,5}");
                aux = aux.proximo;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            int escolha;
            Lista lista = new Lista();

            Console.WriteLine("Insira uma palavra");
            palavra = Console.ReadLine();
;        
            for(int i = 0; i < palavra.Length; i++)
            {
                Console.Clear();

                Console.WriteLine($"Escolha a operação para a letra: {palavra[i]}");
                Console.WriteLine("1 - inserir no inicio");
                Console.WriteLine("2 - inserir no final");

                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        lista.InserirInicio(palavra[i]);                       
                        break;
                    case 2:
                        lista.InserirFinal(palavra[i]);
                        break;
                }
            }

            lista.MostrarLista();

            Console.ReadKey();
        }
    }
}
