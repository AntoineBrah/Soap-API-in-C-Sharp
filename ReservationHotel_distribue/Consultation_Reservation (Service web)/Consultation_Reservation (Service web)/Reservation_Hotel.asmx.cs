using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Consultation_Reservation__Service_web_
{
    // Système Réservation
    public class Reservation
    {
        public Client client { get; set; }
        public string idReservation { get; set; }
        public string nbPersonne { get; set; }

        public double nbNuit { get; set; }
        public string recapitulatif { get; set; }

        public Reservation() {
            this.client = new Client();
            this.idReservation = "";
            this.nbPersonne = "";
            this.nbNuit = 0;
            this.recapitulatif = "";
        }

        public Reservation(string nom, string prenom, string carteBancaire, string id, string nbPersonne, double nbNuit)
        {
            this.client = new Client(nom, prenom, carteBancaire);
            this.idReservation = id;
            this.nbPersonne = nbPersonne;
            this.nbNuit = nbNuit;
            this.recapitulatif = this.getRecapitulatifReservation();
        }

        public Hotel getHotel()
        {
            return BDDHotels.GetHotels().Find(hotel => hotel.id.Equals(this.idReservation));
        }

        public string getRecapitulatifReservation() => "\n*********************************\n*** RÉCAPITULATIF RÉSERVATION ***\n*********************************\n" + "\n► Nom : " + this.client.nom + "\n► Prénom : " + this.client.prenom + "\n► Hôtel : " + this.getHotel().nom + "\n► Lieu : " + this.getHotel().localisation.pays + ", " + this.getHotel().localisation.adresse.ville.nom + "\n► Nombre : " + this.nbPersonne + " personne(s)" + "\n► Nombre de nuit : " + this.nbNuit + "\n► Tarif : " + int.Parse(this.nbPersonne) * int.Parse(this.getHotel().prix) * nbNuit + " euros" + "\n\n*********************************" + "\n*********************************";
    }

    /// <summary>
    /// Description résumée de Reservation_Hotel
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class Reservation_Hotel : System.Web.Services.WebService
    {
        [WebMethod]
        // On vérifie que l'Agence qui essaye de se connecter est bien une Agence partenaire
        public Msg VerificationAgencePartenaire(string idAgence, string password)
        {
            foreach (Agence ag in BDDAgences.GetAgences())
            {
                if (ag.id.Equals(idAgence) && ag.password.Equals(password))
                    return new Msg("[i] Vérification de l'Agence en cours....... OK\n[i] La procédure de réservation va avoir lieu...", 1);
            }

            return new Msg("[i] Vérification de l'Agence en cours....... FAIL\n/!\\ Cette Agence ne fait pas parti de nos Agences partenaires, fin de la réservation.", 0);
        }

        [WebMethod]
        // L'utilisateur précise l'id de l'offre auquel il souhaite effectuer une réservation
        public Reservation traitementReservation(string nom, string prenom, string carteBancaire, string id, string nbPersonne, double nbNuit)
        {
            return new Reservation(nom, prenom, carteBancaire, id, nbPersonne, nbNuit);
        }
    }
}
