using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMD_FINAL
{
    class largura
    {
        private Stack<no> pilha = new Stack<no>();
        public List<no> lista = new List<no>();
        public List<char> trajeto = new List<char>();
        public List<char> buscar(no partida)
        {
            no atual = new no();
            atual = partida;
            atual.set_true();
            //Console.WriteLine(atual.get_name());
            trajeto.Add(atual.get_name());
            lista.Add(atual);

            Queue<no> fila = new Queue<no>();
            fila.Enqueue(atual);


            while (fila.Count > 0)
            {
                atual = fila.Dequeue();
               
                while (atual.completo() == false)
                {
                    trajeto.Add(atual.pnv().get_name());
                    fila.Enqueue(atual.pnv());
                    atual.pnv().set_true();

                }
            }












            /*
            while (atual != destino && limite < 50)
            {
                if (atual.proximo().getflag() == false )
                {
                    if ((atual.get_q() - 1) >= atual.getpos())
                    {
                        //Console.WriteLine(atual.get_name());
                        trajeto.Add(atual.proximo().get_name());
                        Console.WriteLine(atual.get_name()+","+ atual.get_q()+", " + atual.getpos());
                        atual.proximo().set_true();
                        lista.Add(atual.proximo());
                        atual._pos();

                        char[] b = new char[trajeto.Count];
                        b = trajeto.ToArray();
                        String str = "";
                        for (int i = 0; i < b.Length; i++)
                        {
                            str = str + b[i] + "->";
                            //Console.WriteLine(b[i]);
                        }
                        Console.WriteLine( str);


                        
                    }
                    if ((atual.get_q() -1) < atual.getpos())
                    {
                        
                        atual.reset();
                        atual = partida;
                        trajeto.Add(atual.get_name());
                    }
                }
                if(atual.proximo().getflag() == true)
                {
                    Console.WriteLine("NO JA VISITADO");
                    atual = atual.proximo();
                }
                if(atual.completo() && (atual.get_q()-1) == atual.getpos() )
                {
                    Console.WriteLine("RESETADO");
                    atual.reset();
                    atual = partida;
                }
                limite++;






                //////////////////////////////////////////////
                ///
                /*
                while(atual.get_q()-1 < atual.getpos())
                {
                    Console.WriteLine(atual.get_name());
                    trajeto.Add(atual.proximo().get_name());
                    if (atual.proximo() == destino)
                    {
                        break;
                    }
                    atual._pos();
                }
                if(atual.get_q() - 1 == atual.getpos())
                { 
                    atual.reset();
                    //atual = atual.proximo();
                    //atual.anterior()._pos();
                }
                if (atual.teste_anterior())
                    {
                        atual = atual.anterior().proximo();
                    trajeto.Add(atual.proximo().get_name());
                    Console.WriteLine(atual.get_name());

                }
                else
                {
                    atual = atual.proximo();
                    atual.anterior()._pos();
                    trajeto.Add(atual.proximo().get_name());
                    Console.WriteLine(atual.get_name());

                }
                */
           // }
            return trajeto;
         }
    }
}
