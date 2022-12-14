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
    [Table("Borrowings")]
    public class Borrowing
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BorrowingID { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey(nameof(Student))]
        public int StudentID { get; set; }

        [ForeignKey(nameof(Book))]
        public int BookID { get; set; }

        [NotMapped]
        public virtual Student Student { get; set; }

        [NotMapped]
        public virtual Book Book { get; set; }

    }
}
