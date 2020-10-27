using System;

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

/// <summary>
/// Exactly what the name implies, a test class for interfaces
/// </summary>
public class TestObject : Base, ICollectable, IInteractive, IBreakable
{
    /// <summary>
    /// The usable durability for the object
    /// </summary>
    /// <value>Any number</value>
    public int durability{ get; set; }

    /// <summary>
    /// The usable collection parameter
    /// </summary>
    /// <value>True or false value</value>
    public bool isCollected{ get; set; }

    /// <summary>
    /// The implementation of the collect method
    /// </summary>
    public void Interact()
    {
        // Empty Function
    }

    /// <summary>
    /// Implementation of the break method
    /// </summary>
    public void Break()
    {
        // Empty Function
    }

    /// <summary>
    /// Implementation of the interaction method
    /// </summary>
    public void Collect()
    {
        // Empty Function
    }
}