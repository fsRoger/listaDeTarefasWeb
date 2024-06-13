using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace listaDeTarefasWeb.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "preencha a descrição!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "preencha a descrição!")]
        public DateTime? DataDeVencimento { get; set; }
        [Required(ErrorMessage = "Selecione a data de vencimento!")]
        public string CategoriaId { get; set; }
        [ValidateNever]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "Selecione um status!")]
        public string StatusId { get; set; }
        [ValidateNever]
        public Status Status { get; set; }

        public bool Atrasado =>
            StatusId == "aberto" && DataDeVencimento < DateTime.Today;




    }
}
