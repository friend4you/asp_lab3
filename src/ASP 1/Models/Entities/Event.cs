using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_1.Models.Entities
{
    public enum EventType { Birthday, Funeral, Dance}
    public class Event
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { set; get; }
        [Required]
        public string Name{ set; get; }
        [Required]
        public EventType Type { get; set; }
        [Required]
        
        public List<string> Participants { get; set; }
    }
}
