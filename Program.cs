using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		class RationalNumber
		{
			private int N;
			private int M;

			public RationalNumber()
			{
				N = 0;
				M = 0;
			}

			public RationalNumber(int n, int m)
			{
				N = n;
				M = m;
			}

			public RationalNumber(string s)
			{
				string[] result = s.Split();
				N = Convert.ToInt32(result[0]);
				M = Convert.ToInt32(result[1]);
			}

			public void Print()
			{
				Console.WriteLine("{0}/{1}",N,M);
			}

			public static implicit operator int(RationalNumber rationalNumber)
			{
				return rationalNumber.N / rationalNumber.M;
			}

			public static explicit operator double(RationalNumber rationalNumber)
			{
				return rationalNumber.N / rationalNumber.M;
			}

			public static RationalNumber operator +(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
			{
				RationalNumber result = new RationalNumber();
				result.N = (rationalNumber1.N * rationalNumber2.M) + (rationalNumber2.N * rationalNumber1.M);
				result.M = rationalNumber1.M * rationalNumber2.M;
				return result;
			}

			public static RationalNumber operator -(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
			{
				RationalNumber result = new RationalNumber();
				result.N = (rationalNumber1.N * rationalNumber2.M) - (rationalNumber2.N * rationalNumber1.M);
				result.M = rationalNumber1.M * rationalNumber2.M;
				return result;
			}

			public static RationalNumber operator *(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
			{
				RationalNumber result = new RationalNumber();
				result.N = rationalNumber1.N * rationalNumber2.N;
				result.M = rationalNumber1.M * rationalNumber2.M;
				return result;
			}

			public static RationalNumber operator /(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
			{
				RationalNumber result = new RationalNumber();
				result.N = rationalNumber1.N * rationalNumber2.M;
				result.M = rationalNumber1.M * rationalNumber2.N;
				return result;
			}

			public static bool operator <(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
			{
				return rationalNumber1.N / rationalNumber1.M < rationalNumber2.N / rationalNumber2.M;
			}

			public static bool operator >(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
			{
				return rationalNumber1.N / rationalNumber1.M > rationalNumber2.N / rationalNumber2.M;
			}

			public int CompareTo(object obj)
			{
				RationalNumber rationalNumber1 = obj as RationalNumber;
				return (this.N / this.M).CompareTo(rationalNumber1.N / rationalNumber1.M);
			}

		}

		static void Main(string[] args)
		{
			Console.WriteLine("Введите первое число");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите второе число");
			int m = Convert.ToInt32(Console.ReadLine());
			RationalNumber rationalNumber1 = new RationalNumber(n,m);		
			RationalNumber rationalNumber2 = new RationalNumber("20 3");
			rationalNumber1.Print();
			rationalNumber2.Print();
			int intValue = rationalNumber1;
			double doubleValue = rationalNumber2;
			Console.WriteLine("Целая часть первого числа(int) {0}",intValue);
			Console.WriteLine("Целое часть второго числа(double) {0},", doubleValue);
			Console.WriteLine(rationalNumber1 + rationalNumber2);
			Console.WriteLine(rationalNumber1 - rationalNumber2);
			Console.WriteLine(rationalNumber1 * rationalNumber2);
			Console.WriteLine(rationalNumber1 / rationalNumber2);
			Console.WriteLine(rationalNumber1 < rationalNumber2);
			Console.WriteLine(rationalNumber1 > rationalNumber2);
			Console.WriteLine(rationalNumber1.CompareTo(rationalNumber2));
			Console.ReadKey();
		}
	}
}
