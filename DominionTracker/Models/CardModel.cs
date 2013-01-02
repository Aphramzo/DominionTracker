using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DominionTracker.Models
{
    public class CardModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public String Name { get; set; }

        [Required]
        [Display(Name="Cost")]
        public int Cost { get; set; }

        [Required]
        [Display(Name="Requires Potion")]
        public bool CostPotion { get; set; }

        [Display(Name = "From")]
        public DominionSetModel DominionSet { get; set; }

        [Display(Name="Card Text")]
        public String CardText { get; set; }

        [Display(Name="+ Cards")]
        public int PlusCards { get; set; }

        [Display(Name = "+ Actions")]
        public int PlusActions { get; set; }

        [Display(Name = "+ Coins")]
        public int PlusCoins { get; set; }

        [Display(Name = "+ Buys")]
        public int PlusBuys { get; set; }
        
    }
}