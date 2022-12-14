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
    [Table("Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }

        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<Borrowing> Borrowings { get; set; }
    }
}
