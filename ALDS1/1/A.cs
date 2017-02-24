// Getting Started - Insertion Sort
// http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=ALDS1_1_A&lang=jp
using System;
using System.Linq;

namespace ALDS1_1_A {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			var N = int.Parse(Input);	// Number of elements
			var A = Input				// Array : N elements
					.Split(' ')
					.Select(i => int.Parse(i))
					.ToArray();
			
			Output(A.Select(i => i.ToString())
					.Aggregate((i, j) => i + " " + j));
		}
		
		String Input {
			get {
				return Console.ReadLine();
			}
		}
		
		void Output(String str) {
			Console.WriteLine(str);
		}
	}
}