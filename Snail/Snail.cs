namespace Snail;

public class Snail(int arraySize)
{
	public readonly List<int> Result = [];
	private int _horizontal;
	private int _vertical;
	
	public int ConsumedCount => Result.Count;

	private bool _goingRight = true;

	public void MoveToNext()
	{
		if (_goingRight && _horizontal >= arraySize - 1)
		{
			_vertical++;
			_goingRight = false;
		} 
		else if (_goingRight)
			_horizontal++;
		else
			_horizontal--;
	}

	public void ConsumeNumber(int[][] ints) => 
		Result.Add(ints[_vertical][_horizontal]);
}