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
    
    public partial class reponse__sequence
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public reponse__sequence()
        {
            this.utilisateurs = new HashSet<utilisateur>();
        }
    
        public int id { get; set; }
        public Nullable<int> question_reponse_id { get; set; }
        public string Intitule { get; set; }
    
        public virtual question__sequence question__sequence { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<utilisateur> utilisateurs { get; set; }
    }
}