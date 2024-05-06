﻿using System;

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
        /// create a zombie.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// create a zombie.
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
        }
    }
}