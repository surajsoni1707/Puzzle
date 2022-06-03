using System;
using System.Collections;

namespace Puzzle
{
    class JavaQuestions
    {
        public int score=0;
        ArrayList al = new ArrayList();
        ArrayList Q1op = new ArrayList();
        ArrayList Q2op = new ArrayList();
        ArrayList Q3op = new ArrayList();
        ArrayList Q4op = new ArrayList();
        ArrayList Q5op = new ArrayList();
        SortedList sl = new SortedList();
        public void AddJavaQuestions()
        {
            al.Add("\tQ1.Which of the following option leads to the portability and security of Java?");
           
            Q1op.Add("\t\t1.Bytecode is executed by JVM");
            Q1op.Add("\t\t2.The applet makes the Java code secure and portable");
            Q1op.Add("\t\t3.Use of exception handling");
            Q1op.Add("\t\t4.Dynamic binding between objects");
            Q1op.Add(1);

            al.Add("\tQ2.Which of the following is not a Java features?");            
            Q2op.Add("\t\t1.Dynamic");
            Q2op.Add("\t\t2.Architecture Neutral");
            Q2op.Add("\t\t3.Use of pointers");
            Q2op.Add("\t\t4.Object-oriented");
            Q2op.Add(3);

            al.Add("\tQ3._____ is used to find and fix bugs in the Java programs.");
            Q3op.Add("\t\t1.JVM");
            Q3op.Add("\t\t2.JRE");
            Q3op.Add("\t\t3.JDK");
            Q3op.Add("\t\t4.JDB");
            Q3op.Add(4);

            al.Add("\tQ4.What is the return type of the hashCode() method in the Object class?");
            Q4op.Add("\t\t1.Object");
            Q4op.Add("\t\t2.int");
            Q4op.Add("\t\t3.long");
            Q4op.Add("\t\t4.void");
            Q4op.Add(2);

            al.Add("\tWhat does the expression float a = 35 / 0 return?");
            Q5op.Add("\t\t1.0");
            Q5op.Add("\t\t2.Not a Number");
            Q5op.Add("\t\t3.Infinity");
            Q5op.Add("\t\t4.Run time exception");
            Q5op.Add(3);

            sl.Add(al[0], Q1op);
            sl.Add(al[1], Q2op);
            sl.Add(al[2], Q3op);
            sl.Add(al[3], Q4op);
            sl.Add(al[4], Q5op);

        }
        public void ShowQuestions()
        {
            int count = 0;
            foreach(dynamic d in sl)
            {
                dynamic k = sl.GetKey(count);
                Console.WriteLine(k);
                Console.WriteLine();
                PrintOption(sl[k]);
                Console.WriteLine();
                
                count++;
                Console.WriteLine();
                Console.WriteLine();

            }
        }
        public void PrintOption(dynamic dd)
        {
            for(int i=0;i<dd.Count-1;i++)
            {
                Console.WriteLine(dd[i]);
            }
            Console.WriteLine("Enter Answer:");
            int n=GetAnswer();
           
            if(n==dd[dd.Count-1])
            {
                score++;
                
            }
        }
        public int GetAnswer()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            
            if (n < 1 || n > 4)
            {
                Console.WriteLine("Enter Valid Option:");
                return GetAnswer();
            }
           
                return n;
          

        }


    }

    class CSharpQuestion
    {
        public int score = 0;
        ArrayList al = new ArrayList();
        ArrayList Q1op = new ArrayList();
        ArrayList Q2op = new ArrayList();
        ArrayList Q3op = new ArrayList();
        ArrayList Q4op = new ArrayList();
        ArrayList Q5op = new ArrayList();
        SortedList sl = new SortedList();
        public void AddCSharpQuestions()
        {
            al.Add("\tQ1.Which of the following converts a type to a single Unicode character, where possible in C#?");            
            Q1op.Add("\t\t1.ToSingle");
            Q1op.Add("\t\t2.ToByte");
            Q1op.Add("\t\t3.ToChar");
            Q1op.Add("\t\t4.ToDateTime");
            Q1op.Add(3);

            al.Add("\tQ2.Which of the following converts a type to a string in C#?");
            Q2op.Add("1.ToInt64");
            Q2op.Add("2.ToSbyte");
            Q2op.Add("3.ToSingle");
            Q2op.Add("4.ToString");
            Q2op.Add(4);

            al.Add("\tQ3. CLR means __________ ?");
            Q3op.Add("\t\t1.Common Local Runtime");
            Q3op.Add("\t\t2.Common Language Runtime");
            Q3op.Add("\t\t3.Common Language Realtime");
            Q3op.Add("\t\t4.Common Local Realtime");
            Q3op.Add(2);

            al.Add("\tQ4. What does the term “boxing” mean in .net?");
            Q4op.Add("\t\t1.Convert value type to object");
            Q4op.Add("\t\t2.Convert reference type to value type");
            Q4op.Add("\t\t3.Convert the primitive type into a value type");
            Q4op.Add("\t\t4.None of the above");
            Q4op.Add(1);

            al.Add("\tQ5. Which of the following types can hold a value of any size?");
            Q5op.Add("\t\t1.Int32");
            Q5op.Add("\t\t2. Double");
            Q5op.Add("\t\t3.Long");
            Q5op.Add("\t\t4.BigInteger");
            Q5op.Add(1);

            sl.Add(al[0], Q1op);
            sl.Add(al[1], Q2op);
            sl.Add(al[2], Q3op);
            sl.Add(al[3], Q4op);
            sl.Add(al[4], Q5op);

        }
        public void ShowQuestions()
        {
            int count = 0;
            foreach (dynamic d in sl)
            {
                dynamic k = sl.GetKey(count);
                Console.WriteLine(k);
                PrintOption(sl[k]);
                Console.WriteLine();                
                count++;
                Console.WriteLine();
                Console.WriteLine();

            }
        }
        public void PrintOption(dynamic dd)
        {
            for (int i = 0; i < dd.Count - 1; i++)
            {
                Console.WriteLine(dd[i]);
            }
            Console.WriteLine("Enter Answer:");
            int n = GetAnswer();

            if (n == dd[dd.Count - 1])
            {
                score++;
            }
        }
        public int GetAnswer()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1 || n > 4)
            {
                Console.WriteLine("Enter Valid Option:");
                return GetAnswer();
            }
            return n;

        }

    }
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("\t\t\t\t Hello " + name + ", Lets Play A Quiz...");
            Console.WriteLine();
            Console.WriteLine("Press 1 For Java Quiz \nPress 2 for c# Quiz");
            int choice = GetChoice();
            Console.WriteLine();
            JavaQuestions jq = new JavaQuestions();
            CSharpQuestion cq = new CSharpQuestion();
            switch (choice)
            {
                case 1:
                    jq.AddJavaQuestions();
                    jq.ShowQuestions();
                    Console.WriteLine("Your Score Is:" + jq.score);
                    break;

                case 2:
                    cq.AddCSharpQuestions();
                    cq.ShowQuestions();
                    Console.WriteLine("Your Score Is:" + cq.score);
                    break;
            }
        }
             public static int GetChoice()
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice<1 || choice>2)
                {
                    Console.WriteLine("Envalid");
                    Console.WriteLine("Press 1 For Java Quiz \nPress 2 for c# Quiz");
                choice = 0;
                    return GetChoice();
                }
                
                return choice;
            }
            
          
            
            
        
    }
}
