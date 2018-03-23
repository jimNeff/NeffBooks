using System.ComponentModel.DataAnnotations;

namespace NeffBooksFour.Data
{
    public class BOOK
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

    }
}
