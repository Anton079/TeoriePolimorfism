using System.Globalization;
using teorie_polimorfism.Animals.models;
using teorie_polimorfism.Vehicules.models;

internal class Program
{
    private static void Main(string[] args)
    {

        Caine caine1 = new Caine("Caine", 1, "Ramus","Agresiv","Mare","Mare",30);
        Caine caine2 = new Caine("Caine", 3, "Raul", "Pasnic", "Mediu", "Mediu", 10);
        Caine caine3 = new Caine("Caine", 4, "Marius", "Foarte Agresiv", "Mare", "Mare", 45);


        Pasare pasare1 = new Pasare("Pasare", 4, "Viteza", "Mananca mult", 1, 60, 300);
        Pasare pasare2 = new Pasare("Pasare", 5, "Somnorosul", "Doarme mult", 1, 90, 100);
        Pasare pasare3 = new Pasare("Pasare", 6, "Paul", "Zboara mult", 1, 130, 600);

        Peste peste1 = new Peste("Pespte",7,"eric","Doarme mult",300,2,400);
        Peste peste2 = new Peste("Pespte", 8, "Ramol", "Inoata mult", 400, 5, 100);
        Peste peste3 = new Peste("Pespte", 9, "Marco", "Este un peste mare", 240, 5, 160);


        //Polimorfimsul




        List<Animal> _toateAnimalele = new List<Animal>();
        _toateAnimalele.Add(caine1);
        _toateAnimalele.Add(caine2);
        _toateAnimalele.Add(caine3);
        _toateAnimalele.Add(pasare1);
        _toateAnimalele.Add(pasare2);
        _toateAnimalele.Add(pasare3);
        _toateAnimalele.Add(peste1);
        _toateAnimalele.Add(peste2);
        _toateAnimalele.Add(peste3);

        foreach(Animal x in _toateAnimalele)
        {
            Console.WriteLine(x.AnimalInfo());
        }




        //Animal testRef = caine1;

        //intro referinta de tip animal retinem un obiect de tip caine

        // testRef nu are acces la metodele din caine ce nu le are animal
        //caine are acces la metodele din animalo


        //testRef = pasare1;

        //testRef = peste1;




        //Console.WriteLine(testRef.AnimalInfo());





        Suv suv1 = new Suv("Suv", 1, "Duster", 300, "SuspensiiBune", "Garda mare");
        Suv suv2 = new Suv("Suv", 2, "RangeRover", 450, "FoarteBUna", "Garda foarte mare");
        Suv suv3 = new Suv("Suv", 3, "Roader", 600, "SuspensiiProasta", "Garda mare");


        Sedan sedan1 = new Sedan("Sedan", 4, "Audi", 300, "Buna", 1);
        Sedan sedan2 = new Sedan("Sedan", 5, "Bmw", 700, "Foarte buna", 2);
        Sedan sedan3 = new Sedan("Sedan", 6, "Dacia", 100, "Ok", 3);



        List<Vehicule> _allCars = new List<Vehicule>();
        _allCars.Add(sedan1);
        _allCars.Add(sedan2);
        _allCars.Add(sedan3);
        _allCars.Add(suv1);
        _allCars.Add(suv2);
        _allCars.Add(suv3);

        foreach(Vehicule x in _allCars)
        {
            Console.WriteLine(x.VehiculeInfo());
        }

    }
}