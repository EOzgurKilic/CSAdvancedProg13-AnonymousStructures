using Microsoft.VisualBasic;

namespace CSAdvancedProg13_AnonymousStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Anonymous Structures
            //Although they are costly, this cost can be ignored in certain situations.


            //Anonymous Types (Objects)
            //Declaration
            var AnonObj1 = new { Property1 = "Auch", Property2 = 35, Property3 = true, Property4 = ("Rick", "and", "Morty"), Delegate1 = new Action<int>(ExpMethod1<int>) };
            void ExpMethod1<t1>(t1 a){ Console.WriteLine("Thiss ExpMethod1"); }
            AnonObj1.Delegate1(2);


            //Anonymous Methods
            //Generally used with delegates
            //Declaration (You might not be familiar to Lambda expressions yet. DW)
            //There are three declaration ways with delegates, the initial two are based on Lambda expressions and the last one is the old anonymous method declaration way.
            Topla topla1 = new Topla((sayi1, sayi2) => sayi1 + sayi2);
            Topla topla2 =((sayi1, sayi2) => sayi1 + sayi2);
            Topla topla2_1 =(sayi1, sayi2) => { return sayi1 + sayi2; };
            Topla topla3 = delegate(int sayi1,int sayi2) { return sayi1 + sayi2; };
            //We can declare them via var keyword, the compiler selects a proper pre-defined delegate reference for it. (like func, predicate, action)
            var topla4 = (int sayi1, int sayi2) => sayi1 + sayi2; //Func is selected by the compiler for this one.
            var topla5 = () => { Console.WriteLine("Action delegate"); }; //Action
            var topla6 = () => { return true; };//Func selected but predicate fits this one too


            //Anonymous Collections
            //Arrays
            var x = new int[2,2] { {1,2},{3,4} };

            //Collections
            var y = new Collection()
            {
                new {a = 5},
                new {b = 5},
                new {c = 5},

            };
        }
        delegate int Topla(int a, int b);
    }
}
