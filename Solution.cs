using System;

public class Test
{
	public static void Main()
	{
		int cases = int.Parse(Console.ReadLine());
		
		for(int c = 0; c < cases; c++){
		    int x = int.Parse(Console.ReadLine());
		    
		    int a = x - 1;
		    int b = x + 1;
		    
		    Console.WriteLine(a +" "+ x +" "+ b);
		}
	}
}
