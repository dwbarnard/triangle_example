// Dave B.

using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            
			for (int triangleIndex = 1; triangleIndex < 10; triangleIndex++)	// will be the char displayed in the triangles
			{
				for (int digitIndex = 1; digitIndex <= triangleIndex; digitIndex++)	// how many lines per triangle
				{
					for (int lineIndex = 1; lineIndex <= digitIndex; lineIndex++)	// how many chars on each line
					{
						Console.Write(triangleIndex);
					}
					Console.WriteLine();
				}
				Console.WriteLine();
			}

			// keep console open until a key is pressed
			while (true)
			{
				if (Console.KeyAvailable)
				{
					break;	// out of while loop
				}
			}
        }
    }
}
