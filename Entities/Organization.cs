using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DorjeDB.Entities
{
    public class Organization
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public int ParentOrgId { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
    }
}
