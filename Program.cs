using System;

public class Test
{
	public static void Main()
	{
        
		int n = int.Parse(Console.ReadLine());
		if (n > 1000000)
        {
			return;
		}
		int[] a=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		
		int k=int.Parse(Console.ReadLine());
		int b;
		
		for(int i = 0; i < n-k+1; i++)
        {
			b = a[i];
			for (int j = 0; j < i + k; j++)
			{
				if (b < a[j])
                {
					b=a[j];
                }
			}
			Console.Write( b+ " ");

		}
        
	}
}