using System;

namespace Enemies
{
    /// <summary>
    /// Zombie Enemy class
    /// 
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Health variable for each enemy
        /// </summary>
        public int health;

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
    }
}
