using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitter.Model
{
    public class Tweet
    {
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(200)]
        public string Message { get; set; }

        public virtual User User { get; set; }

        public DateTime TimeStamp { get; set; }

    }
}
