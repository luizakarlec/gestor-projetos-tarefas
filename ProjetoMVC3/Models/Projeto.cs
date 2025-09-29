using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC3.Models
{
    public class Projeto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do projeto é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome do projeto deve ter no máximo 100 caracteres")]
        public required String Nome { get; set; }

        [Required(ErrorMessage = "O cliente do projeto é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome do cliente deve ter no máximo 100 caracteres")]
        public required String Cliente { get; set; }

        [Required(ErrorMessage = "A data de inicio do projeto é obrigatória")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Inicio")]
        public DateTime DataInicio { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Termino")]
        public DateTime? DataTermino { get; set; }

        public ICollection<Tarefa>? Tarefas { get; set; }
    }
}
