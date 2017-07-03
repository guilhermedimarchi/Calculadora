using System;
using System.Collections;
using System.Windows.Forms;

namespace Calculadora
{
    /// <summary>
    /// Classe da calculadora
    /// </summary>
    public class Calc
    {

        /// <summary>
        /// Construtor
        /// </summary>
        public Calc()
        {



        }

        /// <summary>
        /// Analisa a expressão e retorna verdadeiro ou falso se está ou não correta
        /// </summary>
        /// <param name="expr">Expressão infixa a analisar</param>
        /// <returns>Se é válida ou não</returns>
        public bool Analisar(string expr)
        {
            // Implementar!
            char p;
            EDA.Pilha s = new EDA.Pilha(50);
            bool valido = true;

            foreach (char c in expr)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    s.Push(c);
                }
                if (c == ')' || c == ']' || c == '}')
                {
                    if (s.Vazia())
                        valido = false;
                    else
                    {
                        p = (char)s.Pop();

                        if ((c == ')' && p != '(') || (c == ']' && p != '[') || (c == '}' && p != '{'))
                        {
                            valido = false;
                        }

                    }
                }
            }

            if (!s.Vazia())
                valido = false;

            return valido;
        }

        /// <summary>
        /// Converte uma expressão infixa em pósfixa
        /// </summary>
        /// <param name="expr">Expressão infixa a converter</param>
        /// <returns>A expressão pósfixa</returns>
        public string Converter(string expr)
        {
            EDA.Pilha s = new EDA.Pilha(50);
            string posfixa = "";
            int pr = 0;
            char x;

            foreach (char c in expr)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    posfixa += c;
                }

                if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^'|| c=='&' || c=='@')
                {
                    if (c == '&')
                    {
                        pr = Prioridade('*');

                        while ((!s.Vazia()) && (Prioridade((char)s.Top()) >= pr))
                        {
                            posfixa += (char)s.Pop();
                        }

                        s.Push('*');
                    }
                    else
                    {
                        pr = Prioridade(c);

                        while ((!s.Vazia()) && (Prioridade((char)s.Top()) >= pr))
                        {
                            posfixa += (char)s.Pop();
                        }

                        s.Push(c);
                    }
                }



                if (c == '(' || c == '{' || c == '[')
                    s.Push('(');
                if (c == ')' || c == '}' || c == ']')
                {
                    x = (char)s.Pop();

                    while (x != '(')
                    {
                        posfixa += x;
                        x = (char)s.Pop();
                    }
                }

            }

            while (!s.Vazia())
            {
                x = (char)s.Pop();
                posfixa += x;
            }


            return posfixa;
        }


        private int Prioridade(char op)
        {
            if (op == '(')
                return 1;
            else if (op == '+' || op == '-')
                return 2;
            else if (op == '*' || op == '/')
                return 3;
            else if (op == '^')
                return 4;
            else if (op == '@')
                return 5;
            else
                return 6;
        }


        /// <summary>
        /// Calcula o valor de uma expressão pósfixa
        /// </summary>
        /// <param name="posfixa"> A expressão pósfixa</param>
        /// <returns> O resultado da conta</returns>
        public double Calcular(string posfixa, Variavel[] vars)
        {
            EDA.Pilha s = new EDA.Pilha(50);

            double a = 0, b = 0;
            int j, x, y;
            double r;
            //ABC*+

            foreach (char c in posfixa)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {

                    foreach (Variavel v in vars)
                    {
                        if (v.Nome == c.ToString())
                            s.Push(v.Valor);
                    }
                    
                  //  MessageBox.Show(a.ToString());
                   
                }
                else if (c == '@')
                {
                    b = (double)s.Pop();
                    a = (double)s.Pop();
                    s.push(b * a);

                }
                else if(c=='&')
                {
                    b = (double)s.Pop();
                    a = (double)s.Pop();
                    s.Push((object)1.0);
                    for (int j = 0; j < vars.Length; j++)
                    {
                        if (b == vars[j].Valor)
                            x = j;
                        else if (a == vars[j].Valor)
                            y = j;
                    }
                    r = vars[x1].Valor;
                    vars[x1].Valor = vars[y1].Valor;
                    vars[y1].Valor = r;
                }
                else
                {
                    b = (double)s.Pop();
                    a = (double)s.Pop();


                    if (c == '+')
                        s.Push(a + b);
                    else if (c == '-')
                        s.Push(a - b);
                    else if (c == '*')
                        s.Push(a * b);
                    else if (c == '/')
                        s.Push(a / b);
                    else if (c == '^')
                        s.Push(Math.Pow(a, b));

                    /*
                    double y = (double)s.Pop();
                    double x = (double)s.Pop();
                    switch (c)
                    {
                        case '+': s.Push(x + y); break;
                        case '-': s.Push(x - y); break;
                        case '*': s.Push(x * y); break;
                        case '/': s.Push(x / y); break;
                        case '^': s.Push(Math.Pow(x, y)); break;
                    }*/

                }

            }
            return (double)s.Pop();
        }

    }


    /// <summary>
    /// Classe com os nomes e valores das variáveis
    /// </summary>
    public class Variavel
    {
        private string nome;
        private double valor;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Valor



        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
