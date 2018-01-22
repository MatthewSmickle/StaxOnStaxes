using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StaxsOnStaxes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter and Expression: ");
            String input = "A * B – (C + D) + E";//Console.ReadLine();
            input.Replace(" ", "");
            String[] arr = new String[input.Length];
            String end = "";
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = input.Substring(i, 1);
            }
            Stack stax = new Stack();
            foreach(String t in arr)
            {
                if( !"*+-/()".Contains(t))
                {
                    end =  end + t;
                }
                else if(t == "(")
                {
                    while(true)
                    {
                        if( t != ")" && stax.Count != 0)
                        {
                            stax.Pop();
                            end = end + t;
                        }
                        else
                        {
                           break;
                        }
                        
                    }
                }
                else
                {
                    bool pre;
                    if(t=="*" || t == "/")
                    {
                        pre = true;
                    }
                    else
                    {
                        pre = false;
                    }
                    

                    if(!pre && t != "(" && stax.Count != 0)
                    {
                        stax.Pop();
                    }

                    stax.Push(t);

                    

                }
            }

            foreach(String t in stax)
            {
                stax.Pop();
                end = end + t;
            }

            Console.Write(end);








            /*/ Use whatever you need from below...
            Stack st = new Stack();

            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            st.Push('V');
            st.Push('H');
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");

            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing values ");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            /*/
        }
    }
}
