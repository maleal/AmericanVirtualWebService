//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal PrecioUnitario { get; set; }
        public byte[] Imagen { get; set; }
    
        public virtual Categories Categories { get; set; }
    }
}
