using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    class Trip
    {
        string _destination;
        double _distance;
        double _gasCost;
        double _gallon;
        double mPG;
        double cPM;


        public Trip()
        {


        }

        public Trip(string destination, double distance, double gasCost, double gallon)
        {
            Destination = destination;
            Distance = distance;
            GasCost = gasCost;
            Gallon = gallon;
        }


        public string Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                _destination = value;
            }
        }

        public double Distance
        {
            get;
            set;
        }

        public double GasCost
        {
            get;
            set;
        }

        public double Gallon
        {
            get;
            set;
        }


        public double MilesPerGallon()
        {
           return mPG = Distance / Gallon;
            
        }

        public double CostPerMile()
        {
            cPM = GasCost / Distance;   
            return cPM;
        }



        public override string ToString()
        {
            return "Destination: " + Destination +
                   "\n Distance: " + Distance +
                   "\nGast Cost: " + GasCost +
                   "\nGallons Consumed: " + Gallon +
                   "\nMile per Gallon: " + MilesPerGallon() +
                   "\nCost per miles: " + CostPerMile();


        }
    }
}