namespace Snail;

public static class Kata
{
	public static int[] Snail(int[][] ints)
	{
	    var arraySize = ints[0].Length;
	    var totalCount = arraySize * arraySize;

	    var snail = new Snail(arraySize);

	    while (snail.ConsumedCount < totalCount)
	    {
		    snail.ConsumeNumber(ints);
		    snail.MoveToNext();
	    }

	    return snail.Result.ToArray();
	}
}
