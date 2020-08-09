using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMD_FINAL
{
    class no
    {
        private int pos;
        private bool flag;
        private char name;
        private List<no> lista = new List<no>();
        public no(char _name, bool _flag, List<no> a)
        {

            name = _name;
            flag = _flag;
            lista = a;
            pos = 0;

        }
        public no()
        {
            name = ' ';
            flag = false;
            pos = 0;
        }
        public char get_name()
        {
            return name;
        }
        public int get_q()
        {
            return lista.Count;
        }
        public void set_true()
        {
            flag = true;
        }
        public void set_false()
        {
            flag = false;
        }
        public void attlista(List<no> _lista)
        {
            lista = _lista;
        }
        public void _pos(){
            pos++;
           
        }
        public void _posm()
        {
            pos--;

        }
        public int getpos()
        {
            return pos;
        }
        public bool getflag()
        {
            return flag;
        }
        public void reset()
        {
            pos = 0;
        }
        public bool teste_anterior()
        {
            if (pos > 0)
            {
                return true;
            }
            else
                return false;
        }

        public no anterior()
        {

            if (lista != null && pos > 0)
            {
                try
                {
                    return lista.ElementAt(pos-1);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("ERRO CATCH!");
                    return lista.ElementAt(pos);
                }

            }
            else
            {
                
                
                    return lista.ElementAt(pos);
                
               

                //return null;
            }
        }
        //Proximo nao visitado.
        public no pnv()
        {
            int i = -1; 
                
            while (i < (lista.Count()-1))
            {
                i++;
                if (lista.ElementAt(i).getflag() == false)
                {
                    return lista.ElementAt(i);
                }  
            }
            return null;

        }



        public no proximo()
        {
            
            if (lista != null && pos<=(lista.Count-1))
            {
                try
                {
                    return lista.ElementAt(pos);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("ERRO CATCH!");
                    return lista.ElementAt(pos-1);
                }
           
            }
            else
            {
                try
                {
                    return lista.ElementAt(pos - 1);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    return lista.ElementAt(pos);
                }
                
                //return null;
            }
        } 
        public bool completo()
        {
            //bool teste = true;
            int count = 0;
            
            for (int i = 0; i < (lista.Count); i++) {
                if (lista.ElementAt(i).flag == false)
                {
                    //teste = false;
                    count++;
                    
                }
            }
            //Console.WriteLine("FUNÇÃO COMPLETO = "+count);
            if (count == 0)
            {
                //Console.WriteLine("No completo");
                return true;
            }
            else
            {
                //Console.WriteLine("No imcompleto");
                return false;
            }
        }
    }
}
