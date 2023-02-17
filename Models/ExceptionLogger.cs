using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace WebCalculator.Models
{
    public class ExceptionLogger
    {
        [Key]
        public int Id { get; set; }
        public string ExceptionMessage { get; set; }
        public string ExceptionStackTrace { get; set; }
        public DateTime LogTime { get; set; }
    }
}
