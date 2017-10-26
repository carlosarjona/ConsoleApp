using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Vetor : ILista
    {

        Object[] itens = new Object[4];
        private int QtdeItens = 0;



        public void Adicionar(object o)
        {
            if (IsCheio()) {
                Console.WriteLine("Estava Cheio...");
                Redimensionar();
            }
            itens[QtdeItens] = o;
            QtdeItens++;
            
            
        }

        public void Adicionar(object o, int posicao)
        {
            if (posicao >= QtdeItens)
            {
                Adicionar(o);
            }
            else
            {
                for (int i = QtdeItens; i > posicao; i--)
                {
                    itens[i] = itens[i-1];
                    itens[i - 1] = null;

                }

                itens[posicao] = o;
                QtdeItens++;

                if (IsCheio())
                {
                    Redimensionar();
                }
            }
            
        }


       

        void Redimensionar()
        {
            object[] novo = new object[getTamanho()*2];
            for (int i = 0; i < itens.Length; i++)
            {
                novo[i] = itens[i];
            }


            itens = novo;
        }


        public Boolean IsCheio()
        {
            return QtdeItens >= itens.Length;
        }



        

        public Object getObjeto(int posicao)
        {
            return itens[posicao];
            
        }

        public void RemoverElemento(int posicao)
        {

        }

        public bool Contem(Object o)
        {

            for (int i = 0; i < QtdeItens; i++)
            {
                if (itens[i] == o)
                {
                    return true;
                }
            }

           return false;
        }

        public int getTamanho()
        {
            return QtdeItens;
        }

        public override string ToString()
        {
            string texto = "";

            for (int i = 0; i < QtdeItens; i++)
            {
                texto = texto + " - " + itens[i].ToString();
            }
            return texto;
        }
    }
}
