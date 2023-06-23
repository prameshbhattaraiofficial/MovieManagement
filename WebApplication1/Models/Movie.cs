using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Enum;

namespace WebApplication1.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = " Movie Name")]
        [Required(ErrorMessage =" Enter the Name*")]
        public String Name { get; set; }

        [Display(Name ="Movie Description")]
        [Required(ErrorMessage ="Enter Movie Description")]
        public String Description { get; set; }

        [Display(Name ="Movie Price")]
        [Required(ErrorMessage = "Enter  price*")]
        public double Price { get; set; }


        [Display(Name ="Image URL")]
        [Required(ErrorMessage = "Enter  Imageurl*")]
        public String Imageurl { get; set; }

        [Display(Name ="Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name= "End Date")]
        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        //Relationship

        public List<ActorMovies> ActorMovies { get; set; }

        //Cinema

       

        public int CinemaId { get; set; }
        [ForeignKey ("CinemaId")]

        public Cinema Cinema { get; set; }

        //Producer



        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]

        public Producer Producer { get; set; }


    }
}
