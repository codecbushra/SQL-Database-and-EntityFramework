//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPT.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookIssue
    {
        public int Id { get; set; }
        public string IssueDate { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Member Member { get; set; }
    }
}
