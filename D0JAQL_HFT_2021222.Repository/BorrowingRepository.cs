using D0JAQL_HFT_2021222.Data;
using D0JAQL_HFT_2021222.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D0JAQL_HFT_2021222.Repository
{
    public class BorrowingRepository : IBorrowingRepository
    {
        LibraryDbContext db;
        public BorrowingRepository(LibraryDbContext db)
        {
            this.db = db;
        }

        public void Create(Borrowing borrowing)
        {
            db.Borrowings.Add(borrowing);
            db.SaveChanges();
        }
        public Borrowing Read(int id)
        {
            return db.Borrowings.FirstOrDefault(x => x.BorrowingID == id);
        }
        public IQueryable<Borrowing> ReadAll()
        {
            return db.Borrowings;
        }
        public void Update(Borrowing borrowing)
        {
            var oldBorrowing = Read(borrowing.BorrowingID);
            oldBorrowing.StudentID = borrowing.StudentID;
            oldBorrowing.BookID = borrowing.BookID;
            oldBorrowing.Date = borrowing.Date;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            db.Remove(Read(id));
            db.SaveChanges();
        }

        
    }
}
