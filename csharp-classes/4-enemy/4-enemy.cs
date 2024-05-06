using System;

namespace Enemies
{
    /// <summary>
    /// This class represents a zombie.
    /// </summary>
    class Zombie
    {
        // health of a zombie. dead when equals zero.
        private int health;

        // name of a zombie.
        private string name;

        /// <summary>
        /// name of a zombie.
        /// </summary>
        public string Name
        {
            get => name;
            set => name = value;
        }

        /// <summary>
        /// create a zombie.
        /// </summary>
        public Zombie()
        {
            health = 0;
            name = "(No name)";
        }

        /// <summary>
        /// create a zombie with given health.
        /// </summary>
        /// <param name="health">
        /// health of the zombie (&gt;= 0)
        /// </param>
        public Zombie(int health)
        {
            if (health < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = health;
            name = "(No name)";

        }

        /// <summary>
        /// Get the health value.
        /// </summary>
        /// <returns>health value (integer &gt;= 0)</returns>
        public int GetHealth()
        {
            return this.health;
        }
    }
}