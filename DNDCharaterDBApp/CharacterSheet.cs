//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DNDCharaterDBApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class CharterSheet
    {
        public int SheetID { get; set; }
        public string CharterName { get; set; }
        public int Race { get; set; }
        public int Description { get; set; }
        public int @class { get; set; }
    
        public virtual Class Class1 { get; set; }
        public virtual Description Description1 { get; set; }
        public virtual Race Race1 { get; set; }
    }
}