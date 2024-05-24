using System.ComponentModel.DataAnnotations;

namespace TP5.Dtos
{
    public class GenreDto
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
