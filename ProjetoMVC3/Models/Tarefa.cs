using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC3.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título da tarefa é obrigatório")]
        [StringLength(100, ErrorMessage = "O título da tarefa deve ter no máximo 100 caracteres")]
        public required String Titulo { get; set; }

        [Required(ErrorMessage = " A descrição da tarefa é obrigatória")]
        [StringLength(100, ErrorMessage = "A descrição da tarefa deve ter no máximo 300 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O status da tarefa é obrigatório")]
        public bool Status { get; set; }  // true = Aberto, false = Fechado

        //a referência ao projeto ao qual está vinculada.
        public int ProjetoId { get; set; }
        public Projeto? Projeto { get; set; }
    }
}
