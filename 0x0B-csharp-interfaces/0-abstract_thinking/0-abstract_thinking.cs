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