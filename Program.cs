////using System;

////namespace ConsoleApp_csharp8demo
////{
////    interface IDefaultinterface
////    {
////        public void defaultmethod()
////        {
////            Console.WriteLine("i am in Idefaultinterface----defaultmethod");
////        }
////    }

////    class A : IDefaultinterface 
////    {

////    }

////    internal class Program
////    {
////        static void Main(string[] args)
////        {
////          IDefaultinterface obj= new A();
////          obj.defaultmethod();

////            Console.ReadLine();
////        }
////    }
////}

//// c# 8.0 features
//// null reference type


//using System;
//using System.Security.Cryptography.X509Certificates;

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        //string? msg = null;

//        //Console.WriteLine("length of string is : "+msg.Length);

//        //string? x = msg;
//        //msg = "hello dell team";

//        //Console.WriteLine("length of string is : " + msg.Length);

//        //Console.WriteLine(x.Length);

//        //string message = "welcome to c#8";
//        //int length = message.Length;
//        //Console.WriteLine(length);
//        //===========================================================================
//        // string msg = null;
//        // if(!string.IsNullOrEmpty(msg))
//        // {
//        //     Console.WriteLine("Lenth of the message is : "+ msg.Length);
//        // }

//        // var x = msg;
//        // msg = "welcome to Dell team";

//        // Console.WriteLine("Length of the message is : " + msg.Length);

//        //// Console.WriteLine("Length of the message is : " + x.Length);
//        //==============================================================================

//        string? msg = null;
//        Console.WriteLine(msg.Length);

//        public string Name { get;set; }

//        public string? namewithnull { get; set; }



//        Console.ReadLine();

//    }
//}

//==================Null coalescing assignment operator in c# 8.0

using System;

class MyClass
{
    static void Main(string[] args)
    {
        int? age = null;
        age ??= 25;
        Console.WriteLine("Age is : "+  age);


    }
}