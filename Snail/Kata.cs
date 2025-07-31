namespace Snail;

public static class Kata
{
	public static int[] Snail(int[][] ints) => ints
		.SelectMany(number => number)
		.ToArray();
}
