﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Khim Tang
 * Date: July 13, 2017
 * Description: This is the SuperVillain class which inherits from the SuperHuman class
 * Version: 0.1 - implemented the ToString method of the superhuman class 
 */

namespace Comp123_S2017_Lesson9A
{
    /// <summary>
    /// This is the SuperVillain class
    /// </summary>
    public class SuperVillain : SuperHuman, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLE
        private int _malice;

        // PUBLIC PROPERTIES
        public int Malice { get { return this._malice; } set { this._malice = value; } }

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the SuperVillain class
        /// It takes two arguments - name (string) - malice (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="malice"></param>
        public SuperVillain(string name, int malice) :base(name)
        {
            this.Malice = malice;
        }
        // PRIVATE METHODS

        // PUBLIC NETHODS

    }
}