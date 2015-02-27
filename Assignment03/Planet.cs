using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    abstract class Planet
    {
        //PRIVATE INSTANCE VARIABLES
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orvitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;


        //Read-Only PUBLIC PROPERTIES
        public double Diameter
        {
            get
            {
                return this._diameter; 
            }

        }
        public double Mass
        {
            get
            {
                return this._mass;
            }

        }

        public string Name
        {
            get
            {
                return this._name;
            }
        }


        //PUBLIC PROPERTIES
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }

      

        public double OrbitalPeriod
        {
            get
            {
                return this._orvitalPeriod;
            }
            set
            {
                this._orvitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }




        //CONSTRUCTOR
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        //ABSTRACT METHOD
        public override string ToString()
        {
            return "Name: " + Name + " Diameter: " + Diameter + " Mass: " + Mass;
        }        
        

    }
}
