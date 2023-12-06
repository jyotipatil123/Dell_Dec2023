////// See https://aka.ms/new-console-template for more information

////global using static System.Math;
//global using System;
////global using static System.Console;

////Console.WriteLine("Hello, World!");

////int a = 10;
////int b = 10;
////Console.WriteLine("Addition result is "+(a+b));
////Console.WriteLine("Subtraction result is " + (a - b));
////Console.WriteLine("Multiplication result is " + (a * b));
////Console.WriteLine("Division result is " + (a / b));

////mainclass1 obj = new mainclass1();
////obj.function1();

////============================================================


////A.namespacedemo1 obj1 = new A.namespacedemo1();
////B.namespacedemo2 obj2 = new B.namespacedemo2();
////C.namespacedemo1 obj3 = new C.namespacedemo1();

////obj1.function1();
////obj2.function2();
////obj3.function3();

////=================================================================

//string name = "shilpa";
//int age = 25;
//string msg = $"welcome {name} for C# training ,I know your age is :{age}";
//Console.WriteLine(msg);


//const string s1 = "hello";
//Console.WriteLine(s1);

//const string s2 = $"hello...";
//Console.WriteLine(s2);

//const string s3 = $"hello....{" "} world";
//Console.WriteLine(s3);

//const string s4 = $"{s1}====>shilpa and team";
//Console.WriteLine(s4);

//==============================================================================

// c# 10.0 features
// lamda improvements

Action<string, ConsoleColor> writecolor = (string s1, ConsoleColor color) =>
{
    var c1 = Console.ForegroundColor;
    Console.ForegroundColor = color;
    Console.WriteLine(s1);

    Console.ForegroundColor = c1;
};

Func<string, string> upper=(string s)=> s.ToUpper();

writecolor("welcome", ConsoleColor.Red);
Console.WriteLine(upper("this is default color"));
writecolor("bye", ConsoleColor.Green);   
