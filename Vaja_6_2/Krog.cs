using System;

	class Krog
	{
		private int r;


		public Krog()
		{
			r = 1;
		}
		public Krog(int r)
		{
			this.r = r;
		}

		public double Ploscina()
		{
			const int pi = 3,14;
			int obseg = 2 * pi * r;
			return obseg;
		}

		public double Obseg()
		{
			const int pi = 3,14;
			return (pi * (r * r));
		}
	}

