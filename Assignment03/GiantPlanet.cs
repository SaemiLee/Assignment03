using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class GiantPlanet : Planet, IHasMoons, IHasRing
    {
        //PRIVATE INTANCE VARIABLES
        private string _type;

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }


        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
        }

        public bool HasMoons()
        {
            return (this.MoonCount > 0) ? true : false;
        }

        public bool HasRing()
        {
            return (this.RingCount > 0) ? true : false;
        }


        
    }

  
}
