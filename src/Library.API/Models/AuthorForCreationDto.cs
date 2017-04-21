using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Models
{
    public class AuthorForCreationDto
    {
        [Required(ErrorMessage = "You should fill out the first name.")]
        [MaxLength(100, ErrorMessage = "The first name shouldn't have more than 100 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You should fill out the last name.")]
        [MaxLength(100, ErrorMessage = "The last name shouldn't have more than 100 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You should fill out the date of birth.")]
        public DateTimeOffset DateOfBirth { get; set; }

        [Required(ErrorMessage = "You should fill out the genre.")]
        public string Genre { get; set; }

        public ICollection<BookForCreationDto> Books { get; set; }
        = new List<BookForCreationDto>();
    }
}
