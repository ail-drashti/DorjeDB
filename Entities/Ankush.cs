using System.ComponentModel.DataAnnotations;

namespace DorjeDB.Entities
{
    public class Ankush
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string MAC { get; set; }
        public string ApiKey { get; set; }
        public string Version { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpireAt { get; set; }
        public bool IsOnline { get; set; }
        public int OrgId { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
