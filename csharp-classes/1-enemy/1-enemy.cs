using System;

namespace Enemies
{
    /// <summary>
    /// This class represents a zombie.
    /// </summary>
    class Zombie
    {
        /// <summary>
        /// health of a zombie. dead when equals zero.
        /// </summary>
        public int health;

        /// <summary>
        /// constructor with no param.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
    }
}