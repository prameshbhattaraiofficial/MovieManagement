using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Models
{
    public class Actor
    {

        [Key]
        public int ID { get; set; }


        [Display(Name =" Profile Picture URL ")]
        [Required(ErrorMessage ="Please Upload the Image")]
        public string profilepictureUrl { get; set; }

        [Display(Name ="Full Name File Picture Url")]
        [Required(ErrorMessage ="Please Enter Full Name")]
        public string FullName { get; set; }

        [Display(Name =" Bio of the Actor")]
        [Required(ErrorMessage ="Please Upload the Bio")]
        public String  Bio { get; set; }

        public List<ActorMovies> Actor_Movies { get; set; }

       /* public HttpPostedFileBase Imagefile { get; set; }*/

      
    }
}
