using System.ComponentModel.DataAnnotations;

namespace DorjeDB.Entities
{
    public class Permission
    {
        [Key]
        public int PermissionId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
