namespace lab5.zadanie1
{
	public class Square : Shape
	{
		public double A; 
		public Square(double a)
		{
			A = a;
		}

        public override void CalulateArea()
        {
			double area = A * A;
			Console.WriteLine(area);
			
        }
    }
    
}

