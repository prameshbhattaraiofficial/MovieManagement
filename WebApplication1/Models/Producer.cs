using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture Url")]
        [Required(ErrorMessage ="Please Upload the picture")]
        public String  ProfilePicture { get; set; }

        [Display(Name = "Full Name of Producer")]
        [Required(ErrorMessage ="")]
        [StringLength(50, MinimumLength =3, ErrorMessage =" Please Give a Full Name")]
        public String FullName { get; set; }

        [Display(Name ="Bio of Producer")]
        [Required(ErrorMessage =" Enter The Bio")]
        public String Bio { get; set; }

        public List<Movie> movies { get; set; }
    }
}
