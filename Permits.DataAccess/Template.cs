//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Permits.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Template
    {
        public int TemplateID { get; set; }
        public string TemplateName { get; set; }
        public string TemplateType { get; set; }
        public string TemplateContent { get; set; }
        public int AgencyID { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public string ModifiedByUserID { get; set; }
    }
}
