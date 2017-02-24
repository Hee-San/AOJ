// Getting Started - Prime Numbers
// http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=ALDS1_1_C
using System;
using System.Linq;

namespace ALDS1_1_C {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			var N = int.Parse(Input);	// Number of elements
			int count = 0;
			for(int i = 0; i < N; i ++)
				if(isPrime(int.Parse(Input))) count++;
			
			Output(count.ToString());
		}
		
		String Input {
			get {
				return Console.ReadLine();
			}
		}
		
		void Output(String str) {
			Console.WriteLine(str);
		}
		
		bool isPrime(int p) {
			if(p == 2) return true;
			if(p < 2 || p % 2 == 0) return false;
			
			for(int i = 3; i * i <= p; i += 2)
				if(p % i == 0) return false;
			return true;
		}
	}
}