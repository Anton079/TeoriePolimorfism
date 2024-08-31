using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_polimorfism.Vehicules.models
{
    public class Vehicule
    {
        private string _type;
        private int _id;
        private string _brand;
        private int _horsePower;

        public Vehicule(string proprietati)
        {
            string[] token = proprietati.Split(',');

            _type = token[0];
            _id = int.Parse(token[1]);
            _brand = token[2];
            _horsePower = int.Parse(token[3]);
        }

        public Vehicule(string type, int id, string brand, int horsePower)
        {
            _type = type;
            _id = id;
            _brand = brand;
            _horsePower = horsePower;
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public int HorsePower
        {
            get { return _horsePower; }
            set { _horsePower = value; }
        }

        public virtual string VehiculeInfo()
        {
            string text = " ";
            text += "Type " + Type + "\n";
            text += "Id " + Id + "\n";
            text += "Brand "+ Brand + "\n";
            text += "HorsePower " + HorsePower + "\n";
            return text;
        }

        public string ToSave()
        {
            return Type + "," + Id + "," + Brand + "," + HorsePower; 
        }
    }
}
