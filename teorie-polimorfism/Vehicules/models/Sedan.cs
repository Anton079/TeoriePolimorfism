using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_polimorfism.Vehicules.models
{
    public class Sedan : Vehicule
    {
        public string _aerodynamics;
        public int _carHeight;

        public Sedan(string type, int id, string brand, int horsePower, string aerodynamics, int carHeight) : base( type,  id,  brand,  horsePower)
        {
            _aerodynamics = aerodynamics;
            _carHeight = carHeight;
        }

        public Sedan(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _aerodynamics = token[4];
            _carHeight = int.Parse(token[5]);
        }

        public string Aerodynamics
        {
            get { return _aerodynamics; }
            set { _aerodynamics = value;}
        }

        public int CarHeight
        {
            get { return _carHeight;}
            set { _carHeight = value;}
        }

        public override string VehiculeInfo()
        {
            string text = base.VehiculeInfo();

            text += "Aerodynamics " + Aerodynamics + "\n";
            text += "Car Height " + CarHeight + "\n";
            return text;
        }
    }
}
