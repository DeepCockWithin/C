using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.DAL.Entities
{
  public class BookInfo
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public DateTime? Date { get; set; }
    public int PublisherId { get; set; }
    public virtual PublisherInfo PublisherInfo { get; set; }
    public virtual ICollection<AuthorInfo> Authors { get; set; }
  }
}
