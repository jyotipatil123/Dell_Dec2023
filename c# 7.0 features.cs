//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Console;

////namespace ConsoleApp_Demo1_DellDec
////{
////    class mainclass
////    {
////        static void Main(string[] args)
////        {

////            void Add(int a, int b)
////            {
////                WriteLine("Addition of 2 numbers{0} and {1} is : {a+b} ");
////            }

////			void Multiply(int a, int b)
////			{
////				WriteLine("Multiply of 2 numbers{0} and {1} is : {a*b} ");
////                Add(8, 2);
////			}

////            Add(10, 2);
////            Multiply(7, 2);

////		}
////    }
////}


////class mainclass
////{
////    static void Main(string[] args)
////    {
////        company[] companies = new company[3]
////        {
////            new company{name="infosys", salary=20200},
////			new company{name="dell", salary=40888},  
////            new company{name="ibm", salary=43999}
////		};

////        print(101, companies);

////        ReadLine();

////    }

////    public static void print(int empid, params company[] companies)
////    {
////        WriteLine($"Employee id : {empid} total salary : {calculatesalary()}");
////        WriteLine($"company details ");

////        foreach (company company in companies)
////        {
////            WriteLine($"company name : {company.name} salary : {company.salary}");
////        }

////        double calculatesalary()
////        {
////            double total = 0;
////            foreach (var item in companies)
////            {
////                total += item.salary;
////            }
////            return total;
////        }
////    }
////}

////public class company
////{
////    public string name { get; set; }    
////    public int  salary { get; set; }
////}

////==================================================

//// c# 7.0 featues 

//// pattern matching

////using System;

////class MyClass
////{
////	static void Main(string[] args)
////	{
////		var data1 = " customized data";
////		var data2 = data1 is string ? "string " : "Not a string ";
////		var data3 = data2 is string a ? a : "Not a string ";

////		WriteLine(data2);
////		WriteLine(data3);


////		//==============================

////		var x = 100;
////		dynamic y = 0b100;

////		var add = y is int ? $"{y * x}" : "Invalid data";
////		WriteLine(add);


////		ReadLine();



////	}
////}

//// c# 7.0 features
//// out variable 

////using System;
////using static System.Console;

////class MyClass
////{
////	static void Main(string[] args)
////	{
////		string date1 = "04-Decemberrrrrrr-2023";

////		if ( DateTime.TryParse(date1, out DateTime date2) ) 
////		{
////			WriteLine("Date 2 using out :"+date2);
////		}
////		WriteLine("Date 1 : "+date1);

////		ReadLine();
////	}
////}

//// c# 7.0 features

////tuples

////using System;

////class MyClass
////{
////	static void Main(string[] args)
////	{
////		OutputEncoding = Encoding.UTF8;

////		MyClass obj= new MyClass();
////		var price = obj.GetPrice(1);

////		WriteLine($"Price :Rs.{price.Item1}/- \n Discount: Rs.{price.Item2}/-");

////		ReadLine();
////	}
////	(int,int) GetPrice(int itemid)
////	{
////		var product = (500, 200);
////		return product;
////	}
////}

////==============================================

////c# 7.0 features
//// ref returns

////using System;
////using System.Security.Cryptography.X509Certificates;

////class mainclass
////{
////	static void Main(string[] args)
////	{
////		int[] arr = { 8, 6, 5, 12, 3, 456, 3, 64, 77 };

////		WriteLine("Array elements are : ");
////		foreach (var item in arr)
////		{
////			Console.WriteLine(item);
////        }


////        ref int GetFirstOddNumber(int[] numbers)
////		{
////			for (int i = 0; i < numbers.Length; i++)
////			{
////				if (numbers[i] % 2 == 1)
////				{
////					return ref arr[i];
////				}
////			}
////			throw new Exception("odd number does not exist");
////		}

////		GetFirstOddNumber(arr);

////		ref int oddnums= ref GetFirstOddNumber((int[])arr);

////		oddnums = 65;

////        WriteLine("Odd numbers : ");
////		WriteLine($"{oddnums}");

////        for (int i = 0; i < arr.Length; i++)
////		{
////			Console.WriteLine(arr[i]);
////        }

////		Console.ReadLine();
////	}
////}

////=============================

//// throw expression c# 7.0 features

//using System;

//class MyClass
//{
//	static void Main(string[] args)
//	{
//		divide(10, 0);

//		ReadLine();
//		// throw;
//		// throw ex;
//		// throw new exception;
//		// throw 0;



//	}

//	public static double divide(int a, int b)
//	{
//		return b !=0? a%b: throw new DivideByZeroException();
//	}
	
//}