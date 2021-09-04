using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Globalization;

namespace ReservationHotel
{
    public class BDDHotels
    {
        public static List<Hotel> getHotels()
        {
            List<Hotel> hotels = new List<Hotel>();

            hotels.Add(new Hotel()
            {
                nom = "Boulders Resort & Spa",
                localisation = new Localisation()
                {
                    pays = "Etats-Unis",
                    adresse = new Adresse()
                    {
                        numero = "34631",
                        rue = "N Tom Darlington Dr",
                        ville = new Ville()
                        {
                            nom = "Scottsdale",
                            codePostal = "85054"
                        },
                        positionGPS = "33.80331860803277,-111.92636840178656"
                    }
                },
                classement = "5",
                capacite = "232",
                prix = "400"
            });

            hotels.Add(new Hotel()
            {
                nom = "Emirates Palace",
                localisation = new Localisation()
                {
                    pays = "Émirats Arabes Unis",
                    adresse = new Adresse()
                    {
                        numero = "unknown",
                        rue = "Al Ras Al Akhdar",
                        ville = new Ville()
                        {
                            nom = "Abu Dhabi",
                            codePostal = "unknown"
                        },
                        positionGPS = "24.461731476425495,54.31731012013281"
                    }
                },
                classement = "5",
                capacite = "270",
                prix = "320"
            });

            hotels.Add(new Hotel()
            {
                nom = "Titanic Mardan Palace",
                localisation = new Localisation()
                {
                    pays = "Turquie",
                    adresse = new Adresse()
                    {
                        numero = "450",
                        rue = "Yaşar Sobutay Bul",
                        ville = new Ville()
                        {
                            nom = "Antalaya",
                            codePostal = "0242"
                        },
                        positionGPS = "36.85872844317595,30.92056105309612"
                    }
                },
                classement = "5",
                capacite = "450",
                prix = "500"
            });

            hotels.Add(new Hotel()
            {
                nom = "The Plaza - A Fairmont Managed Hotel",
                localisation = new Localisation()
                {
                    pays = "Etats-Unis",
                    adresse = new Adresse()
                    {
                        numero = "768",
                        rue = "5th Ave",
                        ville = new Ville()
                        {
                            nom = "New-York",
                            codePostal = "10019"
                        },
                        positionGPS = "40.764496133446386,-73.9744780319362"
                    }
                },
                classement = "5",
                capacite = "700",
                prix = "295"
            });

            hotels.Add(new Hotel()
            {
                nom = "Royal Mansour Marrakech",
                localisation = new Localisation()
                {
                    pays = "Maroc",
                    adresse = new Adresse()
                    {
                        numero = "unknown",
                        rue = "Abou Abbas El Sebti",
                        ville = new Ville()
                        {
                            nom = "Marrakech",
                            codePostal = "40000"
                        },
                        positionGPS = "31.62554543419249,-7.99836808056495"
                    }
                },
                classement = "5",
                capacite = "368",
                prix = "1050"
            });

            hotels.Add(new Hotel()
            {
                nom = "Marina Bay Sands Singapore",
                localisation = new Localisation()
                {
                    pays = "Malaisie",
                    adresse = new Adresse()
                    {
                        numero = "10",
                        rue = "Bayfront Ave",
                        ville = new Ville()
                        {
                            nom = "Singapour",
                            codePostal = "018956"
                        },
                        positionGPS = "1.285117641141468,103.86100212320726"
                    }
                },
                classement = "5",
                capacite = "211",
                prix = "315"
            });

            hotels.Add(new Hotel()
            {
                nom = "The St. Regis Rome",
                localisation = new Localisation()
                {
                    pays = "Italie",
                    adresse = new Adresse()
                    {
                        numero = "3",
                        rue = "Vittorio E. Orlando",
                        ville = new Ville()
                        {
                            nom = "Rome",
                            codePostal = "58610"
                        },
                        positionGPS = "41.90408397854154,12.494874050261853"
                    }
                },
                classement = "5",
                capacite = "556",
                prix = "550"
            });

            hotels.Add(new Hotel()
            {
                nom = "Mandarin Oriental, Paris",
                localisation = new Localisation()
                {
                    pays = "France",
                    adresse = new Adresse()
                    {
                        numero = "251",
                        rue = "Rue Saint-Honoré",
                        ville = new Ville()
                        {
                            nom = "Paris",
                            codePostal = "75001"
                        },
                        positionGPS = "48.86717505696258,2.3272552847407666"
                    }
                },
                classement = "5",
                capacite = "322",
                prix = "740"
            });

            hotels.Add(new Hotel()
            {
                nom = "Laucala Island Resort",
                localisation = new Localisation()
                {
                    pays = "unknown",
                    adresse = new Adresse()
                    {
                        numero = "unknown",
                        rue = "unknown",
                        ville = new Ville()
                        {
                            nom = "Laucala",
                            codePostal = "unknown"
                        },
                        positionGPS = "-16.74862188573491,-179.6679161074447"
                    }
                },
                classement = "5",
                capacite = "50",
                prix = "800"
            });

            hotels.Add(new Hotel()
            {
                nom = "Burj Al Arab",
                localisation = new Localisation()
                {
                    pays = "Émirats Arabes Unis",
                    adresse = new Adresse()
                    {
                        numero = "3",
                        rue = "Umm Suqeim",
                        ville = new Ville()
                        {
                            nom = "Dubai",
                            codePostal = "00000"
                        },
                        positionGPS = "25.141253749286527,55.18519287428754"
                    }
                },
                classement = "5",
                capacite = "347",
                prix = "650"
            });

            return hotels;
        }
    }

