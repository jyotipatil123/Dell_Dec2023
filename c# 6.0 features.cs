////// c# 6.0 features 
////// static keyword in namespace 

////using System;
////using static System.Convert;
////using static System.Console;

////namespace ConsoleApp_Demo1_DellDec
////{
////    internal class Program
////    {
////        static void Main(string[] args)
////        {
////            WriteLine("Enter first number : ");
////            int v1= ToInt32(ReadLine());

////            WriteLine("Enter second number : ");
////            int v2 = ToInt32(ReadLine());

////            WriteLine("Addition result is :"+(v1+v2));

////            ReadLine();
////        }
////    }
////}


////==========================================
//// Auto property initializer

////c# 5.0

////using System;
////namespace A
////{
////    class Employee
////    {
////        public string Name { get; set; }
////        public int Age { get; set; }
////        public int Salary { get; set; }

////        public Employee()
////        {
////            Name = "Neerja";
////            Age = 25;
////            Salary = 259009;
////        }

////    }

////    class mainclass
////    {
////        static void Main(string[] args)
////        {
////            Employee obj= new Employee();
////            Console.WriteLine(obj.Name);
////            Console.WriteLine(obj.Age);    
////            Console.WriteLine(obj.Salary);


////            Console.ReadLine();


////        }
////    }
////}

//// c# 6.0 features 

////using System;
////namespace A
////{
////    class Employee
////    {
////        public string Name { get; set; } = "neerja";
////        public int Age { get; set; } = 25;
////        public int Salary { get; set; } = 2588788;
////    }

////    class mainclass
////    {
////        static void Main(string[] args)
////        {
////            Employee obj = new Employee();
////            Console.WriteLine(obj.Name);
////            Console.WriteLine(obj.Age);
////            Console.WriteLine(obj.Salary);

////            Console.ReadLine();
////        }
////    }
////}

////=============================================================

////3. Dictiionary initializer

////c# 5.0

////using System;
////using System.Collections.Generic;

////class MyClass
////{
////    static void Main(string[] args)
////    {
////        Dictionary<string, string> dic1 = new Dictionary<string, string>()
////        {
////            {"neerja","gokul" },
////            {"phani","rajesh" },
////            {"regina","sahil" }
////        };

////        dic1["dell"] = "Bangalore";
////        foreach (var item in dic1)
////        {
////            Console.WriteLine(item.Key+"     "+item.Value);
////        }
////        Console.WriteLine("=======================================");

////        Dictionary<int, string> dic2 = new Dictionary<int, string>()
////        {
////            {10,"gokul" },
////            {11,"rajesh" },
////            {12,"sahil" }
////        };

////        dic2[14] = "shilpa";
////        foreach (var item in dic2)
////        {
////            Console.WriteLine(item.Key + "     " + item.Value);
////        }

////        Console.ReadLine();
////    }
////}


//// c# 6.0 features

////using System;
////using System.Collections.Generic;

////class MyClass
////{
////    static void Main(string[] args)
////    {
////        Dictionary<string, string> dic1 = new Dictionary<string, string>()
////        {
////            ["neerja"]="gokul",
////            ["phani"]="rajesh",
////            ["regina"]="sahil" 
////        };

////        dic1["dell"] = "Bangalore";

////        foreach (var item in dic1)
////        {
////            Console.WriteLine(item.Key + "     " + item.Value);
////        }
////        Console.WriteLine("=======================================");

////        Dictionary<int, string> dic2 = new Dictionary<int, string>()
////        {
////            [10]="gokul" ,
////            [11]="rajesh",
////            [12]="sahil" 
////        };

////        dic2[14] = "shilpa";
////        foreach (var item in dic2)
////        {
////            Console.WriteLine(item.Key + "     " + item.Value);
////        }

////        Console.ReadLine();
////    }
////}

////=================================================================


////4. nameof Expression 

////using System;
////using static System.Console;

////class Employee
////{
////    public string Name { get; set; } = "neerja";
////    public int Age { get; set; } = 25;
////    public int Salary { get; set; } = 2588788;
////}

////class MyClass
////{
////    static void Main(string[] args)
////    {
////        Employee employee = new Employee();

////        WriteLine("{0} ::  {1}", nameof(Employee.Name),employee.Name);
////        WriteLine("{0} ::  {1}", nameof(Employee.Age), employee.Age);
////        WriteLine("{0} ::  {1}", nameof(Employee.Salary), employee.Salary);

////        ReadLine();
////    }
////}

//// 5  Exception filters

////using System;
////using static System.Console;

////namespace A
////{
////	class MyClass
////	{
////		static void Main(string[] args)
////		{
////			int num1 = 0;
////			int num2 = 0;

////			try
////			{
////				WriteLine("Enter the first number : ");
////				num1 = int.Parse(ReadLine());

////                WriteLine("Enter the second number : ");
////                num2 = int.Parse(ReadLine());

////				WriteLine("Division result is :{0} ", (num1 / num2));
////            }
////			catch (Exception ex) when (num2==0)
////			{
////				WriteLine("Division by zero ........fails");
////			}
////			catch (Exception e) 
////			{
////				WriteLine(e.Message);
////			}
////			ReadLine();
////		}
////	}
////}

//// c# 6.0 features
////null conditional operator 

////using System;

////class Employee
////{
////    public string firstname { get; set; }
////    public Address address { get; set; }
////}

////class Address
////{
////    public string homeaddress { get; set; }
////    public string officeaddress { get; set;}
////}

////class mainclass
////{
////    static void Main(string[] args)
////    {
////        Employee employee = new Employee();
////        employee.firstname = "shilpa";

////        employee.address = new Address()
////        {
////            homeaddress = "2nd cross, 1st main",
////            officeaddress = "Bangalore"
////        };

////        //if( employee !=null && employee.address !=null)
////        //{
////        //    Console.WriteLine(employee.firstname+"   "+ employee.address.homeaddress+"  "+ employee.address.officeaddress);
////        //}
////        //else
////        //{
////        //    Console.WriteLine("No address is given");
////        //}

////        //Console.WriteLine(employee?.firstname+"  "+ employee?.address.officeaddress+ "  "+ employee?.address.homeaddress);

////        Console.WriteLine(employee?.firstname+"  "+ employee?.address.officeaddress??"there is no address");

////        Console.ReadLine();

////    }
////}

////===================================================

//// 7. string interpolation

//using System;
//using static System.Console;

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        string fn = "shilpa";
//        string ln = "gupta";

//        //string result = string.Format("{0}===>{1}", fn, ln);
//        //Console.WriteLine(result);

//        // in c# 6.0 

//        //string result = $"{fn}\";
//        //Console.WriteLine(result);

//        double a = 3;
//        double b = 4;
//        Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b}");
//        Console.WriteLine($"Length of the hypotenuse of the right triangle with legs of {a} and {b} is {CalculateHypotenuse(a, b)}");
//        double CalculateHypotenuse(double leg1, double leg2) => Math.Sqrt(leg1 * leg1 + leg2 * leg2);

//        string name = "John";
//        int age = 30;
//        string message = $"My name is {name} and I am {age} years old.";


//        Console.ReadLine();


//    }
//}