using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Compta.Models
{
    public enum CompteType
    {
        Debiteur,
        Crediteur
    }
    public class Compte
    {
        public string Id { get; set; }
        public int Numero { get; set; }
        public string Nom{ get; set;}
       // public string Type { get; set; }
        public CompteType Type {  get; set;}
        public bool est_un_group { get; set;}
        public string ParentId { get; set;}
        public Compte Parent { get; set; }
    }
}
