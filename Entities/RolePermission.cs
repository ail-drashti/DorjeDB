using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DorjeDB.Entities
{
    public class RolePermission
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        [Required]
        [ForeignKey("Permission")]
        public int PermissionId { get; set; }
    }
}
