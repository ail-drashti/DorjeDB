using System.ComponentModel.DataAnnotations;

namespace DorjeDB.Entities
{
    public class OrganizationType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
