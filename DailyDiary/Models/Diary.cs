using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DailyDiary.Models
{
	public class Diary
	{
        [Key]
        public int SrNo { get; set; }
        public string Diary_Content { get; set; }
        public DateTime Diary_Entry_Date { get; set; }
        public string Author { get; set; }
    }
	
}
