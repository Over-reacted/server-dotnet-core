using System;
using System.ComponentModel.DataAnnotations;

namespace JobBoard.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }
        
        public string Role { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime UpdatedAd { get; set; }
    }
}