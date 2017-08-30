﻿using Car3.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car4.Infrastructure
{
    public class Car1 : ICar
    {
        #region Fields
        string name;
        string fuelype;
        CarCommands command;
        #endregion
        #region Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Fuelype
        {
            get
            {
                return this.fuelype;
            }
            set
            {
                this.fuelype = value;
            }
        }

        public CarCommands Command
        {
            get
            {
                return this.command;
            }
            set
            {
                this.command = value;
            }
        }
        #endregion
    }
}
