using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace jackolant {
	class Program {
		static void Main(string[] args) {
			new Jack().run();
		}
	}

	class Jack {
		public void run(){
			List<string> rows = new List<string>();
			Random rand = new Random();
			int cycle = 0;

			Console.WindowHeight = 40;
			Console.CursorVisible = false;
			using(StreamReader reader = new StreamReader("jack.txt")) {
				while(!reader.EndOfStream) {
					rows.Add(reader.ReadLine());
				}
			}
			while(true) {
				foreach(string s in rows) {
					foreach(char c in s) {
						if(c == '0') {
							Console.ForegroundColor = ConsoleColor.Black;
							Console.Write('#');
						}
						if(c == '1') {
							Console.ForegroundColor = ConsoleColor.Black;
							Console.Write('#');
						}
						if(c == '2') {
							Console.ForegroundColor = ConsoleColor.Green;
							Console.Write('#');
						}
						if(c == '3') {
							Console.ForegroundColor = ConsoleColor.DarkGreen;
							Console.Write('#');
						}
						if(c == '4') {
							Console.ForegroundColor = ConsoleColor.DarkMagenta;
							Console.Write('#');
						}
						if(c == '5') {
							Console.ForegroundColor = ConsoleColor.Magenta;
							Console.Write('#');
						}
						if(c == '6') {
							Console.ForegroundColor = ConsoleColor.Red;
							Console.Write('#');
						}
						if(c == '7') {
							Console.ForegroundColor = ConsoleColor.DarkYellow;
							Console.Write('#');
						}
						if(c == '8') {
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.Write('#');
						}
						if(c == '9') {
							Console.ForegroundColor = getCol(cycle);
							Console.Write('#');
						}
					}
					Console.WriteLine();
				}
				Console.SetCursorPosition(0, 0);
				//Thread.Sleep(rand.Next(200));
				cycle++;
			}
		}

		private ConsoleColor getCol(int seed) {
			if(seed % 3 == 1) {
				return ConsoleColor.Yellow;
			}
			if(seed % 3 == 2) {
				return ConsoleColor.DarkYellow;
			}
			return ConsoleColor.Black;
		}
	}
}
