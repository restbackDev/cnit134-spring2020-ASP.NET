using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EventsApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Time { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public string Type { get; set; }
    }
}
