//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE
{
    using System;
    using System.Collections.Generic;
    
    public partial class utilisateur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public utilisateur()
        {
            this.commentaire__enquete = new HashSet<commentaire__enquete>();
            this.commentaire__quizz = new HashSet<commentaire__quizz>();
            this.commentaire__sondage = new HashSet<commentaire__sondage>();
            this.quizz__complet = new HashSet<quizz__complet>();
            this.sondage__complet = new HashSet<sondage__complet>();
            this.reponse__sequence = new HashSet<reponse__sequence>();
            this.reponse__sondage = new HashSet<reponse__sondage>();
            this.reponse__quizz = new HashSet<reponse__quizz>();
        }
    
        public int id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public string Login { get; set; }
        public string password { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
        public string username { get; set; }
        public string username_canonical { get; set; }
        public string email { get; set; }
        public string email_canonical { get; set; }
        public bool enabled { get; set; }
        public string salt { get; set; }
        public Nullable<System.DateTime> last_login { get; set; }
        public string confirmation_token { get; set; }
        public Nullable<System.DateTime> password_requested_at { get; set; }
        public string roles { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commentaire__enquete> commentaire__enquete { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commentaire__quizz> commentaire__quizz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commentaire__sondage> commentaire__sondage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<quizz__complet> quizz__complet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sondage__complet> sondage__complet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reponse__sequence> reponse__sequence { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reponse__sondage> reponse__sondage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reponse__quizz> reponse__quizz { get; set; }
    }
}
