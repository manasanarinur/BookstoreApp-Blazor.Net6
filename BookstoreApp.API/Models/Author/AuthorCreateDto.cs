using System.ComponentModel.DataAnnotations;

namespace BookstoreApp.API.Models.Author
{
    public class AuthorCreateDto
    {
       
        
            [Required]
            [StringLength(50)]
            public string FirstName { get; set; }
            public int LastName { get; set; }
            [StringLength(250)]
            public int Bio { get; set; }
        
    }
}
