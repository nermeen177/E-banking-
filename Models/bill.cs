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

    public partial class bill
    {
        public int id { get; set; }

        [Required(ErrorMessage = "You have to enter the type of bill.")]
        public int type_id { get; set; }
        public int user_id { get; set; }

        [Required(ErrorMessage = "You have to enter the amount.")]
        public double amount { get; set; }

        [Required(ErrorMessage = "You have to enter your code.")]
        public int code_number { get; set; }
    
        public virtual Bill_Type Bill_Type { get; set; }
        public virtual Customer Customer { get; set; }
    }
}