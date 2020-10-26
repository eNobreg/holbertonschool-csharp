using System;

class Queue<T>
{
	/// <summary>
	/// Checks the type of the calling queue/node
	/// </summary>
	/// <returns>Returns the type of the queue</returns>
	public Type CheckType()
	{
		return typeof(T);
	}
}