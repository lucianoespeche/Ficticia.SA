using System.ComponentModel.DataAnnotations;

namespace CRUDfictisiaLuciano.Models
{
    public class DATOSSEGUROmodel
    {
        public int identificacion { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string? nombrecompleto { get; set; }
        [Required(ErrorMessage = "El campo edad es obligatorio")]
        public int edad { get; set; }
        [Required(ErrorMessage = "El campo género es obligatorio")]
        public string? genero { get; set; }
        [Required(ErrorMessage = "El campo estado es obligatorio")]
        public string? estado { get; set; }
        [Required(ErrorMessage = "El campo maneja es obligatorio")]
        public string? maneja { get; set; }
        [Required(ErrorMessage = "El campo lentes es obligatorio")]
        public string? lentes { get; set; }
        [Required(ErrorMessage = "El campo diabetico es obligatorio")]
        public string? diabetico { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? otraenfermedad { get; set; }
    }
}