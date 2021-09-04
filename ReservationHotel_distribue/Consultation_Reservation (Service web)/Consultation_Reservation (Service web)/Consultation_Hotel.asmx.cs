﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.Web.Services;
using System.Globalization;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace Consultation_Reservation__Service_web_
{
    // Base de donnée contenant les Agences partenaires
    public class BDDAgences
    {
        public static List<Agence> GetAgences()
        {
            List<Agence> agences = new List<Agence>();

            agences.Add(new Agence("@identifiant1", "agence34."));
            agences.Add(new Agence("@identifiant2", "agence75."));
            agences.Add(new Agence("@identifiant3", "agence69."));

            return agences;
        }
    }

    // Descriptif Agence
    public class Agence
    {
        public string id { get; set; }
        public string password { get; set; }

        public Agence()
        {
            this.id = "";
            this.password = "";
        }

        public Agence(string id, string password)
        {
            this.id = id;
            this.password = password;
        }
    }

    // Base de donnée contenant les Hôtels disponibles 
    public class BDDHotels
    {
        public static List<Hotel> GetHotels()
        {
            List<Hotel> hotels = new List<Hotel>();

            hotels.Add(new Hotel("@id1", "Boulders Resort & Spa", new Localisation()
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
            }, "5", "232", "400", "1.jpg"));

            hotels.Add(new Hotel("@id2", "Emirates Palace", new Localisation()
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
            }, "5", "270", "320", "2.jpg"));

            hotels.Add(new Hotel("@id3", "Titanic Mardan Palace", new Localisation()
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
            }, "5", "450", "500", "3.jpg"));

            hotels.Add(new Hotel("@id4", "The Plaza - A Fairmont Managed Hotel", new Localisation()
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
            }, "5", "700", "295", "4.jpg"));

            hotels.Add(new Hotel("@id5", "Royal Mansour Marrakech", new Localisation()
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
            }, "5", "368", "1050", "5.jpg"));

            hotels.Add(new Hotel("@id6", "Marina Bay Sands Singapore", new Localisation()
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
            }, "5", "211", "315", "6.jpg"));

            hotels.Add(new Hotel("@id7", "The St. Regis Rome", new Localisation()
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
            }, "5", "556", "550", "7.jpg"));

            hotels.Add(new Hotel("@id8", "Mandarin Oriental, Paris", new Localisation()
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
            }, "5", "322", "740", "8.jpg"));

            hotels.Add(new Hotel("@id9", "Laucala Island Resort", new Localisation()
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
            }, "5", "50", "800", "9.jpg"));

            hotels.Add(new Hotel("@id10", "Burj Al Arab", new Localisation()
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
            }, "5", "347", "650", "10.jpg"));

            return hotels;
        }
    }

    // Descriptif Hotel
    public class Hotel
    {
        public string id { get; set; }
        public string nom { get; set; }
        public Localisation localisation { get; set; }
        public string classement { get; set; }
        public string capacite { get; set; }
        public string prix { get; set; }
        public string infoHotel { get; set; }
        public string imgChambre { get; set; }
        public byte[] file { get; set; }

        public Hotel(){
            this.id = "";
            this.nom = "";
            this.localisation = new Localisation();
            this.classement = "";
            this.capacite = "";
            this.prix = "";
            this.infoHotel = "";
            this.file = new byte[] { 0 };
            this.imgChambre = "";
        }

        public Hotel(string id, string nom, Localisation localisation, string classement, string capacite, string prix, string imgName)
        {
            this.id = id;
            this.nom = nom;
            this.localisation = localisation;
            this.classement = classement;
            this.capacite = capacite;
            this.prix = prix;
            this.file = System.IO.File.ReadAllBytes(System.Web.Hosting.HostingEnvironment.MapPath("~/img/") + imgName);
            this.imgChambre = Convert.ToBase64String(file, 0, file.Length);
            this.infoHotel = this.ToString();
        }

        public override string ToString()
        {
            return "Identifiant : " + this.id + "\nNom : " + this.nom + "\nLocalisation : {\n" + this.localisation.ToString() + "\n}" + "\nClassement : " + this.classement + "\nCapacité : " + this.capacite + "\nPrix : " + this.prix;
        }
    }

    // Descriptif Localisation
    public class Localisation
    {
        public string pays { get; set; }
        public Adresse adresse { get; set; }

        public Localisation()
        {
            this.pays = "";
            this.adresse = new Adresse();
        }

        public override string ToString()
        {
            return "\tPays : " + this.pays + "\n\tAdresse : {\n" + this.adresse.ToString() + "\n\t}";
        }
    }

    // Descriptif Adresse
    public class Adresse
    {
        public string numero { get; set; }
        public string rue { get; set; }
        public Ville ville { get; set; }
        public string positionGPS { get; set; }

        public Adresse()
        {
            this.numero = "";
            this.rue = "";
            this.ville = new Ville();
            this.positionGPS = "";
        }

        public override string ToString()
        {
            return "\t\tNuméro : " + this.numero + "\n\t\tRue : " + this.rue + "\n\t\tVille : {\n" + this.ville.ToString() + "\n\t\t}" + "\n\t\tPosition GPS : " + this.positionGPS;
        }
    }

    // Descriptif Ville
    public class Ville
    {
        public string nom { get; set; }
        public string codePostal { get; set; }

        public Ville()
        {
            this.nom = "";
            this.codePostal = "";
        }

        public override string ToString()
        {
            return "\t\t\tNom : " + this.nom + "\n\t\t\tCode postal : " + this.codePostal;
        }
    }

    // Descriptif Client
    public class Client
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string carteBancaire { get; set; }

        public Client()
        {
            this.nom = "";
            this.prenom = "";
            this.carteBancaire = "";
        }

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

    // Message à envoyer à l'Application Cliente
    public class Msg
    {
        public string msg { get; set; }
        public int code { get; set; }

        public Msg()
        {
            this.msg = "";
            this.code = 0;
        }
        public Msg(string msg, int code)
        {
            this.msg = msg;
            this.code = code;
        }
    }

    // Système Consultation
    public class Consultation
    {
        public List<Hotel> hotels;
        public List<string> villesDisponibles;
        public List<Client> listeDeClient;
        public List<Hotel> reservationUtilisateur;

        public Consultation()
        {
            hotels = BDDHotels.GetHotels();
            villesDisponibles = this.GetVillesDisponibles();
            reservationUtilisateur = new List<Hotel>();
            listeDeClient = new List<Client>();
        }

        public List<string> GetVillesDisponibles()
        {

            List<string> villes = new List<string>();

            hotels.ForEach(x => {
                villes.Add(x.localisation.adresse.ville.nom);
            });

            return villes;
        }

        public string GetFourchettePrix()
        {
            int min = int.Parse(hotels[0].prix);
            int max = int.Parse(hotels[0].prix);

            hotels.ForEach(x => {
                if (int.Parse(x.prix) > max) max = int.Parse(x.prix);

                if (int.Parse(x.prix) < min) min = int.Parse(x.prix);
            });

            return "[" + min.ToString() + "," + max.ToString() + "]";
        }
    }

    /// <summary>
    /// Description résumée de Consultation_Hotel
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class Consultation_Hotel : System.Web.Services.WebService
    {
        Consultation consultation = new Consultation();

        [WebMethod]
        // On vérifie que l'Agence qui essaye de se connecter est bien une Agence partenaire
        public Msg VerificationAgencePartenaire(string idAgence, string password)
        {
            foreach(Agence ag in BDDAgences.GetAgences())
            {
                if (ag.id.Equals(idAgence) && ag.password.Equals(password))
                    return new Msg("[i] Vérification de l'Agence en cours....... OK\n[i] Il s'agit bien d'une Agence partenaire, vous avez désormais accès aux différentes offres d'Hôtels.", 1);
            }

            return new Msg("[i] Vérification de l'Agence en cours....... FAIL\n/!\\ Cette Agence ne fait pas parti de nos Agences partenaires, fin de la connexion.", 0);
        }

        [WebMethod]
        // Vérification de la conformité des saisies de l'Utilisateur
        public Msg VerificationSaisieUtilisateur(int numeroSaisie, string city = "", string startDate = "", string endDate = "", string price = "", string capacity = "", string reservation = "")
        {
            switch (numeroSaisie)
            {
                case 1:
                    foreach(Hotel hotel in consultation.hotels)
                    {
                        if (hotel.localisation.adresse.ville.nom.Equals(city))
                        {
                            return new Msg("[i] Notre Agence possède des Hôtels dans cette Ville", 1);
                        }
                    }

                    return new Msg("/!\\ Notre Agence ne possède aucun Hôtel dans cette Ville, fin de la réservation.", 0);
                case 2:
                    if (!(new Regex(@"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$").IsMatch(startDate)))
                    {
                        return new Msg("/!\\ Le format de la saisie n'est pas respecté, fin de la réservation.", 0);
                    }

                    DateTime startDateUser = Convert.ToDateTime(startDate, new CultureInfo("fr-FR"));

                    if (startDateUser.Date < DateTime.Now.Date)
                    {
                        return new Msg("/!\\ La date que vous avez saisi est déjà passée, fin de la réservation.", 0);
                    }

                    return new Msg("[i] Le format de la saisie est correct.", 1);
                case 3:
                    if (!(new Regex(@"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$").IsMatch(endDate)))
                    {
                        return new Msg("/!\\ Le format de la saisie n'est pas respecté, fin de la réservation.", 0);
                    }

                    DateTime startDateFormat = Convert.ToDateTime(startDate, new CultureInfo("fr-FR"));
                    DateTime endDateFormat = Convert.ToDateTime(endDate, new CultureInfo("fr-FR"));

                    if (endDateFormat.Date < DateTime.Now.Date)
                    {
                        return new Msg("/!\\ La date que vous avez saisi est déjà passée, fin de la réservation.", 0);
                    }

                    if (startDateFormat.Date > endDateFormat.Date)
                    {
                        return new Msg("/!\\ La date de départ ne peut pas être avant la date d'arrivée, fin de la réservation.", 0);
                    }

                    return new Msg("[i] Le format de la saisie est correct.", 1);
                case 4:
                    double input4 = 0.0;

                    try
                    {
                        input4 = float.Parse(price, CultureInfo.InvariantCulture.NumberFormat);
                    }
                    catch (FormatException)
                    {
                        return new Msg("/!\\ Le format de la saisie n'est pas respecté, fin de la réservation.", 0);
                    }

                    foreach (Hotel hotel in consultation.hotels)
                    {
                        if (hotel.localisation.adresse.ville.nom.Equals(city) && float.Parse(hotel.prix, CultureInfo.InvariantCulture.NumberFormat) <= input4)
                        {
                            return new Msg("[i] Notre Agence possède un ou plusieurs Hôtel(s) à ce prix dans la Ville que vous avez choisi.", 1);
                        }
                    }

                    return new Msg("/!\\ Plus aucun Hôtel de notre Agence possède les critères que vous avez saisi, fin de la réservation.", 0);
                case 5:
                    int input5 = 0;

                    try
                    {
                        input5 = int.Parse(capacity);
                    }
                    catch (FormatException)
                    {
                        return new Msg("/!\\ Le format de la saisie n'est pas respecté, fin de la réservation.", 0);
                    }

                    foreach (Hotel hotel in BDDHotels.GetHotels())
                    {
                        if (hotel.localisation.adresse.ville.nom.Equals(city) && float.Parse(hotel.prix, CultureInfo.InvariantCulture.NumberFormat) <= float.Parse(price, CultureInfo.InvariantCulture.NumberFormat) && int.Parse(hotel.capacite) >= int.Parse(capacity))
                        {
                            return new Msg("[i] Notre Agence possède un ou plusieurs Hôtel(s) ayant des Chambres disponibles dans la Ville que vous avez choisi.", 1);
                        }
                    }

                    return new Msg("/!\\ Plus aucun Hôtel de notre Agence possède les critères que vous avez saisi, fin de la réservation.", 0);
                case 6:
                    if (!(reservation.Equals("Oui") || reservation.Equals("Non")))
                    {
                        return new Msg("/!\\ Le format de la saisie n'est pas respecté, fin de la réservation.", 0);
                    }


                    return new Msg("[i] Le format de la saisie est correct.", 1);
                default:
                    return new Msg("DEFAULT", 0);
            }
        }

        [WebMethod]
        // Renvoi la liste des Villes ou l'Agence possède un Hôtel
        public string VillesDisponibles()
        {
            return string.Join(", ", consultation.GetVillesDisponibles());
        }

        [WebMethod]
        // Renvoi la fourchette de Prix des Hôtels disponibles
        public string FourchettePrix()
        {
            return string.Join(", ", consultation.GetFourchettePrix());
        }

        [WebMethod]
        // Renvoi le nombre d'Hôtel qui respecte les critères du Client de l'Agence
        public Msg nbHotelSelonCriteres(string city = "", string startDate = "", string endDate = "", string price = "", string capacity = "")
        {
            int count = 0;

            foreach(Hotel hotel in consultation.hotels)
            {
                if (hotel.localisation.adresse.ville.nom.Equals(city) && float.Parse(hotel.prix, CultureInfo.InvariantCulture.NumberFormat) <= float.Parse(price, CultureInfo.InvariantCulture.NumberFormat) && int.Parse(hotel.capacite) >= int.Parse(capacity))
                    count += 1;
            }

            string msg = "";

            if (count == 1)
                msg = "[i] Félicitation, " + count + " Hôtel correspond à votre recherche !";
            else
                msg = "[i] Félicitation, " + count + " Hôtels correspondent à votre recherche !";

            return new Msg(msg, 1);
        }

        [WebMethod]
        // Renvoi la liste des Hôtels respectant les critères du Client de l'Agence
        public List<Hotel> getHotelsSelonCriteres(string city = "", string startDate = "", string endDate = "", string price = "", string capacity = "")
        {
            List<Hotel> hotels = new List<Hotel>();

            foreach (Hotel hotel in consultation.hotels)
            {
                if (hotel.localisation.adresse.ville.nom.Equals(city) && float.Parse(hotel.prix, CultureInfo.InvariantCulture.NumberFormat) <= float.Parse(price, CultureInfo.InvariantCulture.NumberFormat) && int.Parse(hotel.capacite) >= int.Parse(capacity))
                    hotels.Add(hotel);
            }

            return hotels;
        }

        [WebMethod]
        // Renvoi l'image de la chambre de l'Hôtel demandé
        public byte[] GetImageFile(string fileName)
        {
            try
            {
                byte[] file = System.IO.File.ReadAllBytes(System.Web.Hosting.HostingEnvironment.MapPath("~/img/") + fileName);
                System.Console.WriteLine("Img found !");
                return file;
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }

            return new byte[] { 0 };
        }
    }
}
