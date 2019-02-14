using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.DAL.Entities
{
  public class PublisherInfo
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<BookInfo> Books { get; set; }
  }
}
