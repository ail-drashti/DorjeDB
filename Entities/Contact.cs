using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DorjeDB.Entities
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string PersonName { get; set; }
        [ForeignKey("Ankush")]
        public int AnkushId { get; set; }
        [ForeignKey("Organization")]
        public int OrganizationId { get; set; }
        public Ankush Ankush { get; set; }
    }
}
