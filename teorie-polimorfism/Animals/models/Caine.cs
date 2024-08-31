using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_polimorfism.Animals.models
{
    public class Caine : Animal
    {
        private string _putereMiros;
        private string _putereMuscare;
        private int _vitezaAlergat;

        public Caine(string type, int id, string name, string description, string putereMiros, string putereMuscare, int vitezaAlergat) : base(type, id, name, description)
        {
            base.Type = "Caine";
            _putereMiros = putereMiros;
            _putereMuscare = putereMuscare;
            _vitezaAlergat = vitezaAlergat;
        }

        public Caine(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _putereMiros = token[4];
            _putereMuscare= token[5];
            _vitezaAlergat = int.Parse(token[6]);
        }

        public string PutereMiros
        {
            get { return _putereMiros; }
            set { value = _putereMiros; }
        }

        public string PutereMuscare
        {
            get { return _putereMuscare; }
            set { value = _putereMuscare; }
        }

        public int VitezaAlergat
        {
            get { return _vitezaAlergat; }
            set { value = _vitezaAlergat; }
        }

        public override string  AnimalInfo()
        {
            string text = base.AnimalInfo();
            text += "PutereMiros " + PutereMiros + "\n";
            text += "Putere Muscare " + PutereMuscare + "\n";
            text += "VitezaAlergat " + VitezaAlergat + "\n";
            return text;
        }

        public override string ToSave()
        {
            return base.Type + "," + base.Id + "," + base.Name + ',' + base.Description + "," + PutereMiros +","+PutereMuscare + "," + VitezaAlergat; 
        }

        public override void PoliTest()
        {

            Console.WriteLine("Sunt un caine");
        }
    }

}
