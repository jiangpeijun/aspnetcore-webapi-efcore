using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCrud.Models
{
    [Table("employee")]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
    }
}
