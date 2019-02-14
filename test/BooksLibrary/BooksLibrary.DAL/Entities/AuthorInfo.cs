
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksLibrary.DAL.Entities
{
    [Table("Authors")]
    public class AuthorInfo
    {
        public int Id { get; set; }
        public string LastName { get; set; }

        //   public DateTime? Birthda { get; set; }
        public virtual AuthorIndentity AuthorIndentity { get; set; }
        public byte[] Security { get; set; }
        public virtual ICollection<BookInfo> Books { get; set; }
  }
}
