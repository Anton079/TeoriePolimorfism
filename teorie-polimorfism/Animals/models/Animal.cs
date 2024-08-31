using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_polimorfism.Animals.models
{
    public class Animal
    {
        private string _type;
        private int _id;
        private string _name;
        private string _description;

        public Animal(string proprietati)
        {
            string[] token = proprietati.Split(',');

            _type = token[0];
            _id = int.Parse(token[1]);
            _name = token[2];
            _description = token[3];
        }

        public Animal(string type, int id, string name, string description) 
        {
            _type = type;
            _id = id;
            _name = name;
            _description = description;
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

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public virtual string AnimalInfo() 
        {
            string text = " ";
            text += "Type " + Type + "\n";
            text += "Id " + Id + "\n";
            text += "Name " + Name + "\n";
            text += "Description " + Description + "\n";
            return text;

            
        }

        public virtual string ToSave()
        {
            return _type + "," + _id + "," + _name + "," + _description;
        }


        public virtual void PoliTest()
        {

            Console.WriteLine("Sunt un animal");
        }
    }
}
