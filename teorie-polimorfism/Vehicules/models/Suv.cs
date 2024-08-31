using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_polimorfism.Vehicules.models
{
    public class Suv : Vehicule
    {
        public string _typeSuspension;
        public string _gorundClearance;

        public Suv(string type, int id, string brand, int horsePower, string typeSuspension, string gorundClearance) : base ( type,  id,  brand,  horsePower)
        {
            _typeSuspension = typeSuspension;
            _gorundClearance = gorundClearance;
        }

        public Suv(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _typeSuspension = token[4];
            _gorundClearance= token[5];
        }

        public string TypeSuspension
        {
            get { return _typeSuspension;}
            set { _typeSuspension = value;}
        }

        public string GorundClearance
        {
            get { return _gorundClearance; }
            set { _gorundClearance = value; }
        }

        public override string VehiculeInfo()
        {
            string text = base.VehiculeInfo();
            text += "TypeSuspesion " + TypeSuspension + "\n";
            text += "Gorund Clearance " + GorundClearance + "\n";
            return text;
        }

        public string ToSave()
        {
            return base.VehiculeInfo() + "," + TypeSuspension + "," + GorundClearance;
        }
    }
}
