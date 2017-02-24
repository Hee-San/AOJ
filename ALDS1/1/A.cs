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
			
			for(int i = 1; i < N; i++) {
				int target = A[i];
				int j = i;
				
				for(; j > 0 && target <= A[j-1]; j--)
					A[j] = A[j-1];
				A[j] = target;
				
				Output(A.Select(s => s.ToString())
						.Aggregate((s, t) => s + " " + t));
			}
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