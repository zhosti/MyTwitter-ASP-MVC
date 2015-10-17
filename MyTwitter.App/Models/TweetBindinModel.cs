using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyTwitter.App.Models
{
    public class TweetBindinModel
    {
        [Required]
        [MinLength(10)]
        [MaxLength(200)]
        public string Message { get; set; }
    }
}