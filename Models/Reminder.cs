using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Reminder
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Reminder")]
        public string Message { get; set; }

        public DateTime Date { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}