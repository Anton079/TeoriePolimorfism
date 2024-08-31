using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace teorie_polimorfism.Animals.models
{
    public class Peste : Animal
    {
        private int _greutate;
        private int _aripioare;
        private int _solzi;

        public Peste(string type, int id, string name, string description, int greutate, int aripioare, int solzii) : base( type,  id,  name,  description)
        {
            base.Type = "Peste";
            _greutate = greutate;
            _aripioare = aripioare;
            _solzi = solzii;
        }

        public Peste(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _greutate = int.Parse(token[4]);
            _aripioare = int.Parse(token[5]);
            _solzi = int.Parse(token[6]);
        }

        public int Greutate
        {
            get { return _greutate; }
            set { _greutate = value;}
        }

        public int Aripioare
        {
            get { return _aripioare;}
            set { _aripioare = value;}
        }

        public int Solzi
        {
            get { return _solzi;}
            set { _solzi = value;}
        }

        public override string AnimalInfo()
        {
            string text = " ";
            text += "Type" + base.Type + "\n";
            text += "Id " + base.Id + "\n";
            text += "Name " + base.Name + "\n";
            text += "Description " + base.Description + "\n";
            text += "Branhii " + Greutate + "\n";
            text += "Aripioare " + Aripioare + "\n";
            text += "Solzi " + Solzi + "\n";
            return text;
        }

        public override string ToSave()
        {
            return base.Type + "," + base.Id + "," + base.Name + ',' + base.Description + "," + Greutate + "," + Aripioare + "," + Solzi;
        }

        public override void PoliTest()
        {

            Console.WriteLine("Sunt un peste");
        }
    }
}
