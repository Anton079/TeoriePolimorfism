using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_polimorfism.Animals.models
{
    public class Pasare : Animal
    {
        private int _aripiLungime;
        private int _vitezaZbor;
        private int _ciocPutere;

        public Pasare(string type, int id, string name, string description,  int aripiLungime, int vitezaZbor, int ciocPutere) : base( type,  id,  name,  description)
        {
            _aripiLungime = aripiLungime;
            _vitezaZbor = vitezaZbor;
            _ciocPutere = ciocPutere;
        }

        public Pasare(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _aripiLungime = int.Parse(token[4]);
            _vitezaZbor = int.Parse(token[5]);
            _ciocPutere = int.Parse(token[6]);
        }

        public int Aripi
        {
            get { return _aripiLungime; }
            set { _aripiLungime = value; }
        }

        public int VitezaZbor
        {
            get { return _vitezaZbor; }
            set { _vitezaZbor = value; }
        }

        public int CiocPutere
        {
            get { return _ciocPutere; }
            set { _ciocPutere = value; }
        }

        public override string AnimalInfo()
        {
            string text = " ";
            text += "Type " + base.Type + "\n";
            text += "Id " + base.Id + "\n";
            text += "Name " + base.Name + "\n";
            text += "Description " + base.Description + "\n";
            text += "Aripi " + Aripi + "\n";
            text += "Picioare " + VitezaZbor + "\n";
            text += "Cioc " + CiocPutere + "\n";
            return text;
        }

        public override string ToSave()
        {
            return base.Type + "," + base.Id + "," + base.Name + ',' + base.Description + "," + Aripi + "," + VitezaZbor + "," + CiocPutere;
        }

        public override void PoliTest()
        {

            Console.WriteLine("Sunt o pasare");
        }
    }
}
