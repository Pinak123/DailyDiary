using DailyDiary.Models;
using Microsoft.EntityFrameworkCore;

namespace DailyDiary.Data
{
	public class DiaryContext : DbContext
	{
        public DiaryContext(DbContextOptions<DiaryContext> options) : base(options)
        {
            
        }
        public DbSet<Diary> Diary { get; set; }
    }
}
