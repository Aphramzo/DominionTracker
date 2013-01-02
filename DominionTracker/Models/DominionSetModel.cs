using System;
using System.ComponentModel.DataAnnotations;

namespace DominionTracker.Models
{
    public class DominionSetModel
    {
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}