using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class TerrestrialPlanet : Planet , IHasMoons, IHabitable
    {

        //PRIVATE INSTANCE VARIABLES
        private bool _oxygen;

        public bool Oxygen
        {
            get
            {
                return _oxygen;
            }
            set
            {
                _oxygen = value;
            }
        }

        //CONSTRUCTOR METHOD
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter,mass)
        {
            this._oxygen = oxygen;
        }

        //inter
        public bool Habitable(){
            return (this._oxygen == true) ? true : false;
        }

        public bool HasMoons()
        {
            return (MoonCount > 0) ? true : false;
        }

    }

}
