using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            var test = GetOperationOneAsync().Result;
            Console.WriteLine(SqlConnectinclass.connection);
            Console.WriteLine(SqlConnectinclass.connection);
            string name = "hEmanTh";
            name = name.ToTitle();
            //a obj1 = new a();

            //b obj2 = new b();
            //a obj3 = new b();
            //obj3.method1();
            //  b obj4 = new a(); child class cant refer parent class -boz we creat parant class memory   so b class method not present.





            //var areequal = AreEqual<string>("abcd", "abc");
            //IServiceProvider obj = new Jio();
            //IServiceProvider obj1 = new Idea();
            //IServiceProvider obj2 = new Airtel();
            //Mycompany my = new Mycompany();
            ////my.checkvirusandsend(obj);
            //Parallel.Invoke(
            //    () => { my.checkvirusandsend(obj); },
            //    () => { my.checkvirusandsend(obj1); },
            //    () => { my.checkvirusandsend(obj2); }
            //    );
            //await myasync();
            Console.WriteLine("Main thread execution");
            //myclass.mtstr = "";
            //IServiceProvider obj = new Airtel();
        }

        public static bool AreEqual<T>(T i, T j)
        {
            return i.Equals(j);
        }

        private static async Task<int> GetOperationOneAsync()
        {
            await Task.Delay(10000);
            return 10;
        }

    }
    public static class AngularPipes
    {
        public static string ToTitle(this string str)
        {
            var firstchar = str[0].ToString().ToUpper();
            var len = str.Length;
            var lastchar = str.Substring(1, len-1).ToLower();
            return firstchar + lastchar;
        }
    }
    static class SqlConnectinclass
    {
        public static string connection = "";
        static  SqlConnectinclass()
        {
            connection = "actual connection string";
        }
       
    }
    class Mycompany
    {
        public void checkvirusandsend(IServiceProvider obj)
        {
            //fgrs
            obj.send();
        }
    }

    interface IServiceProvider
    {
        void send();
    }

    class Idea : IServiceProvider
    {
        public void send()
        {
            Console.WriteLine("Idea send code");

        }
    }
    class Airtel : IServiceProvider
    {
        public void send()
        {
            Console.WriteLine("Airtel send code");
        }
    }
    class Jio : IServiceProvider
    {
        public void send()
        {
            Console.WriteLine("Jio send code");
        }
    }
    class a
    {
        public a()
        {
            Console.WriteLine("parent constror");
        }
        public void method1()
        {
            Console.WriteLine("method1");
        }
        public virtual int MyProperty()
        {
            return 1;
        }
    }

    class b : a
    {
        public b()
        {
            Console.WriteLine("child constror");
            
        }
        
        public override int MyProperty()
        {
            
            return 1;
        }
    }


}
