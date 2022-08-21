using Microsoft.AspNetCore.Identity;

namespace IdentityCustomProject.Models
{
    public class AppRole : IdentityRole<int>
    {
        public DateTime CreatedDate { get; set; }
    }
}