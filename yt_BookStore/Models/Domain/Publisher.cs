using System.ComponentModel.DataAnnotations;

namespace yt_BookStore.Models.Domain
{
    public class Publisher
    {
        public int Id { get; set; }

        [Required]
        public string PublisherName {  get; set; }
    }
}