    public class Hotel
    {
        public string nom { get; set; }
        public Localisation localisation { get; set; }
        public string classement { get; set; }
        public string capacite { get; set; }
        public string prix { get; set; }

        public override string ToString()
        {
            return "Nom : " + this.nom + "\nLocalisation : {\n" + this.localisation.ToString() + "\n}" + "\nClassement : " + this.classement + "\nCapacité : " + this.capacite + "\nPrix : " + this.prix;
        }
    }

    public class Localisation
    {
        public string pays { get; set; }
        public Adresse adresse { get; set; }

        public override string ToString()
        {
            return "\tPays : " + this.pays + "\n\tAdresse : {\n" + this.adresse.ToString() + "\n\t}";
        }
    }

    public class Adresse
    {
        public string numero { get; set; }
        public string rue { get; set; }
        public Ville ville { get; set; }
        public string positionGPS { get; set; }

        public override string ToString()
        {
            return "\t\tNuméro : " + this.numero + "\n\t\tRue : " + this.rue + "\n\t\tVille : {\n" + this.ville.ToString() + "\n\t\t}" + "\n\t\tPosition GPS : " + this.positionGPS;
        }
    }

    public class Ville
    {
        public string nom { get; set; }
        public string codePostal { get; set; }

        public override string ToString()
        {
            return "\t\t\tNom : " + this.nom + "\n\t\t\tCode postal : " + this.codePostal;
        }
    }

    public class Client
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string carteBancaire { get; set; }

