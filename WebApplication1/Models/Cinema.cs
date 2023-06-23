using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Cinema
    {

        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        public String CinemaLogo { get; set; }

        [Display(Name ="Cinema Name")]
        public String  Name { get; set; }

        [Display(Name ="Cinema Description")]
        public String Description { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
