using System;

namespace ConsoleApp_Demo1_DellDec
{
	interface Idefautlinterface
	{
		public void defaultmethod()
		{
            Console.WriteLine("default method in interface");
        }
	}

	class A : Idefautlinterface
	{

	}
	class MyClass
	{
		static void Main(string[] args)
		{
            Idefautlinterface obj= new A();
			obj.defaultmethod();

			Console.ReadLine();




		}
	}
}
