using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] itens = null;
        private int proximaPosica = 0;
        public ListaDeContasCorrentes(int xTamanhoInicial = 5)
        {
            itens = new ContaCorrente[xTamanhoInicial];

        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adiconando item na posição {proximaPosica}");
            VerificarCapacidade(proximaPosica + 1);
            itens[proximaPosica] = item;
            proximaPosica++;
        }


        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (itens.Length >= tamanhoNecessario)
            {
                return;
            }
            Console.WriteLine("Aumentando a  Capacidade da Lista!!");

            ContaCorrente [] novoArray = new ContaCorrente[tamanhoNecessario];
            for(int i = 0; i < itens.Length; i++)
            {
                novoArray[i] = itens[i];

            }
            itens = novoArray;
        }

        public void Remover( ContaCorrente conta)
        {
            int indiceItem = -1;

            for(int i = 0; i <= proximaPosica; i++)
            {
                ContaCorrente contaAtual = itens[i];
                if(contaAtual == conta)
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < proximaPosica-1; i++)
            {
                itens[i] = itens[i +1];

            }
            proximaPosica--;
            itens[proximaPosica] = null;
        }


        public void ExibeLista()
        {
            for (int i = 0; i < itens.Length; i++)
            {
              
                if(itens[i] != null)
                {
                    var conta = itens[i];
                    Console.WriteLine($"Indice {i} = conta : {conta.Conta}");
                }
              
            }
        }

        public ContaCorrente RecuperarItemIndice(int indice)
        {
            if(indice < 0 || indice >= proximaPosica)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return itens[indice];
        }

        public ContaCorrente this[int indece]
        {
            get
            {
                return RecuperarItemIndice(indece);
            }
        }
        public int Tamanho
        {
            get
            {
                return proximaPosica;
            }
        }

    }
}
