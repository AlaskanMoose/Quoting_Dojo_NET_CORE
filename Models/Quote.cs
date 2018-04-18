using System;
using System.ComponentModel.DataAnnotations;

namespace quoting_dojo2.Models{
    public class Quote: BaseEntity {
        [Key]
        public int QuoteId {get; set;}

        [Required]
        public string Name {get; set;}

        [Required]
        public string Content {get; set;}

        public DateTime CreatedAt {get; set;}

        public Quote(){
            CreatedAt = DateTime.Now;
        }
    }
}