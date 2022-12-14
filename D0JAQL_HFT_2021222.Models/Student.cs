using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace D0JAQL_HFT_2021222.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(1)]
        public string StudentClass { get; set; }
        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<Borrowing> Borrowings { get; set; }

        public Student()
        {
            Borrowings = new HashSet<Borrowing>();
        }
    }
}
