using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataContext.Models
{
    [Table(name: "Entries")]
    public class Entry
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Title { get; set; }

        public int Value { get; set; }
    }
}