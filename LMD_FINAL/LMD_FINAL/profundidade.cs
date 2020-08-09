using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMD_FINAL
{
    class profundidade 
    {
        private Stack<no> pilha = new Stack<no>();
        public List<char> trajeto = new List<char>();
        

        public List<char> busca(no partida)
        {
            no atual = new no();
            atual = partida;
            atual.set_true();
            pilha.Push(atual);
            while (pilha.Count > 0)
            {
                atual = pilha.Peek();
                trajeto.Add(atual.get_name());
                if (atual.completo() == false)
                {
                    trajeto.Add(atual.pnv().get_name());
                    pilha.Push(atual.pnv());
                    atual.pnv().set_true();
                    atual._pos();
                }
                else
                {
                    pilha.Pop();
                }

            }
            return trajeto;




            /*
            //////////////////////////// FUNCIONANDO ///////////////////////////////////////////////////////
            no atual = new no();
            no no0 = new no();
            pilha.Push(partida);
            partida.set_true();
            atual = partida;
          
            while (atual != destino) {

                if (atual.proximo().getflag() == false)
                {
                    trajeto.Add(atual.get_name());
                    Console.WriteLine(atual.get_name() + "," + atual.getpos() + "," + atual.completo());
                    no0 = atual.proximo();
                    atual._pos();
                    atual = no0;
                    atual.set_true();
                    pilha.Push(atual);
                }
                else
                {Console.WriteLine(atual.get_name() + "," + atual.getpos() + "," + atual.completo());

                    trajeto.Add(atual.get_name());
                    pilha.Pop();
                    atual = pilha.Peek();
                    
                }

            }
        }
        
        public Stack<String> caminho()
        {
            Stack<String> ps = new Stack<String>();
            while (pilha.Count > 0)
            {
                ps.Push(Convert.ToString(pilha.Pop().get_name()));
            }
            return ps;*/
        }
        
    }
}

