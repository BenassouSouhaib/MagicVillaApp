using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaApi.Models.Dto
{
    public class VillaDto
    {
        public int Id { get; set; }

        [Required]
        [MinLength(30)]
        public string Name { get; set; }
    }
}
