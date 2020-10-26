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
		public T value = default(T);
		public Node next = null;
		public Node(T val)
		{
			value = val;
		}

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

	/// <summary>
	/// Removes head elements of queue
	/// </summary>
	/// <returns>The value of the removed node</returns>
	public T Dequeue()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			var value = head.value;
			head = head.next;
			count -= 1;
			return value;
		}
	}

	/// <summary>
	/// Gets value of the first node
	/// </summary>
	/// <returns>The value of the head node, or the default of datatype</returns>
	public T Peek()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			return head.value;
		}
	}

	/// <summary>
	/// Prints out the entirety of the queue
	/// </summary>
	public void Print()
	{
		Node current = head;
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
		}
		else
		{
			while (current != null)
			{
				Console.WriteLine(current.value);
				current = current.next;
			}
		}
	}
}