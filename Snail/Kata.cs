namespace Snail;

public static class Kata
{
	public static int[] Snail(int[][] ints)
	{
		var result = new List<int>();
   		var (horizontal, vertical) = (0, 0);
	    var goingRight = true;

	    var totalCount = ints
		    .SelectMany(number => number)
		    .Count();
	    
	    while (result.Count < totalCount)
	    {
		    result.Add(ints[vertical][horizontal]);
		    if (horizontal >= ints.Length - 1 && goingRight)
		    {
			    vertical++;
			    goingRight = false;
		    } 
		    else if (goingRight) horizontal++;
		    else horizontal--;
	    }

	    return result.ToArray();
	}
}
