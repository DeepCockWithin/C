using System.ComponentModel.DataAnnotations.Schema;

namespace BooksLibrary.DAL.Entities
{

  public class AuthorIndentity
  {
    [ForeignKey("AuthorInfo")]
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public virtual AuthorInfo AuthorInfo { get; set; }
  }
}
