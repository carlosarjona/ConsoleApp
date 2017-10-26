using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    interface ILista
    {
        void Adicionar(Object o);
        void Adicionar(Object o, int posicao);

        Object getObjeto(int posicao);

        void RemoverElemento(int posicao);

        bool Contem(Object o);

        int getTamanho();
    }
}
