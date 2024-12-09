namespace Compta.Models
{
    public class Societe
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Abreviation { get; set; }
        public string Devise { get; set; }
        public Compte Clients { get; set; }
        public Compte Fournisseurs { get; set; }
        public Compte Caisse { get; set; }
        public Compte Banque { get; set; }

    }
}
