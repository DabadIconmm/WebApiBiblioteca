using System.ComponentModel.DataAnnotations;

namespace Ejercicio_Sesión_1.Entidades
{
    public class Libro
    {
        //Comentario para el segundo Commit Post Reflog
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; } //añadir limite de caracteres 150max
        public int Paginas { get; set; } //rango entre 1 - 10000
        public int EditorialId { get; set; }
        public Editorial Editorial { get; set; }
    }
}
