using System.ComponentModel.DataAnnotations;

namespace Clinica_UPQROO.Models
{
    public class Persona
    {
        [Key]
        public int PkPersona { get; set; }
        public string Nombre { get; set; }

        public Terapeuta Terapeuta { get; set; }

        public ICollection<CartaConsentimiento> CartasConsentimiento { get; set; }
    }


}
