using System;
using System.Collections.Generic;

/// <summary>
/// Base class for any object
/// </summary>
public abstract class Base
{
    /// <summary>
    /// The name object for any inherited object
    /// </summary>
    /// <value></value>
    public string name{ get; set; }
    
    /// <summary>
    /// Override method for to string
    /// </summary>
    /// <returns>String representation of the object</returns>
    public override string ToString()
    {
        return ($"{name} is a {this.GetType()}");
    }
}

/// <summary>
/// Interface for interactable objcts
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Basic placeholder for the interact function
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface for object durability 
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Durability represented by an int
    /// </summary>
    /// <value>Any int the function sets</value>
    int durability{ get; set; }

    /// <summary>
    /// Placeholder empty implentation of Break
    /// </summary>
    void Break();
}

/// <summary>
/// Interface for collectables
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Bool value for collected or not
    /// </summary>
    /// <value>True or false</value>
    bool isCollected{ get; set; }

    /// <summary>
    /// Placeholder implementation of collect
    /// </summary>
    void Collect();
}

class Door : Base, IInteractive
{
    public Door(string val = "Door")
    {
        this.name = val;
    }
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", this.name);
    }
}

class Decoration : Base, IInteractive, IBreakable
{
    public int durability { get; set; }
    public bool isQuestItem;

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        else
        {
            this.name = name;
            this.durability = durability;
            this.isQuestItem = isQuestItem;
        }
    }

    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine("The {0} has been broken.", this.name);
        else if (isQuestItem == true)
            Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
        else
            Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
    }

    public void Break()
    {
        durability -= 1;

        if (durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", this.name);
        else if (durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", this.name);
        else
            Console.WriteLine("The {0} is already broken.", this.name);
    }
}

class Key : Base, ICollectable
{
    public bool isCollected{ get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine("You pick up the {0}.", this.name);
        }
        else if (isCollected == true)
        {
            Console.WriteLine("You have already picked up the {0}.", this.name);
        }
    }
}

class RoomObjects
{
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var element in roomObjects)
        {
            if (type == typeof(IInteractive))
            {
                IInteractive inter = element as IInteractive;
                if (inter != null)
                    inter.Interact();
            }

            if (type == typeof(ICollectable))
            {
                ICollectable inter = element as ICollectable;
                if (inter != null)
                    inter.Collect();
            }

            if (type == typeof(IBreakable))
            {
                IBreakable inter = element as IBreakable;
                if (inter != null)
                    inter.Break();
            }
        }
    }
}