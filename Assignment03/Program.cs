/****************************************************************************************************
 * Author's Name         : Saemi Lee
 * 
 * Date last modified    : 02/27/2015
 * 
 * Program description   : This program is that sub classese ,which are GiantPlanet and TerrestralPlanet, inherit all properties and methods from Planet as parents class, and it override the methods from Interface. It will display Planet's name, diameter, mass, type and presence of oxygen taken over the parameters from main method. 
 *
 *  Revision History     :
 *  Date         Author    Ref Revision (Date in MMDDYYYY format)
 *  02/26/2015   SaemiLee    2       
 *****************************************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {

            //Implement GiantPlanet object
            GiantPlanet giantPlanet = new GiantPlanet("Saemi",20,15,"Gas");            
            Console.WriteLine(giantPlanet.ToString() +" Type: "+ giantPlanet.Type );

            //Implement TerrestrialPlanet object
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Lee",55,20,true);
            Console.WriteLine(terrestrialPlanet.ToString() +" Oxygen: "+ terrestrialPlanet.Oxygen);

            keyToExit();
        }

        //Method for hit anyKey to Exit 
        private static void keyToExit()
        {
            Console.Write("\n");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Please hit any key to exit....");
            Console.ReadKey();
        }

    }
}
