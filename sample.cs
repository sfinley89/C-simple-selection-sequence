{
			string Rest = "You should rest and get over your cold before exercising.";
			string Exercise = "GO EXERCISE!!!";
			string userAnswer;
			string want;

			Console.WriteLine ("Do you want to exercise today?");
			want = Console.ReadLine ();
			if (want == "no" | want == "No") {
				Console.WriteLine ("Ok, maybe tomorrow");
				System.Threading.Thread.Sleep(3000);
				System.Environment.Exit (1);
			}

			Console.WriteLine ("Are  you still sick?");
			userAnswer = Console.ReadLine ();
			if (userAnswer == "Yes" | userAnswer == "maybe" | userAnswer == "y" | userAnswer == "yes" | userAnswer == "yea") { 
				Console.WriteLine (Rest);
			} else {
				Console.WriteLine (Exercise);
			}
		}
