using System;

namespace BACK.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Categorie { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Task()
        {
            Date = DateTime.Now;
        }
    }
}
