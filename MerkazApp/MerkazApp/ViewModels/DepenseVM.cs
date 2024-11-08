using System.ComponentModel;

namespace MerkazApp.ViewModels
{
    public class DepenseVM
    {
        public int DepenseID { get; set; }
        [DisplayName("Type de dépense")]
        public String Type { get; set; }
        public String Categorie { get; set; }

        [DisplayName("Description")]
        public String Titre { get; set; }

        [DisplayName("Date de Création")]
        public DateTime DateCreation { get; set; }

        public Double Montant { get; set; }
        public String Frequence { get; set; }
        
        public DepenseVM(int DepenseID = 0, String type = null, String Categorie = null, String titre = null, Double montant = 0, String frequence = null)
        {
            this.DepenseID = DepenseID;
            this.Type = type;
            this.Titre = titre;
            this.Montant = montant;
            this.Frequence = frequence;
            this.Categorie = Categorie; 

            this.DateCreation = DateTime.Now;

        }
    }
}
