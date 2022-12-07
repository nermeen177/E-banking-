using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_banking.Models
{
    public class ViewTransaction
    {
        public virtual Transcation Transcation { get; set; }
        public virtual bill Bill { get; set; }
    }
}