//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaveYouSeeMe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class webpages_Roles
    {
        public webpages_Roles()
        {
            this.UserProfiles = new HashSet<UserProfile>();
        }
    
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
