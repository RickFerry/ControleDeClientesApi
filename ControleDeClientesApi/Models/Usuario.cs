using System.ComponentModel.DataAnnotations;

namespace ControleDeClientesApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required] public string Nome { get; set; }

        [Required] [EmailAddress] public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public ICollection<Cliente> Clientes { get; set; }
    }
}