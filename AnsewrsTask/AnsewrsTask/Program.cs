using System;
using System.Runtime.InteropServices;

namespace AnsewrsTask
{
    internal class Program
    {
        static void Main(string[] args)

        {
             
            mcq q1 = new mcq(1,"your name ?",5);
           
            q1.arr = new string[]
           {
               "mahmoud",
               "ahmed",
               "mohamed",
           };
             q1.Print();

            TrueOrFalse q2 = new TrueOrFalse(2,"your age between 18:23 ?",4);
            
            q2.Print();
                 
        }
    }
        abstract class ques {
        public int num;
        public int mark;
        public string body;
        public int Num{ 
            get { return num; }
            set { num = value; }
        }
        public int Mark{ 
            get { return mark; }    
            set { mark = value; }   
        }
        public string Body
        {
            get { return Body; }
            set { Body = value; }
        } 
        public ques():this(0) {
            
        }
        public ques(int num):this(num,"")
        {
           
        }
        public ques(int num, string body):this(num,body,0)
        {
            // Console.WriteLine($"number of ques :-{num} ++\n ques:-{body}++");
            
            
        }

        public ques(int num, string _body,int mark) 
        {
            this.num = num;
            
            this.body = _body;
            this.mark = mark;
        }
        public abstract void Print();
        
        
    }
     class mcq :ques {
        public String [] arr;
        public String [] Arr {
            get { return arr; }
            set { arr = value; }  
        }

        public mcq(int num, String body, int mark) : base(num, body, mark) { }
        public override void Print()
        {
            Console.WriteLine($"{num}==>{body} \nAnsewrs:-\nA-{arr[0]}\nB-{arr[1]}\nc-{arr[2]} \nmark:- {mark}");

        }
    }
    class TrueOrFalse:ques{

        public TrueOrFalse(int num, String body, int mark) : base(num, body, mark) { }
        public override void Print() 
        {
            Console.WriteLine( $"{num}==>{body}\nAnsewrs:-\n(True / False)\nmark:- {mark}");

        }
    }

}