// Getting Started - Gratest Common Divisor
// http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=ALDS1_1_B
using System;
using System.Linq;

namespace ALDS1_1_B {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			var A = Input				// Array : x, y
					.Split(' ')
					.Select(i => int.Parse(i))
					.ToArray();
			
			Output(gcd(A).ToString());
		}
		
		String Input {
			get {
				return Console.ReadLine();
			}
		}
		
		void Output(String str) {
			Console.WriteLine(str);
		}
		
		int gcd(int[] A) {
			return A[1] == 0 ? A[0] : gcd(new int[] {A[1], A[0] % A[1]});
		}
	}
}