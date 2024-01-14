namespace lab5.zadanie1
{
	public class Circle : Shape
	{
		public double Radius;

		public Circle(double radius)
		{
			Radius = radius;
		}
        public override void CalulateArea()
        {
			double area = Math.PI * Radius * Radius;
            Console.WriteLine(area);

        }
    }
}

