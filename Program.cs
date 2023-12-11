using Transport;

namespace Exam
{
    internal class Program
    {
       /*static void Recherche(Cargaison cargaison)
        {
            int nch;
            Console.WriteLine("quel marchandise cherché vous");
            nch = int.Parse(Console.ReadLine());
            if(cargaison.count()<nch)
            {
                Console.WriteLine("le marchandise n'existe pas");
            }
            else
            {
                Console.WriteLine("chercher la marchandise num " + nch);
                Marchandise m = cargaison.getMarchandises(nch);
                Console.WriteLine(m);
                Console.ReadLine();
            }
      
        }*/
        static void AjouterCargaison(Cargaison cargaison,int num)
        {
            double p, v;
            Console.WriteLine("le num de marchandise = " + num);
            Console.WriteLine("donner le poid de marchandise");
            p = double.Parse(Console.ReadLine());
            Console.WriteLine("donner le volume de marchandise");
            v = double.Parse(Console.ReadLine());
            cargaison.Ajouter(new Marchandise(num, p, v));
            cargaison.afficher();
           
        }
        static void Main(string[] args)
        {
            string name;
            int nbr;
            string type;
            Console.WriteLine("donner le nbr de cargaison");
            nbr=int.Parse(Console.ReadLine());
            Cargaison ca = new CargaisonAerienne(90);
            Cargaison cr = new CargaisonRoutiere(90);
            for (int i = 1; i <= nbr; i++)
                {
                Console.WriteLine("donner type de cargaison Aerienne 1 ou cargaison Routiere 2");
                type = Console.ReadLine();
                if (type == "1")
                {
                    AjouterCargaison(ca,i);
                }
                else if(type == "2")
                {
                    AjouterCargaison(cr, i);
                }
                else
                {
                    Console.WriteLine("please enter the correct type 1 or 2");
                }
               
                }
            Console.WriteLine("add your name");
            name= Console.ReadLine();
            Client client = new Client(name);
            client.AddCargaison(ca);
            client.AddCargaison(cr);

           
            client.DisplayClientCargaisons();
            double totalCost = client.CalculateTotalCost();
            Console.WriteLine($"{client.Name}'s Prix Total: {totalCost}");
            Console.WriteLine("Enter the merchandise number to search:");
            int searchNumber = int.Parse(Console.ReadLine());
            client.SearchInCargaisons(searchNumber);
        }
    }
}
