using Microsoft.AspNetCore.Identity;

namespace Travel_App_Server.Models
{
    public class User : IdentityUser
    {
        public ICollection<Trip> Trips { get; set; }
    }
}
