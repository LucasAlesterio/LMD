using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace LMD_FINAL
{
    public partial class LMD : Form
    {
        int flag = 0;
        char[] trajeto_;
        bool teste = false;
        public LMD()
        {
            InitializeComponent();
        }
        private void LMD_Load(object sender, EventArgs e)
        {

            profundidade.Enabled = false;
            origem.Text = "A";
            limpar();

            

            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            profundidade.Enabled = false;
            largura.Enabled = true;
        }

        private void Largura_Click(object sender, EventArgs e)
        {
            profundidade.Enabled = true;
            largura.Enabled = false;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {

                List<no> A = new List<no>();
                List<no> B = new List<no>();
                List<no> C = new List<no>();
                List<no> D = new List<no>();
                List<no> E = new List<no>();
                List<no> F = new List<no>();
                List<no> G = new List<no>();
                List<no> H = new List<no>();
                List<no> I = new List<no>();
                List<no> J = new List<no>();
                List<no> K = new List<no>();
                List<no> L = new List<no>();
                List<no> M = new List<no>();
                List<no> N = new List<no>();
                List<no> O = new List<no>();

                no no_a = new no('A', false, A);
                no no_b = new no('B', false, B);
                no no_c = new no('C', false, C);
                no no_d = new no('D', false, D);
                no no_e = new no('E', false, E);
                no no_f = new no('F', false, F);
                no no_g = new no('G', false, G);
                no no_h = new no('H', false, H);
                no no_i = new no('I', false, I);
                no no_j = new no('J', false, J);
                no no_k = new no('K', false, K);
                no no_l = new no('L', false, L);
                no no_m = new no('M', false, M);
                no no_n = new no('N', false, N);
                no no_o = new no('O', false, O);

                A.Add(no_b); A.Add(no_c); A.Add(no_d);
                B.Add(no_e); B.Add(no_f); B.Add(no_g); B.Add(no_a);
                C.Add(no_h); C.Add(no_i); C.Add(no_a);
                D.Add(no_j); D.Add(no_a);
                E.Add(no_k); E.Add(no_l); E.Add(no_b);
                F.Add(no_m); F.Add(no_b);
                G.Add(no_b);
                H.Add(no_n); H.Add(no_c);
                I.Add(no_o); I.Add(no_c);
                J.Add(no_d);
                K.Add(no_e);
                L.Add(no_e);
                M.Add(no_f);
                N.Add(no_h);
                O.Add(no_i);

                no_a.attlista(A);
                no_b.attlista(B);
                no_c.attlista(C);
                no_d.attlista(D);
                no_e.attlista(E);
                no_f.attlista(F);
                no_g.attlista(G);
                no_h.attlista(H);
                no_i.attlista(I);
                no_j.attlista(J);
                no_k.attlista(K);
                no_l.attlista(L);
                no_m.attlista(M);
                no_n.attlista(N);
                no_o.attlista(O);

                if (profundidade.Enabled == false)
                {
                    no no_origem = new no();


                    String o = origem.Text;

                    switch (o)
                    {
                        case "A":
                            no_origem = no_a;
                            break;
                        case "B":
                            no_origem = no_b;
                            break;
                        case "C":
                            no_origem = no_c;
                            break;
                        case "D":
                            no_origem = no_d;
                            break;
                        case "E":
                            no_origem = no_e;
                            break;
                        case "F":
                            no_origem = no_f;
                            break;
                        case "G":
                            no_origem = no_g;
                            break;
                        case "H":
                            no_origem = no_h;
                            break;
                        case "I":
                            no_origem = no_i;
                            break;
                        case "J":
                            no_origem = no_j;
                            break;
                        case "K":
                            no_origem = no_k;
                            break;
                        case "L":
                            no_origem = no_l;
                            break;
                        case "M":
                            no_origem = no_m;
                            break;
                        case "N":
                            no_origem = no_n;
                            break;
                        case "O":
                            no_origem = no_o;
                            break;

                    }


                    profundidade busca = new profundidade();
                    char[] traj = busca.busca(no_origem).ToArray();
                    String str = "";

                    //Console.WriteLine(str);

                    for (int i = 0; i < traj.Length; i++)
                    {
                        str = str + traj[i] + "->";
                        //Console.WriteLine(traj[i]);
                    }
                    //str = str + d;
                    //Console.WriteLine(str);
                    trajeto.Text = str;
                    printar_caminho(traj);
                    trajeto_ = traj;
                   // return traj;

                }
                if (profundidade.Enabled == true)
                {
                ////////////////LARGURA/////////////////
                    largura busca = new largura();
                    no no_origem = new no();
                    no no_destino = new no();
                    List<char> a = new List<char>();
                    char[] b = new char[a.Count];


                    String o = origem.Text;

                    switch (o)
                    {
                        case "A":
                            no_origem = no_a;
                            break;
                        case "B":
                            no_origem = no_b;
                            break;
                        case "C":
                            no_origem = no_c;
                            break;
                        case "D":
                            no_origem = no_d;
                            break;
                        case "E":
                            no_origem = no_e;
                            break;
                        case "F":
                            no_origem = no_f;
                            break;
                        case "G":
                            no_origem = no_g;
                            break;
                        case "H":
                            no_origem = no_h;
                            break;
                        case "I":
                            no_origem = no_i;
                            break;
                        case "J":
                            no_origem = no_j;
                            break;
                        case "K":
                            no_origem = no_k;
                            break;
                        case "L":
                            no_origem = no_l;
                            break;
                        case "M":
                            no_origem = no_m;
                            break;
                        case "N":
                            no_origem = no_n;
                            break;
                        case "O":
                            no_origem = no_o;
                            break;

                    }

                    a = busca.buscar(no_origem);
                    b = a.ToArray();
                    trajeto_ = b;
                    //printar_caminho(b);
                    String str = "";
                    for (int i = 0; i < b.Length; i++)
                    {
                        str = str + b[i] + "->";
                        //Console.WriteLine(b[i]);
                    }
                    //str = str + d;
                    //Console.WriteLine(str);
                    trajeto.Text = str;
                   
                    //return b;
                }

                void printar_caminho(char[] a)
                {

                    int i = a.Length;
                    int j = 1;

                    String[] b = new String[i - 1];

                    //Console.WriteLine(i);

                    for (i = 0; i < a.Length - 1; i++)
                    {
                        b[i] = Convert.ToString(a[i]) + Convert.ToString(a[i + 1]);
                        //Console.WriteLine(b[i]);
                    }

                    {
                    }
                }

            // return null;
            timer.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ///////////////////// TIMER ///////////////////////////
           
            atualizar(trajeto_);
            if(teste == true)
            {
                timer.Stop();
                Console.WriteLine("TIMER STOPED");
                flag = 0;
                teste = false;
            }
            
        }
        public void atualizar(char[] a)
        {
            limpar();
            switch (a[flag])
            {
                case 'A':
                    A.Visible = true;
                    break;
                case 'B':
                    B.Visible = true;
                    break;
                case 'C':
                    C.Visible = true;
                    break;
                case 'D':
                    D.Visible = true;
                    break;
                case 'E':
                    E.Visible = true;
                    break;
                case 'F':
                    F.Visible = true;
                    break;
                case 'G':
                    G.Visible = true;
                    break;
                case 'H':
                    H.Visible = true;
                    break;
                case 'I':
                    I.Visible = true;
                    break;
                case 'J':
                    J.Visible = true;
                    break;
                case 'K':
                    K.Visible = true;
                    break;
                case 'L':
                    L.Visible = true;
                    break;
                case 'M':
                    M.Visible = true;
                    break;
                case 'N':
                    N.Visible = true;
                    break;
                case 'O':
                    O.Visible = true;
                    break;
            }
            flag++;
            if(flag == a.Length)
            {
                teste = true;
            }
            
        } 
        public void limpar()
        {
            Arvore.Visible = true;
            A.Visible = false;
            B.Visible = false;
            C.Visible = false;
            D.Visible = false;
            E.Visible = false;
            F.Visible = false;
            G.Visible = false;
            H.Visible = false;
            I.Visible = false;
            J.Visible = false;
            K.Visible = false;
            L.Visible = false;
            M.Visible = false;
            N.Visible = false;
            O.Visible = false;

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
