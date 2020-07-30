using System;

namespace Enemies
{
    /// <summary>
    /// Zombie Enemy class
    /// 
    /// </summary>
    public class Zombie
    {
        // Pirvate health variable for the class
        int health;
        string name;

        /// <summary>
        /// Initalizes a new instance of a zombie class
        /// </summary>
        public Zombie() {
            health = 0;
        }
        /// <summary>
        /// Class contructor for the zombie, getter for value
        /// </summary>
        /// <param name="value">Health value</param>
        public Zombie(int value) {
            if (value >= 0) {
                health = value;
            }
            else if (value < 0) {
                throw new System.Exception("Health must be greater than or equal to 0");
            }
        }
        /// <summary>
        /// Getter for the zombier object's health
        /// </summary>
        /// <returns>The current zombie object's health</returns>
        public int GetHealth() {
            return health;
        }
        /// <summary>
        /// The getter and setter property for the Name field
        /// </summary>
        /// <returns>The name stored in the object</returns>
        public string Name { get; set; } = "(No name)";
    }
}
