using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Agence_de_voyage__Application_.Consultation;
using Agence_de_voyage__Application_.Reservation;
using System.IO;
using System.Threading;

namespace Agence_de_voyage__Application_
{
    public class SystemeReservation
    {
        Consultation.Consultation_Hotel consultation;
        Reservation.Reservation_Hotel reservation;
  
        bool connecteConsultation;
        bool connecteReservation;

        string idReservation;
        string nbPersonne;
        double nbNuit;

        public SystemeReservation()
        {
            consultation = new Consultation_Hotel();
            reservation = new Reservation_Hotel();
            
            connecteConsultation = false;
            connecteReservation = false;

            idReservation = "";
            nbPersonne = "";
            nbNuit = 0;
            

            System.Console.WriteLine("[i] : Information");
            System.Console.WriteLine("[*] : Demande de saisie");
            System.Console.WriteLine("/!\\ : Arrêt du Système de Réservation");
        }

        public int LoginConsultation(string idAgence, string motDePasse) {

            Consultation.Msg response = new Consultation.Msg();

            try
            {
                response = consultation.VerificationAgencePartenaire(idAgence, motDePasse);
            }
            catch
            {
                System.Console.WriteLine("\n/!\\ Le Web Service doit être lancé avant l'application, fin du programme.");
                response.code = 0;
            }
            
            if (response.code == 1)
                connecteConsultation = true;

            System.Console.WriteLine("\n" + response.msg);

            return response.code;
        }

        public int LoginReservation(string idAgence, string motDePasse)
        {
            if (!connecteConsultation)
                return 0;

            Reservation.Msg response = reservation.VerificationAgencePartenaire(idAgence, motDePasse);

            if (response.code == 1)
                connecteReservation = true;

            System.Console.WriteLine("\n" + response.msg);

            return response.code;
        }

