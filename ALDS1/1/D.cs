// Getting Started - Maximum Profit
// http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=ALDS1_1_D
using System;
using System.Linq;

namespace ALDS1_1_D {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			var N = int.Parse(Input);	// Number of elements
			int min = int.Parse(Input);
			int max = -min;
			
			for(int i = 1; i < N; i ++) {
				int r = int.Parse(Input);
				if(max < r - min) max = r - min;
				if(min > r) min = r;
			}
			
			Output(max.ToString());
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