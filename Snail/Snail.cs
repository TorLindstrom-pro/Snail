namespace Snail;

public class Snail(int arraySize)
{
	public readonly List<int> Result = [];
	private int _horizontal;
	private int _vertical;
	private int _length = arraySize;
	
	public int ConsumedCount => Result.Count;

	private string _direction = "right";
	private int _lap;

	public void MoveToNext()
	{
		switch (_direction)
		{
			case "right":
				_horizontal++;
				
				if (_horizontal + _lap == _length - 1)
					_direction = "down";
				break;
			case "down":
				_vertical++;
				
				if (_vertical + _lap == _length - 1)
					_direction = "left";
				break;
			case "left":
				_horizontal--;
				
				if (_horizontal == 0)
					_direction = "up";
				break;
			case "up":
				_vertical--;
				
				if (_vertical == 0)
				{
					_lap++;
					_length--;
					_direction = "right";
				}
				break;
		}
	}

	public void ConsumeNumber(int[][] ints) => 
		Result.Add(ints[_vertical + _lap][_horizontal + _lap]);
}