        public int MenuConsultation()
        {
            if (!connecteConsultation)
                return 0;

            CultureInfo culture = new CultureInfo("fr-FR");

            Consultation.Msg response = new Consultation.Msg();
      
            string cityUserInput = "";
            string startUserInput = "";
            string endUserInput = "";
            string priceUserInput = "";
            string nbrUserInput = "";
            string souhaiteReserver = "";

            System.Console.WriteLine("\n****************************");
            System.Console.WriteLine("*** CONSULTATION D'HÔTEL ***");
            System.Console.WriteLine("****************************");

            System.Console.Write("\n[i] Villes disponibles : ");
            System.Console.WriteLine(string.Join(", ", consultation.VillesDisponibles()));

            System.Console.WriteLine("\n[*] Dans quelle Ville souhaitez-vous réserver un Hôtel ?");
            System.Console.Write("> ");

            cityUserInput = Console.ReadLine();

            if ((response = consultation.VerificationSaisieUtilisateur(1, cityUserInput, "", "", "", "", "")).code == 0) {
                System.Console.WriteLine(response.msg);
                connecteConsultation = false;
                return response.code;
            }

            System.Console.WriteLine("\n[*] Quelle est la date d'arrivée ? (format : jj/mm/aaaa)");
            System.Console.Write("> ");
            startUserInput = Console.ReadLine();

            if ((response = consultation.VerificationSaisieUtilisateur(2, cityUserInput, startUserInput, "", "", "", "")).code == 0)
            {
                System.Console.WriteLine(response.msg);
                connecteConsultation = false;
                return response.code;
            }

            System.Console.WriteLine("\n[*] Quelle est la date de départ ? (format : jj/mm/aaaa)");
            System.Console.Write("> ");
            endUserInput = Console.ReadLine();

            if ((response = consultation.VerificationSaisieUtilisateur(3, cityUserInput, startUserInput, endUserInput, "", "", "")).code == 0)
            {
                System.Console.WriteLine(response.msg);
                connecteConsultation = false;
                return response.code;
            }

            nbNuit = (Convert.ToDateTime(endUserInput, new CultureInfo("fr-FR")) - Convert.ToDateTime(startUserInput, new CultureInfo("fr-FR"))).TotalDays;

            System.Console.WriteLine("\n[i] Les prix appartiennent à l'intervalle suivant : " + consultation.FourchettePrix());
            System.Console.WriteLine("\n[*] Combien êtes-vous prêt à dépenser maximum ?");
            System.Console.Write("> ");
            priceUserInput = Console.ReadLine();

            if ((response = consultation.VerificationSaisieUtilisateur(4, cityUserInput, startUserInput, endUserInput, priceUserInput, "", "")).code == 0)
            {
                System.Console.WriteLine(response.msg);
                connecteConsultation = false;
                return response.code;
            }

            System.Console.WriteLine("\n[i] Tous les Hôtels de notre Agence sont 5 étoiles");

            System.Console.WriteLine("\n[*] Combien de personnes maximum faut-il héberger ?");
            System.Console.Write("> ");
            nbrUserInput = Console.ReadLine();

            if ((response = consultation.VerificationSaisieUtilisateur(5, cityUserInput, startUserInput, endUserInput, priceUserInput, nbrUserInput, "")).code == 0)
            {
                System.Console.WriteLine(response.msg);
                connecteConsultation = false;
                return response.code;
            }

            if ((response = consultation.nbHotelSelonCriteres(cityUserInput, startUserInput, endUserInput, priceUserInput, nbrUserInput)).code >= 1)
                System.Console.WriteLine(response.msg);

            List<Consultation.Hotel> reservationUtilisateur = consultation.getHotelsSelonCriteres(cityUserInput, startUserInput, endUserInput, priceUserInput, nbrUserInput).ToList();

            foreach (Consultation.Hotel hotel in reservationUtilisateur)
            {
                System.Console.WriteLine("\n" + hotel.infoHotel);

                System.Console.WriteLine("\n[*] Souhaitez-vous réserver cet Hôtel ? (Oui/Non)");
                System.Console.Write("> ");
                souhaiteReserver = Console.ReadLine();

                if ((response = consultation.VerificationSaisieUtilisateur(5, cityUserInput, startUserInput, endUserInput, priceUserInput, nbrUserInput, souhaiteReserver)).code == 0)
                {
                    System.Console.WriteLine(response.msg);
                    connecteConsultation = false;
                    return response.code;
                }

                if (souhaiteReserver.Equals("Oui"))
                {
                    idReservation = hotel.id;
                    nbPersonne = nbrUserInput;
                    System.Console.WriteLine("\n[i] Vous avez souhaité réserver cet Hôtel. Une image de votre future chambre va être affiché...");
                    Thread.Sleep(1000);
                    string filePath = "room.jpg";

                    try
                    {
                        File.WriteAllBytes(filePath, Convert.FromBase64String(hotel.imgChambre));
                        System.Diagnostics.Process.Start(filePath);
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine(e.StackTrace);
                    }

                    return 1;
                }
            }

            System.Console.WriteLine("/!\\ Vous avez décidé de ne pas réserver d'Hôtel, fin de la réservation.");

            connecteConsultation = false;

            return 0;
        }

        public int MenuReservation()
        {
            if (!connecteReservation)
                return 0;

            string lastname = "";
            string firstname = "";
            string creditCard = "";

            System.Console.WriteLine("\n***************************");
            System.Console.WriteLine("*** RÉSERVATION D'HÔTEL ***");
            System.Console.WriteLine("***************************");

            System.Console.WriteLine("\n[i] Vous avez choisi de réserver l'offre d'identifiant : " + idReservation);

            System.Console.WriteLine("\n[*] Veuillez saisir votre Nom : ");
            System.Console.Write("> ");
            lastname = Console.ReadLine();

            System.Console.WriteLine("\n[*] Veuillez saisir votre Prénom : ");
            System.Console.Write("> ");
            firstname = Console.ReadLine();

            System.Console.WriteLine("\n[*] Veuillez saisir votre Numéro de Carte Bleu : ");
            System.Console.Write("> ");
            creditCard = Console.ReadLine();

            System.Console.WriteLine("\n[i] La Réservation a bien eu lieu !");

            Reservation.Reservation res = reservation.traitementReservation(lastname, firstname, creditCard, this.idReservation, this.nbPersonne, this.nbNuit);

            System.Console.WriteLine(res.recapitulatif);

            System.Console.WriteLine("\n[i] Notre Agence vous remercie pour votre confiance, à bientôt !");

            return 1;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            SystemeReservation sys = new SystemeReservation();
           
            /* Connexion au Web Service Consultation */
            sys.LoginConsultation("@identifiant1", "agence34.");
            
            sys.MenuConsultation();

            /* Connexion au Web Service Réservation */
            sys.LoginReservation("@identifiant1", "agence34.");

            sys.MenuReservation();
        }
    }
}
