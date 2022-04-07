using System;

public class Test
{
	public static void Main()
	{
        
		int n = int.Parse(Console.ReadLine());
		if (n > 1000000)
        {
			n = 0;
		}
		int[] k = new int[n+1];
		for (int i = 0; i < n; i++)
		{
			
			k[i] = int.Parse(Console.ReadLine());
		}
		int a=int.Parse(Console.ReadLine());
		int b = a;
		
		
		for(int i = 0; i < n; i++)
        {

			if (a <= k[i])
			{
				 if (a == k[i])
				{
					Console.Write(b + " ");
					a = k[i + 1];
				}
				 if (a > b)
                {
					b = a;
                }
                
			}
        }
        
	}
}