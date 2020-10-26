using System;

/// <summary>
/// Custom implementation of a Queue in C#
/// </summary>
/// <typeparam name="T">And given parameter</typeparam>
class Queue<T>
{
	public Node head;
	public Node tail;
	public int count;

	/// <summary>
	/// Each node of the Queue
	/// </summary>
	public class Node
	{
		T value = default(t);
		Node next = null;
		public Node value{get; set;}

	}

	/// <summary>
	/// Checks the type of the calling queue/node
	/// </summary>
	/// <returns>Returns the type of the queue</returns>
	public Type CheckType()
	{
		return typeof(T);
	}

	/// <summary>
	/// Adds a node to a linked list queue
	/// </summary>
	/// <param name="value">The value of the node to add</param>
	public void Enqueue(T value)
	{
		Node newNode = new Node(value);
	
		if(head == null)
		{
			head = newNode;
			tail = newNode;
		}
		else
		{
			tail.next = newNode;
			tail = newNode;
		}
		count += 1;
	}

	/// <summary>
	/// Retreives the amount of entries in the queue
	/// </summary>
	/// <returns>INT count of entries</returns>
	public int Count()
	{
		return count;
	}
}