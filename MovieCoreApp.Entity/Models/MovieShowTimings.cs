using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieCoreApp.Entity.Models
{
    public class MovieShowTimings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieShowTimeId { get; set; }
        public Movie movie { get; set; }
        [ForeignKey("movie")]
        public int MovieId { get; set; }
        public DateTime ShowDateTime { get; set; }
    }
}
