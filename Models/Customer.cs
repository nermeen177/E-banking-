//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_banking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.bills = new HashSet<bill>();
            this.feedbacks = new HashSet<feedback>();
            this.Transcations = new HashSet<Transcation>();
            this.Transcations1 = new HashSet<Transcation>();
        }


        public int acc_Number { get; set; }

        [Required(ErrorMessage = "You have to enter the gender.")]
        public string gender { get; set; }

        [Required(ErrorMessage = "You have to enter the balance.")]
        public double balance { get; set; }

        [Required(ErrorMessage = "You have to enter name .")]
        [StringLength(maximumLength: 50, ErrorMessage = "Maximum 50 characters.")]
        public string name { get; set; }


        [Required(ErrorMessage = "You have to enter the email .")]
        public string email { get; set; }

        [Required(ErrorMessage = "You have to enter username .")]
        [StringLength(maximumLength: 50, ErrorMessage = "Maximum 50 characters.")]
        public string username { get; set; }


        [Required(ErrorMessage = "You have to enter password .")]
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bill> bills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<feedback> feedbacks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transcation> Transcations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transcation> Transcations1 { get; set; }
    }
}
