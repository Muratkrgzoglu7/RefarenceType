using System;

namespace RefarenceTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			//int sayi1 = 10;
			//int sayi2 = 20;
			//sayi1 = sayi2;
			//sayi2 = 100;
			//Console.WriteLine("sayi1 = "+sayi1); //?

			//int[] sayilar1 = new int[] { 1, 2, 3 };
			//int[] sayilar2 = new int[] { 10, 20, 30 };
			//sayilar1 = sayilar2;
			//sayilar2[0] = 1000;
			//Console.WriteLine("sayilar1[0] = "+sayilar1[0]); //?

			//Person person1 = new Person();
			//Person person2 = new Person();
			//person1.FirstName = "Engin";
			//person1 = person2;
			//person1.FirstName = "Derin";

			//Console.WriteLine(person2.FirstName);

			Costomer costomer = new Costomer();
			costomer.FirstName = "Salih";
			costomer.CreditCartNumber = "5154111";
			

			Employee employee =new Employee();
			employee.FirstName = "Veli";
			Person person3 = costomer;
			person3.FirstName = "Murat";



			//Console.WriteLine(((Costomer)person3).CreditCartNumber);
			ProductManager productManager = new ProductManager();
			productManager.Add(costomer);
		}
		class Person
		{
			public int Id { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }
		}
		class Costomer : Person
		{
			public string CreditCartNumber { get; set; }

		}
		class Employee : Person
		{
			public string EmployeeNumber { get; set; }
		}
		class ProductManager 
		{
			public void Add(Person person)
			{
				Console.WriteLine(person.FirstName);
			}
		}
	}
}
