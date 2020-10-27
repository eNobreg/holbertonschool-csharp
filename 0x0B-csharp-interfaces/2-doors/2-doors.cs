using System;

/// <summary>
/// Base class for any object
/// </summary>
abstract class Base
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
