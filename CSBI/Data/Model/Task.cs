using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSBI.Data.Model
{
    public class Task
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // Id

        [Required]
        public string Name { get; set; } // Название

        private DateTime start; // Дата и время начала
        public DateTime Start
        {
            get
            {
                return this.start;
            }
            set
            {
                this.start = DateTime.Now;
            }
        }

        private DateTime end; // Дата и время окончания
        public DateTime End
        {
            get
            {
                return this.end;
            }
            set
            {
                this.end = this.start.AddHours(2);
            }
        }

        public TimeSpan EndSpan // Осталось
        {
            get
            {
                return this.end.Subtract(DateTime.Now);
            }
        }

        public TaskStatus Status { get; set; } // Статус
    }
}
