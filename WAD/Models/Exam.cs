using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Exam Subject")]
        public string Subject { get; set; }
        [Display(Name = "Start Time")]
        [Required(ErrorMessage = "Start time is require")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        [Display(Name = "Exam Date")]
        [Required(ErrorMessage = "Exam date is require")]
        [DataType(DataType.Date)]
        public DateTime ExamDate { get; set; }
        [Display(Name = "Exam Duration")]
        [Required(ErrorMessage = "Duration is require")]
        public int Duration { get; set; }
        [Display(Name = "Class Room")]
        public string ClassRoom { get; set; }
        [Display(Name = "Faculty")]
        public string Faculty { get; set; }
        public int status { get; set; }
    }
}