        public Client(string nom, string prenom, string carteBancaire)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.carteBancaire = carteBancaire;
        }

        public override string ToString()
        {
            return "Nom : " + this.nom + "\nPrénom : " + this.prenom + "\nCarte bancaire : " + this.carteBancaire;
        }
    }

    public class SystemeReservation
    {

        List<Hotel> hotels;
        List<string> villesDisponibles;

        List<Client> listeDeClient;
        List<Hotel> reservationUtilisateur;

        public SystemeReservation()
        {
            hotels = BDDHotels.getHotels();
            villesDisponibles = this.getVillesDisponibles();
            reservationUtilisateur = new List<Hotel>();
            listeDeClient = new List<Client>();
        }

        public bool VerificationSaisieUtilisateur(int numeroSaisie, string saisie)
        {
            switch (numeroSaisie)
            {
                case 1:
                    hotels.ForEach(x => {
                        if (x.localisation.adresse.ville.nom.Equals(saisie))
                            reservationUtilisateur.Add(x);
                    });

                    if (!reservationUtilisateur.Any())
                    {
                        System.Console.WriteLine("/!\\ Notre BDD ne possède aucun Hôtel dans cette Ville, fin de la réservation.");
                        return false;
                    }

                    return true;
                case 2:
                    if (!(new Regex(@"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$").IsMatch(saisie)))
                    {
                        System.Console.WriteLine("/!\\ Le format de la saisie n'est pas respecté, fin de la réservation.");
                        return false;
                    }

                    DateTime startDate = Convert.ToDateTime(saisie, new CultureInfo("fr-FR"));

                    if (startDate.Date < DateTime.Now.Date)
                    {
                        System.Console.WriteLine("/!\\ La date que vous avez saisi est déjà passée, fin de la réservation.");
                        return false;
                    }

                    return true;
                case 3:
                    if (!(new Regex(@"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$").IsMatch(saisie)))
                    {
                        System.Console.WriteLine("/!\\ Le format de la saisie n'est pas respecté, fin de la réservation.");
                        return false;
                    }

                    DateTime endDate = Convert.ToDateTime(saisie, new CultureInfo("fr-FR"));

                    if (endDate.Date < DateTime.Now.Date)
                    {
                        System.Console.WriteLine("/!\\ La date que vous avez saisi est déjà passée, fin de la réservation.");
                        return false;
                    }

                    return true;
                case 4:
                    double input4 = 0.0;

                    try
                    {
                        input4 = float.Parse(saisie, CultureInfo.InvariantCulture.NumberFormat);
                    }
                    catch (FormatException)
                    {
                        System.Console.WriteLine("/!\\ Le format de la saisie n'est pas respecté, fin de la réservation.");
                        return false;
                    }

                    reservationUtilisateur.RemoveAll(hotel => float.Parse(hotel.prix, CultureInfo.InvariantCulture.NumberFormat) > input4);

                    if (!reservationUtilisateur.Any())
                    {
                        System.Console.WriteLine("/!\\ Plus aucun Hôtel de notre BDD possède les critères que vous avez saisi, fin de la réservation.");
                        return false;
                    }

                    return true;
                case 5:
                    int input5 = 0;

                    try
                    {
                        input5 = int.Parse(saisie);
                    }
                    catch (FormatException)
                    {
                        System.Console.WriteLine("/!\\ Le format de la saisie n'est pas respecté, fin de la réservation.");
                        return false;
                    }

                    reservationUtilisateur.RemoveAll(hotel => int.Parse(hotel.capacite) < input5);

                    if (!reservationUtilisateur.Any())
                    {
                        System.Console.WriteLine("/!\\ Plus aucun Hôtel de notre BDD possède les critères que vous avez saisi, fin de la réservation.");
                        return false;
                    }

                    return true;
                case 6:
                    if (!(saisie.Equals("Oui") || saisie.Equals("Non")))
                    {
                        System.Console.WriteLine("/!\\ Le format de la saisie n'est pas respecté, fin de la réservation.");
                        return false;
                    }

                    return true;
                default:
                    return false;
            }
        }

        public int MenuReservation()
        {

            CultureInfo culture = new CultureInfo("fr-FR");

            string cityUserInput = "";
            string startUserInput = "";
            string endUserInput = "";
            string priceUserInput = "";
            string nbrUserInput = "";
            string souhaiteReserver = "";

            System.Console.WriteLine("[i] : Information");
            System.Console.WriteLine("[*] : Demande de saisie");
            System.Console.WriteLine("/!\\ : Arrêt du Système de Réservation");

            System.Console.WriteLine("\n***************************");
            System.Console.WriteLine("*** RÉSERVATION D'HÔTEL ***");
            System.Console.WriteLine("***************************");

            System.Console.Write("\n[i] Villes disponibles : ");
            System.Console.WriteLine(string.Join(", ", this.villesDisponibles.ToArray()));

            System.Console.WriteLine("\n[*] Dans quelle Ville souhaitez-vous réserver un Hôtel ?");
            System.Console.Write("> ");

            cityUserInput = Console.ReadLine();

            if (!VerificationSaisieUtilisateur(1, cityUserInput))
                return 0;

            System.Console.WriteLine("\n[*] Quelle est la date d'arrivée ? (format : jj/mm/aaaa)");
            System.Console.Write("> ");
            startUserInput = Console.ReadLine();

            if (!VerificationSaisieUtilisateur(2, startUserInput))
                return 0;

            DateTime startDate = Convert.ToDateTime(startUserInput, culture);

            System.Console.WriteLine("\n[*] Quelle est la date de départ ? (format : jj/mm/aaaa)");
            System.Console.Write("> ");
            endUserInput = Console.ReadLine();

            if (!VerificationSaisieUtilisateur(3, endUserInput))
                return 0;

            DateTime endDate = Convert.ToDateTime(endUserInput, culture);

            if (startDate.Date > endDate.Date)
            {
                System.Console.WriteLine("/!\\ La date de départ ne peut pas être avant la date d'arrivée, fin de la réservation.");
                return 0;
            }

            System.Console.WriteLine("\n[i] Les prix appartiennent à l'intervalle suivant : " + this.getFourchettePrix());
            System.Console.WriteLine("\n[*] Combien êtes-vous prêt à dépenser maximum ?");
            System.Console.Write("> ");
            priceUserInput = Console.ReadLine();

            if (!VerificationSaisieUtilisateur(4, priceUserInput))
                return 0;

            System.Console.WriteLine("\n[i] Tous les Hôtels présents dans la BDD sont 5 étoiles");

            System.Console.WriteLine("\n[*] Combien de personnes maximum faut-il héberger ?");
            System.Console.Write("> ");
            nbrUserInput = Console.ReadLine();

            if (!VerificationSaisieUtilisateur(5, nbrUserInput))
                return 0;

            if (reservationUtilisateur.Count == 1)
                System.Console.WriteLine("\n[i] Félicitation, " + reservationUtilisateur.Count + " Hôtel correspond à votre recherche !");
            else
                System.Console.WriteLine("\n[i] Félicitation, " + reservationUtilisateur.Count + " Hôtels correspondent à votre recherche !");


            foreach (Hotel hotel in reservationUtilisateur)
            {
                System.Console.WriteLine("\n" + hotel.ToString());

                System.Console.WriteLine("\n[*] Souhaitez-vous réserver cet Hôtel ? (Oui/Non)");
                System.Console.Write("> ");
                souhaiteReserver = Console.ReadLine();

                if (!VerificationSaisieUtilisateur(6, souhaiteReserver))
                    return 0;

                if (souhaiteReserver.Equals("Oui"))
                {
                    this.TraitementReservation();
                    return 1;
                }
            }

            System.Console.WriteLine("/!\\ Vous avez décidé de ne pas réserver l'Hôtel, fin de la réservation.");

            return 0;
        }

        public void TraitementReservation()
        {
            string lastname = "";
            string firstname = "";
            string creditCard = "";

            System.Console.WriteLine("\n*********************************");
            System.Console.WriteLine("*** FORMULAIRE DE RÉSERVATION ***");
            System.Console.WriteLine("*********************************");

            System.Console.WriteLine("\n[*] Veuillez saisir votre Nom : ");
            System.Console.Write("> ");
            lastname = Console.ReadLine();

            System.Console.WriteLine("\n[*] Veuillez saisir votre Prénom : ");
            System.Console.Write("> ");
            firstname = Console.ReadLine();

            System.Console.WriteLine("\n[*] Veuillez saisir votre Numéro de Carte Bleu : ");
            System.Console.Write("> ");
            creditCard = Console.ReadLine();

            listeDeClient.Add(new Client(lastname, firstname, creditCard));

            System.Console.WriteLine("\n[i] Félicitation " + firstname + " " + lastname + ", votre Réservation vien d'être prise en compte !");
        }

        public List<string> getVillesDisponibles()
        {

            List<string> villes = new List<string>();

            hotels.ForEach(x => {
                villes.Add(x.localisation.adresse.ville.nom);
            });

            return villes;
        }

        public string getFourchettePrix()
        {
            int min = int.Parse(hotels[0].prix);
            int max = int.Parse(hotels[0].prix);

            hotels.ForEach(x => {
                if (int.Parse(x.prix) > max) max = int.Parse(x.prix);

                if (int.Parse(x.prix) < min) min = int.Parse(x.prix);
            });

            return "[" + min.ToString() + "," + max.ToString() + "]";
        }

        static void Main(string[] args)
        {
            SystemeReservation sys = new SystemeReservation();
            sys.MenuReservation();
        }
    }

}
