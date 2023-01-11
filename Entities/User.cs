using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DorjeDB.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PrimaryEmail { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public bool IsSuperUser { get; set; }
        public bool IsActive { get; set; }
        public bool IsVerified { get; set; }
        public int LoginCount { get; set; }
        public string PasswordResetRequired { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }
        [ForeignKey("Organization")]
        public int OrgId { get; set; }
    }
}
